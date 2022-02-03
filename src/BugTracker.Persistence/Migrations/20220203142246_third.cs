using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Projects_ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tickets_TicketId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TicketId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ad4c485-5c7d-45ba-bbab-a172677edb48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4019ab9e-89f6-44f2-bb1b-53f99f20f42f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50f025f3-433f-4a95-acfb-d951447d9a47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "581a8f0b-53b6-46d7-8c8a-816967c5b97a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b52e6336-6136-41e4-b2e1-d0da2eadb779");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0390a62-3b3a-4af4-b539-4317d69613b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efcd5cbf-cb78-4088-afcf-d5d48fa0499f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcd7c17b-42f7-4b20-9a0d-7cc5998efd42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2320256c-f0f5-4ab3-864a-5d3d961506da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d297967-b44f-4e39-8113-52ce34ab9bb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf873038-b914-4699-a190-a5389d156fa2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c84fdfbe-a36e-4cae-8fe3-950eb078f01a");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "AspNetUsers");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TicketId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e0390a62-3b3a-4af4-b539-4317d69613b7", "51e9b45e-551e-4951-94e8-176a3df57933", "Admin", "ADMIN" },
                    { "fcd7c17b-42f7-4b20-9a0d-7cc5998efd42", "e3e7735b-dd57-42f3-9da4-110119bc7acf", "Project Manager", "PROJECT MANAGER" },
                    { "1ad4c485-5c7d-45ba-bbab-a172677edb48", "26d1ab18-ac04-4720-a7f6-66666fc26cd5", "Developer", "DEVELOPER" },
                    { "50f025f3-433f-4a95-acfb-d951447d9a47", "e544ea32-661c-4eee-bebc-12814bf02250", "Submitter", "SUBMITTER" },
                    { "4019ab9e-89f6-44f2-bb1b-53f99f20f42f", "7433c933-9aa0-4bde-bc82-e820305b3005", "Demo Admin", "DEMO_ADMIN" },
                    { "b52e6336-6136-41e4-b2e1-d0da2eadb779", "545b813f-e373-49f0-8ee3-32aaa5db1f2c", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "581a8f0b-53b6-46d7-8c8a-816967c5b97a", "0751d6f3-3236-4375-b320-d1a2bd258b97", "Demo Developer", "DEMO DEVELOPER" },
                    { "efcd5cbf-cb78-4088-afcf-d5d48fa0499f", "db8ccf57-30b2-4352-8d8d-196493f6f2a2", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectId", "SecurityStamp", "TicketId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8d297967-b44f-4e39-8113-52ce34ab9bb1", 0, "644e198d-7319-4e04-b058-75418fc93a17", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEBUsuqbSZPfuU+7Hllj63E9QeXPMbqG9OY/4OXxI43xMK5l9A+kVYU4oiz2CChT92w==", "XXXXXXXXXXXXX", true, null, "00000000-0000-0000-0000-000000000000", null, false, "Demo Admin" },
                    { "bf873038-b914-4699-a190-a5389d156fa2", 0, "155ace39-1981-4594-837d-0e77c59fe563", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEAnbhaGW710wJunuWFbR426HkXwWsQdLeb8LcRaQU+FQwJTd+NkmILeTOAYOt9mP+A==", null, true, null, "00000000-0000-0000-0000-000000000000", null, false, "Demo developer" },
                    { "2320256c-f0f5-4ab3-864a-5d3d961506da", 0, "4fb916d8-9970-465e-87df-3b80b6349e06", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAELqxEbWJHQ4EbFKQyCHBoM2cwNjWmRzBKIqLdrvIKElYZNh7EHmCEJIMpRHrwOQXfQ==", null, true, null, "00000000-0000-0000-0000-000000000000", null, false, "Demo submitter" },
                    { "c84fdfbe-a36e-4cae-8fe3-950eb078f01a", 0, "0f6fe933-9dde-42c5-831a-ee8e7fc69cc7", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEEgk0U2s4RKmhbg3VGGzO2z3oTSeUwYz8eCTEEINUTi5ZXhPw3kZu1EYkie43yAqVg==", null, true, null, "00000000-0000-0000-0000-000000000000", null, false, "Demo Project Manager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProjectId",
                table: "AspNetUsers",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TicketId",
                table: "AspNetUsers",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Projects_ProjectId",
                table: "AspNetUsers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tickets_TicketId",
                table: "AspNetUsers",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
