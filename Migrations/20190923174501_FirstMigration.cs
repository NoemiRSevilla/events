using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace exam.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "activitays",
                columns: table => new
                {
                    ActivitayId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Day = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    DurationInfo = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activitays", x => x.ActivitayId);
                    table.ForeignKey(
                        name: "FK_activitays_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RSVPs",
                columns: table => new
                {
                    RSVPId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActivitayId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSVPs", x => x.RSVPId);
                    table.ForeignKey(
                        name: "FK_RSVPs_activitays_ActivitayId",
                        column: x => x.ActivitayId,
                        principalTable: "activitays",
                        principalColumn: "ActivitayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RSVPs_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_activitays_UserId",
                table: "activitays",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_ActivitayId",
                table: "RSVPs",
                column: "ActivitayId");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_UserId",
                table: "RSVPs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RSVPs");

            migrationBuilder.DropTable(
                name: "activitays");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
