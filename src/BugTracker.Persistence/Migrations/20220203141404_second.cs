using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03754fb1-7846-4684-ba10-98b9418edae2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c3ec63e-4242-402c-9dc9-5162821fb237");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59bd942b-dcb9-461a-980e-dd1f624a1751");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "720e346c-7380-464b-944e-10f356d95ec0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab1bfeb9-64bb-4ff3-8e3b-621758b20cc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af4f089b-2c23-4571-a765-e018a57afa01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d411965c-46bc-4efe-b29a-c4065d78ba70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddb713a5-5a30-46df-88ed-f187de399c75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06827254-2de7-4ed9-87ae-c18ce7152ac2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163b3057-cd1a-4bab-9c0e-78398f24c691");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94faf448-7dfa-4b14-a73c-9dd5604b7fb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef02b74c-f466-4553-839a-5553befc872d");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "af4f089b-2c23-4571-a765-e018a57afa01", "8e648ee6-d6a9-409d-88e8-58b1f8b7de74", "Admin", "ADMIN" },
                    { "03754fb1-7846-4684-ba10-98b9418edae2", "99695aee-9028-41b1-80a2-2bdd95872ced", "Project Manager", "PROJECT MANAGER" },
                    { "59bd942b-dcb9-461a-980e-dd1f624a1751", "d78ca393-7f59-489e-bbbc-cf2487f2577c", "Developer", "DEVELOPER" },
                    { "ddb713a5-5a30-46df-88ed-f187de399c75", "a49b5d7e-4fce-4e10-9163-64f3a25fca5b", "Submitter", "SUBMITTER" },
                    { "2c3ec63e-4242-402c-9dc9-5162821fb237", "da7fe6f3-e627-46de-aa94-a5bcd2ed2cf7", "Demo Admin", "DEMO_ADMIN" },
                    { "ab1bfeb9-64bb-4ff3-8e3b-621758b20cc1", "6a90652f-5eeb-44ca-8c88-489f6cda399a", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "720e346c-7380-464b-944e-10f356d95ec0", "d2b9e3dd-33f5-42e1-96db-874ba73d2c0c", "Demo Developer", "DEMO DEVELOPER" },
                    { "d411965c-46bc-4efe-b29a-c4065d78ba70", "67c98b78-3370-4c01-8939-feacf9bed894", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectId", "SecurityStamp", "TicketId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ef02b74c-f466-4553-839a-5553befc872d", 0, "12da5508-6404-4275-b3bd-941694a3beb9", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEAeAY7Wt/GPCVVv7kab3iEkDMkp2hMx55IKOIzbKw1b5sbZqMWw6zVj8qIpw+Zuypg==", "XXXXXXXXXXXXX", true, null, "00000000-0000-0000-0000-000000000000", null, false, "Demo Admin" },
                    { "06827254-2de7-4ed9-87ae-c18ce7152ac2", 0, "26b79bd2-26f4-40b3-bdee-d92ae63fc616", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEBwJxBdAPUpvodAHgrpgbpG/TAZI6JuMCgEGtk/Zer/70TMG1TGCOSrq3mb0w1PgPw==", null, true, null, "00000000-0000-0000-0000-000000000000", null, false, "Demo developer" },
                    { "94faf448-7dfa-4b14-a73c-9dd5604b7fb0", 0, "701ad2c0-e992-4f0e-9252-204f8acfcaa4", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAENhnCpEcy0OBpJ0iAUGGHK1Ff3ttcwJ/1dDtH3GiMSfeOHSdvU8KV6+dayriXAZ8JQ==", null, true, null, "00000000-0000-0000-0000-000000000000", null, false, "Demo submitter" },
                    { "163b3057-cd1a-4bab-9c0e-78398f24c691", 0, "fc54171c-796e-4c78-9303-875292c73555", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEEH6DObwQE7lDuOZbk8W/yz5qW3TtrdhC+8aH276tBCNkLpwVFawAAcMqFGteSUitg==", null, true, null, "00000000-0000-0000-0000-000000000000", null, false, "Demo Project Manager" }
                });
        }
    }
}
