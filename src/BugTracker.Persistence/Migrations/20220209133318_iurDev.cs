using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class iurDev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "ee57a97b-c6ba-4b55-95a7-094ffcb9a93b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "2fa4b8f1-7a70-48ad-87eb-3a767b597ed2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "a8e6100c-f82f-40bb-a0bb-21867c67920b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "aaf393dd-615b-4954-a4f5-b8cb3a027c64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a6edd3e5-e992-4b89-a900-0cd5a22ba491", "13b849a0-ce6c-4e1e-aecb-4bbeeb9b069a", "Demo Admin", "DEMO_ADMIN" },
                    { "f6740a26-b16b-4ffb-ad56-b82a6e291297", "5fb1bf9e-c49a-44f8-8bfe-19bc06abccde", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "a08c0ab9-ff6f-4d27-ba83-2a9266bf4c51", "52a29eb1-39b3-464d-b59a-20c1494b15a8", "Demo Developer", "DEMO DEVELOPER" },
                    { "4c4d543d-22ab-41ed-bbef-8eb8cb9de65e", "2e85157a-cfb1-4d9c-9f51-a2de65977bbf", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "04614fbc-b0b7-4344-a2e9-8046742ac7cb", "c31a5e3d-a2ef-4065-a12c-2f9647f24070" },
                    { "04614fbc-b0b7-4344-a2e9-8046742ac7cb", "355daad8-1cb5-4caa-8538-e82508b5248a" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1c6527b-9f1b-4da7-9ef8-9216e82a88f3", "AQAAAAEAACcQAAAAEPseidbuEk4a6BodRZ6vf6k0DcyywrIB0CppHbySlO6gnyVPXu+4QgKeGravikl4Xg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "247c9845-8844-49a3-88b0-24280a4fd3c9", "AQAAAAEAACcQAAAAEGYqlrpdBpFhc3UwRKPtIfxPY5XrAsKZlmZLPLXJeqaH3vecvBGaU3kyvPo6AsY4NA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86e8eb78-1729-4bf9-98c6-fbc48833d9e0", "AQAAAAEAACcQAAAAENsLf+hWfUUfu/C9VjXeX6iRIPdSi6ErP+KUbRusiaZ1HMitBjPC/LkkwYmRSFPpxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f41f3b2e-e148-4b83-8519-4d1535ddd71f", "AQAAAAEAACcQAAAAEICmQAvf8MomzF1mo3dhPDzDxueMzTI2GdV9WilZ5RaHHFv7hwlNuM2UJiY9PcGStg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "147d79d0-01ab-4c60-8b08-d90983f7f12e", "AQAAAAEAACcQAAAAEKD6OVyqsxLMKe+YWehMryIWEl2+HZcQGD2kCXoLV45QZ76rCMlWAHsLEAog/l2JUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38fa821e-2a59-45cf-a3de-b002e8d70746", "AQAAAAEAACcQAAAAEKCsiZ515JUiL1w0Wv8XT6n3SZdb9tbQjhdNxnBTaBQV0y+/8vkAhCwfABpUX5LERQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cebedc46-e4b7-4ab1-8ffe-672240f867bd", "AQAAAAEAACcQAAAAEH9Bcb/Sv7WmW5Y2GIZkdZK1iYhocwUIk/1W4JIhMJZPL73dGbzNBkU4iYH6FWZ6vg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "889646db-49bc-40fc-9987-18cbdc75a9fb", 0, "a07030a5-70d2-4068-8c75-a57f138be5a0", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEBzQczYC9jA2jPi2L+koNaXM2a0oAFpPh9V/ntUhsfaUc9jC+LgrVD46P9wYnSxkKA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "d602c724-7a07-421e-b98a-7eab1c98ef64", 0, "5c210fcf-24e5-4946-8a11-d7f080c8c218", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEIA8OX7vhUvE1vJk6MGMqFpXvyQpPvuPmlpVR8eVFO6MfenoIN+zTF/aU1EAougftA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "7110ce9e-0190-46b7-b309-6e340f7c5fb0", 0, "22848d27-d613-4c71-bc01-9829a6569dcc", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEPdSDRxOu8zH9VHp5muHWxgtp+yb6jRE9KnOhBp27a3Bde1bicIt+uT+XGi8zvrPyQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "36e8f199-1318-4bae-a0bb-2efdf34650b9", 0, "cfbde94e-dcdb-4f14-9d51-3155ed9f9818", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEPliJEK5ztJKtuW211WHvJ0TuMgEkh78KDNKLUmvYt5qIal6m1HIg1hwJUU5IzgoMA==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c4d543d-22ab-41ed-bbef-8eb8cb9de65e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a08c0ab9-ff6f-4d27-ba83-2a9266bf4c51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6edd3e5-e992-4b89-a900-0cd5a22ba491");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6740a26-b16b-4ffb-ad56-b82a6e291297");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04614fbc-b0b7-4344-a2e9-8046742ac7cb", "355daad8-1cb5-4caa-8538-e82508b5248a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04614fbc-b0b7-4344-a2e9-8046742ac7cb", "c31a5e3d-a2ef-4065-a12c-2f9647f24070" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36e8f199-1318-4bae-a0bb-2efdf34650b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7110ce9e-0190-46b7-b309-6e340f7c5fb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "889646db-49bc-40fc-9987-18cbdc75a9fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d602c724-7a07-421e-b98a-7eab1c98ef64");

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
    }
}
