using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class usersSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a8ddc5ce-856f-4464-898a-407f6add02f9", "a25386b2-97f3-4930-a24a-be529366ff24", "Demo Submitter", "DEMO SUBMITTER" },
                    { "b5488c61-c6c0-46b5-9ec9-7e0ff3a350d7", "9ab07f0c-ebea-4cd5-b3bf-56100e4a10bc", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "506037ee-697f-4b55-b4ca-cb9bf226902a", "d052b974-6ed8-4ed8-8485-8d2f6383c83c", "Demo Admin", "DEMO_ADMIN" },
                    { "5fcac0df-b6a9-46d5-8c96-259e169f9d10", "afda2c5d-1b94-44e0-9518-d5a55dd86dea", "Submitter", "SUBMITTER" },
                    { "29988be7-9501-4429-8b05-5c6102c68742", "c89d2621-adcb-4e9e-a6dc-8edc540dd49e", "Developer", "DEVELOPER" },
                    { "f59a635a-ae1a-47b7-9ed8-0e9f303080db", "ff0194b0-e7ef-4f6b-876b-59c15d62e5c1", "Project Manager", "PROJECT MANAGER" },
                    { "8538a649-7957-44d1-b783-920b3ccbcc93", "5c0cf457-acc2-4a08-b46c-808ac3ecda86", "Admin", "ADMIN" },
                    { "1e798ffa-7fa8-4e1b-bc49-b0a76f3fa421", "fdefbcee-a4b4-4ff0-acf5-38d410acc01c", "Demo Developer", "DEMO DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f5066c7-c502-4048-8438-d725dc55d4db", 0, "9f403623-dfb9-46d1-a460-9d60efc6bc6b", "alice.cooper@hotmail.com", true, null, null, false, null, "ALICE.COOPER@HOTMAIL.COM", "ALICE COOPER", "AQAAAAEAACcQAAAAEC6xvmbj7IjhgHqd6MbuOI2oAw1vvIH2EKG80L7hr0o9G2mMoZrLhjyPV6ihx0QfPQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Alice cooper" },
                    { "d475f214-2fc4-4244-a3e0-06bf62b6fd65", 0, "94fdb525-4f51-4885-924a-911a3fc4ace9", "jane.doe@hotmail.com", true, null, null, false, null, "JANE.DOE@HOTMAIL.COM", "JANE DOE", "AQAAAAEAACcQAAAAEIBVNKtS1ZYrYhGqFLMmfT/JWun+CPLx9l2pFX09GjV71mK5SFUui/pO14VLsK6L1w==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jane doe" },
                    { "291508f3-6656-4ff2-b801-bcd405792b62", 0, "e578f08c-ef7b-4daa-bc53-f103194a782b", "john.doe@hotmail.com", true, null, null, false, null, "JOHN.DOE@HOTMAIL.COM", "JOHN DOE", "AQAAAAEAACcQAAAAEKNLKgp0D389p4NwqjrMZx+pBJVOvo8ZA0Xk69ybCE1K3ca9RXMzc0cCYGwfa+qcnA==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "John doe" },
                    { "5cfddd63-424e-46ad-b202-1fd94269cefe", 0, "24f18718-e99d-4ab9-a13e-d40b533032c1", "quentin.coui@hotmail.com", true, null, null, false, null, "QUENTIN.COUI@HOTMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJb/fdEtxa0skd6iu7PqmbcGY5o24HuKuJSvQOaWQEHH2bTND7bay4JSZ9cMLrDfAw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Admin" },
                    { "b86afb1d-e945-4a29-91ce-7a82e4b4d757", 0, "50e97083-ca95-4c20-8845-cb16d48d6591", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEIA0G/juKjAziPIGSUjJ8VPbC6d0D57oxghLBe1wTCPvXhcYREjQv6PipPAVblnQPw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "c4aec3eb-4ad5-44de-8d3c-d2338813caee", 0, "cb8372c8-4664-4bb2-9e9a-d9ce24264c7b", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEMq0LyNpG2vXH9YfolrdQWIyF1D+kzT2Qtqh9IZNecpVpS4PhMdIuleQmXidPp+tzQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "8ca59f42-0405-4e45-9ef9-c1f92e648ef6", 0, "f6a1d908-1d85-4eea-9aea-5b04630d49eb", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEDVj2pP8giK2drUHxIOw2RFpFP1vrZFuA/LqLXfbDXid8Bb2i4A954ZcF2kKe8axYA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "e91815a6-5c63-45e1-950c-3410daeeb13d", 0, "1faba3f3-28ad-4154-b040-5caefe81e91e", "jack.nicklefrost@hotmail.com", true, null, null, false, null, "JACK.NICKLEFROST@HOTMAIL.COM", "JACK NICKEFROST", "AQAAAAEAACcQAAAAENuXgZ9L6bHiLYGB231wc1Beh+OlvJ7eH9YRjUo/MJeRA4MWdL0+o0jCBNqzyRT7Xg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jack nicklefrost" },
                    { "805ea1cb-3a0a-4076-85f8-8bc8ac6070e3", 0, "9e7e2955-bc0e-4d1d-a18d-ea6430b9c6c8", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEDJ2GE+JvKHzLfHDwH8HcaZsXDlHcO1nCM6YCWsH/BOwDcbJztafaEXVZP/eR5HUhQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e798ffa-7fa8-4e1b-bc49-b0a76f3fa421");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29988be7-9501-4429-8b05-5c6102c68742");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "506037ee-697f-4b55-b4ca-cb9bf226902a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fcac0df-b6a9-46d5-8c96-259e169f9d10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538a649-7957-44d1-b783-920b3ccbcc93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8ddc5ce-856f-4464-898a-407f6add02f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5488c61-c6c0-46b5-9ec9-7e0ff3a350d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f59a635a-ae1a-47b7-9ed8-0e9f303080db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f5066c7-c502-4048-8438-d725dc55d4db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291508f3-6656-4ff2-b801-bcd405792b62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cfddd63-424e-46ad-b202-1fd94269cefe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "805ea1cb-3a0a-4076-85f8-8bc8ac6070e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ca59f42-0405-4e45-9ef9-c1f92e648ef6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b86afb1d-e945-4a29-91ce-7a82e4b4d757");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4aec3eb-4ad5-44de-8d3c-d2338813caee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d475f214-2fc4-4244-a3e0-06bf62b6fd65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e91815a6-5c63-45e1-950c-3410daeeb13d");

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
        }
    }
}
