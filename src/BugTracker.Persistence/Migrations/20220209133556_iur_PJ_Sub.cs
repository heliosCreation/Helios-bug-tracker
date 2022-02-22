using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class iur_PJ_Sub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "f5230756-98df-4545-a2e5-6df4797dac6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "59ee6f8f-01b3-4921-bdac-d78275c8acd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "fbb7e5af-2f10-47ef-b18b-bd4b0f2476b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "91267d5b-3ba3-4bf1-9a8d-06e0a45e1cd5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d43b4f3-cf4c-497c-bc84-2f3e6351881e", "28a4ccdd-69db-4249-8674-4caee4b8cbf9", "Demo Admin", "DEMO_ADMIN" },
                    { "461f41d5-9c6c-4d27-a11f-a9bd66c1da86", "5b9a569f-7038-42d4-a8b7-076b57d41550", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "943bef04-4033-4206-b0d7-3c75517d552a", "e8a146e0-ff27-41cf-a4df-b6dc320b7f9f", "Demo Developer", "DEMO DEVELOPER" },
                    { "ccf426f5-c344-40cb-ad59-ec468ef526b0", "9cee348a-0967-4bbb-bec0-f2c2a9194b7d", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6cdee224-4d18-482a-b084-e54fa1788095", "b964514f-fc0c-47f2-b16b-dfd7cbf8c167" },
                    { "6cdee224-4d18-482a-b084-e54fa1788095", "df656ced-7b29-4504-baeb-60d628c56739" },
                    { "6e8006e3-e50a-49be-94ea-03ab653713cc", "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63" },
                    { "6e8006e3-e50a-49be-94ea-03ab653713cc", "68f84753-8203-45a0-ac1e-b2a06411d49a" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccbcd404-6dcf-4960-b483-2071368066eb", "AQAAAAEAACcQAAAAEL1t1FUrZZ/u7Jt0kzDXoFg5xY6K2zK0/lUxzeTmGeC5h42I0fLBlDtMzECX4e08GA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bf257ef-e05a-491d-ba4c-94d109d39f42", "AQAAAAEAACcQAAAAEDJW1ynfoG4k9LennONKBiUSKFW5d/0PsSWPNRdpubuIOmHjW3XIz0gi30yrXksFtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fc81fbb-3464-4560-8bf6-9d761405618c", "AQAAAAEAACcQAAAAEHccTeGpG5b2NDYi7mxz1RZMDY78TJmh7qUahw1mTWtoRnLF1+aEQ9VSJnWljdPr+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "282b898c-a051-4b75-8db0-4c0e160d47de", "AQAAAAEAACcQAAAAEKFce9cU/iU+rp/5C3U8BZ9isGR9Ul2NE53jjAFN/RDS6u2vYFrR2NCKUmE6vzdEjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5b765aa-2163-4446-8048-7f41907ab22f", "AQAAAAEAACcQAAAAEIh44B+tOtBgnY8lopMt1rZ+/map99NPI+GORmY0emK6rJGo55N3Ans0/JG0ggRYxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2398e0b0-ed2d-46cc-aef4-2234df1e6dd6", "AQAAAAEAACcQAAAAEIQeTGMbaqEbaUnAsQ8pslEOGpdbhFI514Ofa41+Ik9cfM7tWprkndjsEf/be0hvlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4517a2c8-f8d3-4a72-9df2-cbd0365d83cd", "AQAAAAEAACcQAAAAEAoFgOdZkH30FQrfrbT2t9DKv/ulACbjvUjal31iqAjiPi0shRifCaLUHWFJao24tw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4521ea1a-28b0-40c5-9416-b1c692b07061", 0, "12ff272f-81c0-48bc-ac20-3153e9342ced", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEKyW0uQORHprLlwAYsjGAcVxH89zLBeph03gp+mMGZf8uJjar/7lcrAsw68J0lZvOg==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "c7deddea-55c8-4dd1-ab7f-a69841effbb5", 0, "3ca4dc2c-f21b-4c04-b461-28840c77fba6", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEOawT/p04zZVAsXaSnEhByM2HqH7pOs1R1TPhBrbBQyq69Xk0PpA9uEQreGcdc1Vug==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "0d882544-b17a-44ca-893d-a1dec8d263bd", 0, "aa107294-b518-4a11-ae1c-51e652d69e0d", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEMslX4e9ZszLnAqqo9hKG7LtB/BSZcc/Ft+31aWgFI1zwrvh6XYLbVz/ZfN8eH2XUQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "33113608-2ce2-4da2-a77d-31294998d9fa", 0, "321966b4-cc40-46fa-a1b8-b6ef054166bc", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEKDZWevQWIvqW96CkSt3OFJTzdnNj+BwFfv3Sv2KPNbQDmzH7qqtzCEVh2qQsWEYRQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d43b4f3-cf4c-497c-bc84-2f3e6351881e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "461f41d5-9c6c-4d27-a11f-a9bd66c1da86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "943bef04-4033-4206-b0d7-3c75517d552a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccf426f5-c344-40cb-ad59-ec468ef526b0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e8006e3-e50a-49be-94ea-03ab653713cc", "68f84753-8203-45a0-ac1e-b2a06411d49a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e8006e3-e50a-49be-94ea-03ab653713cc", "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cdee224-4d18-482a-b084-e54fa1788095", "b964514f-fc0c-47f2-b16b-dfd7cbf8c167" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cdee224-4d18-482a-b084-e54fa1788095", "df656ced-7b29-4504-baeb-60d628c56739" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d882544-b17a-44ca-893d-a1dec8d263bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33113608-2ce2-4da2-a77d-31294998d9fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4521ea1a-28b0-40c5-9416-b1c692b07061");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7deddea-55c8-4dd1-ab7f-a69841effbb5");

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
    }
}
