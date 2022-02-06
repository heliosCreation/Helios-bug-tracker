using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_CreatorId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_CreatorId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "201f37ed-ef6c-46a1-baee-8b91b1015afe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2949bb27-bf03-4292-aa83-33cc2d51e6d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33371c20-f3f3-425e-9bce-8ebc34164628");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33e54577-2cc8-440b-a662-6cf0988ee144");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "617f7e8b-1113-4c6d-a5af-b581afcf1fe9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9326d96f-710c-4271-a1bf-3ce42fc4d304");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1cd1e56-6e51-487c-9d19-192ad3930b41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0eef021-5290-41a6-a3a5-3efbd0defc8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e1bcd79-75c2-4fb6-8a92-c523d5e45bc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e961af6-cf8b-474c-b01c-75c9e9282259");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a44f0655-bbc5-4f38-a5a4-fbb38f885936");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d99bb16f-40ba-406a-8c48-d72f1ba6e5a2");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Tickets");

            migrationBuilder.CreateTable(
                name: "ApplicationUserProject",
                columns: table => new
                {
                    ProjectsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProject", x => new { x.ProjectsId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserProject_AspNetUsers_TeamId",
                        column: x => x.TeamId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserTicket",
                columns: table => new
                {
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TicketsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserTicket", x => new { x.TeamId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserTicket_AspNetUsers_TeamId",
                        column: x => x.TeamId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "618f7afc-1bac-4e70-8830-ce93b905f9e8", "0a3a0b52-980f-459d-9936-cb41426c416a", "Admin", "ADMIN" },
                    { "e7ce1aea-655e-4c41-8d46-5b29141645a1", "0eb995e2-071f-4c20-a02e-46e372d60146", "Project Manager", "PROJECT MANAGER" },
                    { "dd5e03ce-6577-41ae-89bf-5b95631414b8", "beeb007f-a52f-411f-9e37-1c13890131f3", "Developer", "DEVELOPER" },
                    { "138a432e-d6b9-4a99-8725-acaa32e4cbea", "4630f049-07b8-4c40-9f42-22e19f342cff", "Submitter", "SUBMITTER" },
                    { "145b9753-44fc-40f7-93b4-4caeaad2da64", "2bc0b24d-1464-4c06-9ee2-1602e9edd98e", "Demo Admin", "DEMO_ADMIN" },
                    { "f83bd72d-a490-4908-8eef-3f2d288fb5e9", "f90c8ed0-a137-4db8-bdc9-e4f848ff10ca", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "1dd2c869-cca2-44af-8372-ef4aaf14f1de", "af1d8d57-f7fd-48bc-ba58-bd226978ad68", "Demo Developer", "DEMO DEVELOPER" },
                    { "9f53cf1e-242c-4c9e-89f7-77c1b5cf3b23", "bd692fa9-2a75-4040-aa24-0fcdd98c9d22", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55b195c5-7c44-447a-99c4-d4f85825e7d4", 0, "b664f72e-d051-493b-a24d-23cc12fd6a22", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEDzfzBsvPNTsSLgBGr5CpoJ2lkT/kfhIqXmv96rWAlUO9JptTmjKvyw6l7276UrI8A==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "d1f7069e-eb52-4619-b032-e77b3292ffb5", 0, "f2c14a8c-a169-49a9-b281-493097f954a9", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEMj4jVKyl1CVJrc81wf/JnuEv7CWR2zgRbLa6ODD1lOJ+n/r94cdyjAJmTxdaEHMDA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "d1dd880b-5701-452a-a856-6cb9c2e75ee5", 0, "55baa257-99e7-4039-a099-21503003dbad", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEDGehkyVZF+ufbcsvfaRDkopD4+we6xit6D2U3Qris9asFvomdYzZtut1mPzpHKkbQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "9171cfd9-2c85-4844-90c3-0024911664ef", 0, "f5603a8d-2a80-4ddf-9dca-00c75dddd1f8", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEPTcwMI2IerMrPWy6hRhDCbPv3sX9xltGQO4FTHd3qBp7ty/njF6yb8e1rxQQWPaTw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProject_TeamId",
                table: "ApplicationUserProject",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserTicket_TicketsId",
                table: "ApplicationUserTicket",
                column: "TicketsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserProject");

            migrationBuilder.DropTable(
                name: "ApplicationUserTicket");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "138a432e-d6b9-4a99-8725-acaa32e4cbea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "145b9753-44fc-40f7-93b4-4caeaad2da64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dd2c869-cca2-44af-8372-ef4aaf14f1de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "618f7afc-1bac-4e70-8830-ce93b905f9e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f53cf1e-242c-4c9e-89f7-77c1b5cf3b23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd5e03ce-6577-41ae-89bf-5b95631414b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7ce1aea-655e-4c41-8d46-5b29141645a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f83bd72d-a490-4908-8eef-3f2d288fb5e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55b195c5-7c44-447a-99c4-d4f85825e7d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9171cfd9-2c85-4844-90c3-0024911664ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1dd880b-5701-452a-a856-6cb9c2e75ee5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1f7069e-eb52-4619-b032-e77b3292ffb5");

            migrationBuilder.AddColumn<string>(
                name: "CreatorId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "201f37ed-ef6c-46a1-baee-8b91b1015afe", "445659d0-df3a-4165-a53b-4b333821cbe2", "Admin", "ADMIN" },
                    { "33e54577-2cc8-440b-a662-6cf0988ee144", "dca57389-dcff-4821-b5fc-7e680209ff07", "Project Manager", "PROJECT MANAGER" },
                    { "617f7e8b-1113-4c6d-a5af-b581afcf1fe9", "ef34c1df-bee1-4e4e-a5ee-e1148f0d694e", "Developer", "DEVELOPER" },
                    { "2949bb27-bf03-4292-aa83-33cc2d51e6d7", "e50572da-5da0-4582-b968-76e272d80228", "Submitter", "SUBMITTER" },
                    { "f0eef021-5290-41a6-a3a5-3efbd0defc8e", "d8339263-0609-41b4-9695-a7a8b5db580e", "Demo Admin", "DEMO_ADMIN" },
                    { "33371c20-f3f3-425e-9bce-8ebc34164628", "b94ff578-ad27-42a4-b0cb-53f9dd0968d7", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "e1cd1e56-6e51-487c-9d19-192ad3930b41", "d2e6f5ee-b645-4191-8e50-f6fa8392d3a3", "Demo Developer", "DEMO DEVELOPER" },
                    { "9326d96f-710c-4271-a1bf-3ce42fc4d304", "1766bcaf-30d4-495a-aa42-13167dc02190", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e961af6-cf8b-474c-b01c-75c9e9282259", 0, "3954d639-b2a5-4efa-943e-61ea33524aaf", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEBTvADW+cudljArDLeE8EHRRhQeKgJmw2dTdF8rUvTisFIR8PIBtgTjqMMlCEvrkbQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "d99bb16f-40ba-406a-8c48-d72f1ba6e5a2", 0, "6975981b-5091-45bc-b53c-01be17d75a39", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEI6MNMQNHedD7NtsytGNwadgZDWbvIh+g414ikY4E9MvhngAZAXlb0hVEEEQyjpCjQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "7e1bcd79-75c2-4fb6-8a92-c523d5e45bc4", 0, "77dd760f-be75-4afd-bc14-13625a37e7d4", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAELqA++hkBU+cEvwT+MjXV+ioGU9cjeV2PhqZwMr3yPombtxJfdTpAELBoAcHDvGwIQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "a44f0655-bbc5-4f38-a5a4-fbb38f885936", 0, "11848102-b37f-41e0-bf97-8a5a94a9bd45", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEHiG6+3grQfEMUUG/rlJ/yIzh4xzaLNKFlUpJCDJ6z+RjDyukuAQDqWtxF+8ciF50Q==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CreatorId",
                table: "Tickets",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_CreatorId",
                table: "Tickets",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
