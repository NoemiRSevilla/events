using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using exam.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using exam;

// Other using statements
namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string UserInSession = HttpContext.Session.GetString("Email");
            if (UserInSession != null)
            {
                return RedirectToAction("Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost("submit")]
        public IActionResult Submit(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.users.Any(u => u.Email == newUser.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    // You may consider returning to the View at this point
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                    HttpContext.Session.SetString("Email", newUser.Email);
                    return RedirectToAction($"Home");
                }
            }
            else
            {
                TempData["First Name"] = newUser.FirstName;
                TempData["Last Name"] = newUser.LastName;
                TempData["Email"] = newUser.Email;
                return View("Index");
            }
        }

        [HttpPost("submitlogin")]
        public IActionResult submitlogin(LoginUser retrievedUser)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.users.FirstOrDefault(u => u.Email == retrievedUser.LoginEmail);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "You could not be logged in");
                    return View("Index");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();

                // verify provided password against hash stored in dbcopy
                var result = hasher.VerifyHashedPassword(retrievedUser, userInDb.Password, retrievedUser.LoginPassword);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "You could not be logged in");
                    return View("Index");
                }
                HttpContext.Session.SetString("Email", retrievedUser.LoginEmail);
                return RedirectToAction("Home");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpGet("new")]
        public IActionResult ActivitayForm()
        {
            string UserInSession = HttpContext.Session.GetString("Email");
            User retrievedUser = dbContext.users.FirstOrDefault(c => c.Email == UserInSession);
            ViewBag.creator = retrievedUser;

            return View();
        }

        [HttpPost("submitActivitay")]
        public IActionResult submitActivitay(Activitay newActivitay)
        {
            string UserInSession = HttpContext.Session.GetString("Email");
            User retrievedUser = dbContext.users.FirstOrDefault(c => c.Email == UserInSession);

            if (ModelState.IsValid)
            {
                dbContext.Add(newActivitay);
                dbContext.SaveChanges();
                ViewBag.creator = retrievedUser;
                return Redirect($"/activity/{newActivitay.ActivitayId}");
            }
            else
            {
                TempData["Title"] = newActivitay.Title;
                TempData["Day"] = newActivitay.Day;
                TempData["Duration"] = newActivitay.Duration;
                TempData["Description"] = newActivitay.Description;

                ViewBag.creator = retrievedUser;
                return View("ActivitayForm");
            }
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            string UserInSession = HttpContext.Session.GetString("Email");
            if (UserInSession != null)
            {
                User retrievedUser = dbContext.users.FirstOrDefault(u => u.Email == UserInSession);
                
                List <Activitay> AllActivitays = dbContext.activitays
                .Include(r => r.RSVPs)
                .ThenInclude (u => u.Attendees)
                .Include (c => c.Creator)
                .OrderBy(a => a.Day)
                .ToList();


                ViewBag.current = retrievedUser;
                return View(AllActivitays);
            }
            else
            {
                return RedirectToAction("Logout");
            }
        }
        [HttpGet("activity/{ActivitayId}")]
        public IActionResult ShowActivitay(int ActivitayId)
        {
            string UserInSession = HttpContext.Session.GetString("Email");
            if (UserInSession != null)
            {
                User retrievedUser = dbContext.users.FirstOrDefault(u => u.Email == UserInSession);

                Activitay ActivitayInfo = dbContext.activitays
                .Include(a => a.RSVPs)
                .ThenInclude(g => g.Attendees)
                .Include(c => c.Creator)
                .FirstOrDefault(u => u.ActivitayId == ActivitayId);
                ViewBag.current = retrievedUser;
                return View(ActivitayInfo);
            }
            else
            {
                return RedirectToAction("Logout");
            }
        }

        [HttpGet("delete")]
        public IActionResult DeleteActivitay(int ActivitayId)
        {
            Activitay ActivitayInfo = dbContext.activitays.FirstOrDefault(u => u.ActivitayId == ActivitayId);
            dbContext.activitays.Remove(ActivitayInfo);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet("activity/{ActivitayId}/add/{UserId}")]
        public IActionResult GuestRSVP(Activitay theActivitay, int ActivitayId, int UserId)
        {
            RSVP newRSVP = new RSVP();
            newRSVP.UserId = UserId;
            newRSVP.ActivitayId = ActivitayId;
            dbContext.RSVPs.Add(newRSVP);
            dbContext.SaveChanges();

            return Redirect($"/activity/{theActivitay.ActivitayId}");
        }

        [HttpGet("guest/{ActivitayId}/remove/{UserId}")]
        public IActionResult unRSVP(Activitay theActivitay, int ActivitayId, int UserId)
        {
            RSVP unRSVP = dbContext.RSVPs
            .FirstOrDefault(u => u.UserId == UserId && u.ActivitayId == ActivitayId);

            dbContext.RSVPs.Remove(unRSVP);
            dbContext.SaveChanges();
            return Redirect($"/activity/{theActivitay.ActivitayId}");
        }
    }
}