#pragma checksum "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c649618bd20b85c9365cda4a39259aaae877a0cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(exam.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(exam.Views_Home_Home))]
namespace exam
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
using exam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649618bd20b85c9365cda4a39259aaae877a0cb", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"441d8724368ba7a11d18df9b2b6177a88c30e417", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Activitay>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "unRSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteActivitay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuestRSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(44, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c649618bd20b85c9365cda4a39259aaae877a0cb6224", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(90, 213, true);
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\n");
            EndContext();
            BeginContext(303, 2078, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c649618bd20b85c9365cda4a39259aaae877a0cb7679", async() => {
                BeginContext(309, 534, true);
                WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-light bg-dark"">
    <h1 class=""white mr-auto text col"">Dojo Activity Center</h1>
    <a href=""/logout"" class=""btn-btn-primary"">Log Out</a>
</nav>
<table class=""table table-dark"">
    <thead>
    <tr>
        <th scope=""col"">Activity</th>
        <th scope=""col"">Date and Time</th>
        <th scope=""col"">Duration</th>
        <th scope=""col"">Event Coordinator</th>
        <th scope=""col"">Number of Participants</th>
        <th scope=""col"">Actions</th>
    </tr>
    </thead>
    <tbody>
");
                EndContext();
#line 24 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
         foreach (var a in Model)
        {
            DateTime CurrentTime = DateTime.Now;
            

#line default
#line hidden
#line 27 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
             if(a.Day < CurrentTime)
            {
                continue;
            }
            else
            {

#line default
#line hidden
                BeginContext(1058, 43, true);
                WriteLiteral("                <tr>\n                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1101, "\"", 1131, 2);
                WriteAttributeValue("", 1108, "activity/", 1108, 9, true);
#line 34 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
WriteAttributeValue("", 1117, a.ActivitayId, 1117, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1132, 2, true);
                WriteLiteral("> ");
                EndContext();
                BeginContext(1135, 7, false);
#line 34 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                                                  Write(a.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1142, 26, true);
                WriteLiteral("</td>\n                <td>");
                EndContext();
                BeginContext(1169, 5, false);
#line 35 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
               Write(a.Day);

#line default
#line hidden
                EndContext();
                BeginContext(1174, 26, true);
                WriteLiteral("</td>\n                <td>");
                EndContext();
                BeginContext(1201, 10, false);
#line 36 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
               Write(a.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(1211, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1213, 14, false);
#line 36 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                           Write(a.DurationInfo);

#line default
#line hidden
                EndContext();
                BeginContext(1227, 26, true);
                WriteLiteral("</td>\n                <td>");
                EndContext();
                BeginContext(1254, 19, false);
#line 37 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
               Write(a.Creator.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1273, 26, true);
                WriteLiteral("</td>\n                <td>");
                EndContext();
                BeginContext(1300, 15, false);
#line 38 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
               Write(a.RSVPs.Count());

#line default
#line hidden
                EndContext();
                BeginContext(1315, 31, true);
                WriteLiteral("</td>\n                    <td>\n");
                EndContext();
#line 40 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                         if (a.RSVPs.Any(r => r.UserId == ViewBag.current.UserId))
                        {

#line default
#line hidden
                BeginContext(1455, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1483, 160, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c649618bd20b85c9365cda4a39259aaae877a0cb12287", async() => {
                    BeginContext(1634, 5, true);
                    WriteLiteral("Leave");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ActivitayId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 42 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                                                                                                            WriteLiteral(a.ActivitayId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ActivitayId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ActivitayId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ActivitayId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 42 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                                                                                                                                              WriteLiteral(ViewBag.current.UserId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1643, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 43 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                        }
                        else if (ViewBag.current.UserId == a.UserId)
                        {

#line default
#line hidden
                BeginContext(1765, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1793, 126, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c649618bd20b85c9365cda4a39259aaae877a0cb16273", async() => {
                    BeginContext(1909, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ActivitayId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 46 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                                                                                                                    WriteLiteral(a.ActivitayId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ActivitayId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ActivitayId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ActivitayId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1919, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 47 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2001, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2029, 163, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c649618bd20b85c9365cda4a39259aaae877a0cb19435", async() => {
                    BeginContext(2184, 4, true);
                    WriteLiteral("Join");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ActivitayId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 50 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                                                                                                                WriteLiteral(a.ActivitayId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ActivitayId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ActivitayId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ActivitayId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 50 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                                                                                                                                                  WriteLiteral(ViewBag.current.UserId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2192, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 51 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
                        }

#line default
#line hidden
                BeginContext(2219, 48, true);
                WriteLiteral("                    </td>\n                </tr>\n");
                EndContext();
#line 54 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
            }

#line default
#line hidden
#line 54 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/exam/exam/Views/Home/Home.cshtml"
             
        }

#line default
#line hidden
                BeginContext(2291, 83, true);
                WriteLiteral("    </tbody>\n</table>\n\n<a href=\"/new\" class=\"btn btn-primary\">Add New Activity</a>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Activitay>> Html { get; private set; }
    }
}
#pragma warning restore 1591
