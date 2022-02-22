using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class iur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0edcc443-328a-457e-ab6a-63e7d16651c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69d47cc8-79a3-4601-8183-2fd8a4326f72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "775b167f-8c45-4e57-8b77-42a307d8d40a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e70ac21e-7c3e-491a-aa84-9e8e9cc726aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09945c60-db72-43b0-b5e9-83e5c58a0930");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1aaf3589-9535-4af6-b0c0-58fa0d043b70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75097cf6-771d-4303-b75a-0c8f94938a92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd44e26a-adb7-418f-b3d5-0cc50016537f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "b62bc358-7704-4155-b599-be128a4fd74c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "e991318e-cedf-4aea-af4f-1ce95735c05a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "21fe0334-2880-4d87-9adf-86a9f04c7112");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "16891915-22a5-4d6c-9a34-d4f98ee914d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75946676-683b-4b8a-be4b-680f04cbbf2b", "23293f8c-768d-4ad1-82e4-8e3b3d6762e7", "Demo Admin", "DEMO_ADMIN" },
                    { "9a313d8c-eff2-4672-8f11-7fafd308a9b3", "7ca53a5b-e7bb-4287-bbf7-fc9e9a76c4f5", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "d150a0d5-13cb-4b4e-8c75-0df5d161ad10", "7bfb1a98-4d7c-42e5-b067-c6fdd95e9791", "Demo Developer", "DEMO DEVELOPER" },
                    { "88800da5-17d5-44d9-972a-e7130abb9c77", "1e461d3d-5f8e-4d19-973e-09ea8428511b", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65", "21bbccc8-fc2a-4881-b746-ed9d90fbff9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "408be9cb-0392-4f38-a156-caae7c74fa09", "AQAAAAEAACcQAAAAEI2ejs0jbS1fizyT6LaTtoT42K50vdYm7wZz1U4cifrfNsafjuSoc10SP8HApj2HeA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fb55b2c-17a9-4447-8b9b-2f8d0bf04fd5", "AQAAAAEAACcQAAAAECgCMSCj10+AuAbIuBchV1LZ9V1ZK7Z5Ob2R6iZOrDXR+EVQGu3pWWhhfUsJuISS2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76e725f2-f96f-4955-94cd-ac73eb77566e", "AQAAAAEAACcQAAAAENShB9lt2kQ6xp95iYJK3UMMJHJhpguuvhRq7aPzGILkYsJIXORmQwfYHntWjrHSYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66a32132-5da2-4179-99d0-f873277084e1", "AQAAAAEAACcQAAAAEBlvicRZtNfbNXIbyQ2OGMLOof9N4y2Y3wIhNot9rMYmlADSBC70/qRik8PGnmS44Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a639d254-e455-40d8-bfc9-ed8004555d71", "AQAAAAEAACcQAAAAEIyn83Ee2gGoMg3ilyAIRgMatWUopzp2E6qYftHMJM1fxwpM3ZlCmpNk3E99BU0qIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4036007-fc00-4abc-9573-d4687760684f", "AQAAAAEAACcQAAAAEKkRq7ZTTw8R3bNctHzfZ/9bBAvufC9df50eFV7Gkjs2Yxl1KfeaZF36Pfq3wPwBvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65759116-95d0-4ac5-a87b-e3088924ee59", "AQAAAAEAACcQAAAAEDZPXh2t+mUp+oBamVmsRpdjbATu70xttKkHACLuHrcjZgQNru66UGt5c5DMiU0YVg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a7604b52-6d35-4ec9-bbbb-2ed882ea26fe", 0, "544211e1-e416-48d2-85da-3adc4fb84fa1", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEJKO8/hu7wBFMvlxFN9nRSCeGIjvvfLAX0yZhUNuM5qp9U/dVIwm9RjWJE3q7gSskQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "d8aa6410-0513-4b19-8a0e-1947605bc1f5", 0, "06ba59ef-eb40-49be-b3ff-4b828d4a9669", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEH6dRERBNYAjXPkvN2wWSNbyKju+ZBrbMHMUg4I3wj74zK4U5leb6Bd7SZaVo3NZ8g==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "dcc77498-60cd-4716-97f0-75b03de2f020", 0, "24599ad1-48b5-4058-8138-9d9400b1e1f7", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEDatM0Hmq0BwY/BFZf1AqcG7k/xgEdg2e28lEBc7CZBE3lc0AkblQ9G9zXgzGhADBg==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "eadba81b-531d-4be8-b3a3-a2210fa92e97", 0, "165e5ac3-88b7-4a7c-8ff5-66a8b0a14eab", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEJ4MA2YgT/c4AQtqtnCFQIzJhI4bJlKcVKWNj+nG3wCExwO1U0WdEVZo5++yohIg2w==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75946676-683b-4b8a-be4b-680f04cbbf2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88800da5-17d5-44d9-972a-e7130abb9c77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a313d8c-eff2-4672-8f11-7fafd308a9b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d150a0d5-13cb-4b4e-8c75-0df5d161ad10");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65", "21bbccc8-fc2a-4881-b746-ed9d90fbff9b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7604b52-6d35-4ec9-bbbb-2ed882ea26fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8aa6410-0513-4b19-8a0e-1947605bc1f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcc77498-60cd-4716-97f0-75b03de2f020");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eadba81b-531d-4be8-b3a3-a2210fa92e97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "70bb5116-85d0-480e-8c79-950126cd0138");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "2bb41198-53e4-4a8b-b24b-e6435be5cc7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "f25e405f-ce30-405d-a8e4-83f01445b29a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "f1ec8df9-4d4c-4c53-8ca2-fd2c30b5083e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0edcc443-328a-457e-ab6a-63e7d16651c1", "8aeb5dbc-48ea-4032-9685-013ee55ae0e1", "Demo Admin", "DEMO_ADMIN" },
                    { "e70ac21e-7c3e-491a-aa84-9e8e9cc726aa", "6dd6846f-f589-4a7b-ba39-99e47d570419", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "775b167f-8c45-4e57-8b77-42a307d8d40a", "5120f684-8223-4f67-bb08-fd9a81f8b3f8", "Demo Developer", "DEMO DEVELOPER" },
                    { "69d47cc8-79a3-4601-8183-2fd8a4326f72", "bd39a6f6-89b8-44c2-b403-5cf619b537d0", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8213b02c-8cce-4f8e-86f5-39ecc66c0ce6", "AQAAAAEAACcQAAAAEPnhTljdIyAShE2bj9Ey+aCHYI4DcTWN7o8mG4nRzVYyC9Lo0f9S8KRuCI7pFnrV2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8d21ea8-9bd0-4986-bb88-4d864331d52f", "AQAAAAEAACcQAAAAEGG09sQ32SpJyzdWhUu//rR47tX3raT3UfXPn7hYNM5R34Tj/1tNLa+arxxDiOrmKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19887ac5-baa7-49b1-ae05-b6f66aafefcd", "AQAAAAEAACcQAAAAEAhROO+RBoBEd6pU0W/jmEZfpchMXhPzqa/HdkuaJTMQSchBXrm1CmPWXunqH0RoIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0365a46-72cb-4e3b-95f7-169df26941a7", "AQAAAAEAACcQAAAAEKLju+XNIdZEFcyeAQ+XjtQ6VekZ3NfFwf+IIP4WKNepuObnAoJ9EbP+6S4u1kLwHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf76bcac-796d-4228-adcd-447d74e7b042", "AQAAAAEAACcQAAAAECMe/Z1DLgFin6o06bKZTPBr8kI1WvLTq5l8c182yEF0T71cotnHtve4B80OxLhO7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8471381-93f4-4f2a-9ee7-043678fc8b6c", "AQAAAAEAACcQAAAAEPn/Kd+fSvjE17SJMVytyNew0ec7rDVTMPusQYa00Mj0ql5nRByUfpup0x0UImD5dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "354f5bff-41e0-4db0-8f62-16092de58423", "AQAAAAEAACcQAAAAEJfiKY0Pmbejf9CqH9vefu46BSGEaztE9Eb4XYHhNjQsfn56HSdCee7By1nyTAqytg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09945c60-db72-43b0-b5e9-83e5c58a0930", 0, "a5338781-fa2e-4e1b-bfd1-e2d75387970e", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEM75vKbqn1CU2U8r3/tJ64KlsWMI3vDiTdmtSVMruxf8pilQgRyL2CWM/Qx+JajWsw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "fd44e26a-adb7-418f-b3d5-0cc50016537f", 0, "cfd0af7b-b251-42e8-9cea-f10b0dd171d2", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEHA7VuEg0HEtvP+6O4FGX6LIWCPdoiIjBUzLfvCc0zcmt/HCGk/hsvTja+aUUft5Ug==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "1aaf3589-9535-4af6-b0c0-58fa0d043b70", 0, "fbdf1a3b-f2a9-4912-8094-8395b173da9c", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAENIrh5G84HrXxmzTZvc4LV+trzi2Y4JyEdOiH4bqMI3kMb5gKFXVE8V+p0Tpalk0Gw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "75097cf6-771d-4303-b75a-0c8f94938a92", 0, "08199328-9e01-40e1-ac9c-cd7e0fb1c2a1", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEDsYtElxLoAQvwPqozqWC1nNSqezsgno7gGg1BGIh66CY6WssjlKS68J/AB6BN7itQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });
        }
    }
}
