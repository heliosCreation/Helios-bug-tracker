using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class AuditEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ba0d9e1-48de-4582-be09-c1f3ce525e1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e5e8cb5-cae5-4c17-ae0a-e187fad15e63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73478721-2e5f-43af-a968-21cee5e260b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bd1e1c6-cf7d-4e37-9c77-31335d2e6240");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02c8c712-e7a8-4d64-957e-65b8210c22b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14ef30c4-70d0-44cd-82b6-4f9995f1336b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29dca70a-75e6-4788-a789-ed7708f1aece");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79f6b77b-eb72-4ac3-99b9-fdba237466d6");

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("3e0d86a0-a726-4f9f-9e5c-7ff4298819a5"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("a5981e9b-7239-454b-b497-0decc8661162"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("b1f140fa-3915-49d5-adfa-904a8ea51581"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("d4e7cb56-9986-49a1-84ee-ff7907b6b0e5"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("47d65e34-820a-465e-99d5-f065016e577f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("70738404-9e63-4629-86e0-cd106e4452a9"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("7854cc26-6713-4413-a5b6-cce3e56c84ed"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("7afcd8a1-1804-4b3a-87be-6c62b98c0934"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("0295ac2f-81c8-4bcd-87b4-d225e316d3cc"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("25d13134-0282-4bf8-83f0-95f53d8a6942"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("5567acf7-a108-4f64-8a6b-7ce1429e70c8"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("e6e67cff-a7b9-4456-9ff1-e7b385f069dd"));

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "166c15f0-5061-4968-afb0-b136cea1deca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "4e23437e-e6f4-4da7-aef0-5921260bc805");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "8f91eacf-135e-4f09-89b2-9e67c61bc3e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "dd27a5b2-12b1-4085-8cba-503ec601ecbc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a249925c-2fed-476f-8f35-a01e979cd46a", "a4e0f5c1-dcdb-442b-b5fd-dc470e940e7d", "Demo Submitter", "DEMO SUBMITTER" },
                    { "8fd0c236-cda9-452b-ac6b-3466e49ab282", "e277695e-5267-40c8-be0b-218d5ac338d5", "Demo Developer", "DEMO DEVELOPER" },
                    { "9184d944-77f5-4018-9e97-a05abde84550", "c494bc5b-1079-4c59-b754-f78b579b4338", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "20aef802-2ab5-4f8e-820a-d3cdba0ca848", "37c65f60-c00a-44fd-acf5-560a486341e5", "Demo Admin", "DEMO_ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed157be2-f0ff-4dee-aa2c-736ed0237c28", "AQAAAAEAACcQAAAAEFYfsczPwC4lFEHFrz95st5mW3Qbi/TJ20rzAB65OPdlZ7goa1ZIn+BlwV2BmN/d6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3094e8dc-e47b-43ad-862b-2478716369e9", "AQAAAAEAACcQAAAAEDjvLuyW0aFEeJ1SVfj2B7wGDip1rUQXE3WFlMxb9KE5HJ8XGV1Jxcc0MMsO3If5Bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1a45c8d-de41-43db-a392-36529ab44ae9", "AQAAAAEAACcQAAAAEDYtZs41Pjdz2bzHKOWwmlMCS6hT9zwlih9ksA0DiHaqguqtKppF8l8DQYjWCaQ0IQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc9e4a7a-721d-4c75-a787-84580fd289c1", "AQAAAAEAACcQAAAAEAwj9ngSpSmp5yrC4t/lZKX3AVxNYZX3IUZ1wiAGvH65AZw6wTx3xg2gd93NNh6y2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e976e5a1-53a3-4a6e-8fc1-e706a494780c", "AQAAAAEAACcQAAAAEKYjr7vfGlYwWygELwlg7l+1SlWcMeqYiELx9p/dXvu6BWPu2z1Ol7s4stDChEZtnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4134ad4e-767b-4a0c-ab01-f3a032fcb715", "AQAAAAEAACcQAAAAEI2z6b7RVYLub8SWzKPgaWmCW9SYjMed57caoQgVpfwSf4U7RZYTnN1oiEFy+hIpyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5d9ef11-6715-4dbc-ae16-c37267da62eb", "AQAAAAEAACcQAAAAEEefHMrsmjTwM85Osgg19fISyx+oyZCNjmrGsOb9Vger/sd9/i1PwOQa0U4j7nW+AQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29104434-20ee-417b-914c-b50c68d80a03", 0, "95559708-dc28-41c7-bcd6-55dabcc77590", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAENQ1UsJlkGfff3lQ2NvQ2pMCzWVx4K7fwdu949F64hJp9iHkg8x0vIhdAhz3k4Mfog==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "d36cf2b0-94e7-4e4b-a6ae-eb63606b7749", 0, "d2d863b9-8044-42b8-a56e-be75e47c2878", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEGZFM/IzRfsJV7XrT0t14c9AOwZD4fhvvKD3jhL2IqTJYLx46d/hoeNhweGPABU9zQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "43c7f684-257c-4553-985c-ee4553af1639", 0, "595a23db-1156-4216-a458-705dfef73682", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEDKaBJbAVvohVghW1qqtq+MjL2Pi5oCqEPfT2RctC17qmFZiOixToWGEE/Uo6Usi6Q==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "c8dd58b9-1110-49fc-b408-6ad496cf7c99", 0, "9b90d716-55d1-45b5-bd8c-523c7b968b11", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEHp3gRo55V5p2SQiinnuTB3ghMUf0TulJ91fWXW4zStBZ9hdp5GhFCiTFiqHzqyloQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("61554d5a-15ca-484b-b7d6-58b48a3a3b29"), "Immediate", 4 },
                    { new Guid("bfc2d431-03d5-4c0a-b97c-1c855a0ead73"), "High", 3 },
                    { new Guid("3e6e45a3-72d3-44b2-aa19-eaf5ea50d282"), "Medium", 2 },
                    { new Guid("a5937a39-18e6-4d9d-8526-c6ce6b1c8b78"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("b705740b-bb65-4f30-b875-d7cf7b9be0f4"), "Resolved", 4 },
                    { new Guid("92f47632-7a5a-42e4-b659-6499d910d78b"), "In progress", 3 },
                    { new Guid("efcaf7ab-46d3-4638-919e-caf0093a8fcf"), "Open", 2 },
                    { new Guid("d922f5cd-2b9e-4238-b594-2ab9b3394ea8"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("e267348e-95d7-4126-b9c2-4a31acdd7efc"), "Documentation", 4 },
                    { new Guid("0f3fd453-7e78-4c52-a6b0-e669bdd26a0e"), "Training", 3 },
                    { new Guid("d8e71a53-5b5c-4678-9b63-391713b1d998"), "Feature request", 2 },
                    { new Guid("3b12cfa9-014c-4691-aec4-747e2a3ea3a1"), "Bug - Error", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20aef802-2ab5-4f8e-820a-d3cdba0ca848");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fd0c236-cda9-452b-ac6b-3466e49ab282");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9184d944-77f5-4018-9e97-a05abde84550");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a249925c-2fed-476f-8f35-a01e979cd46a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29104434-20ee-417b-914c-b50c68d80a03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43c7f684-257c-4553-985c-ee4553af1639");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8dd58b9-1110-49fc-b408-6ad496cf7c99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d36cf2b0-94e7-4e4b-a6ae-eb63606b7749");

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("3e6e45a3-72d3-44b2-aa19-eaf5ea50d282"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("61554d5a-15ca-484b-b7d6-58b48a3a3b29"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("a5937a39-18e6-4d9d-8526-c6ce6b1c8b78"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("bfc2d431-03d5-4c0a-b97c-1c855a0ead73"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("92f47632-7a5a-42e4-b659-6499d910d78b"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b705740b-bb65-4f30-b875-d7cf7b9be0f4"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("d922f5cd-2b9e-4238-b594-2ab9b3394ea8"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("efcaf7ab-46d3-4638-919e-caf0093a8fcf"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("0f3fd453-7e78-4c52-a6b0-e669bdd26a0e"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("3b12cfa9-014c-4691-aec4-747e2a3ea3a1"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("d8e71a53-5b5c-4678-9b63-391713b1d998"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("e267348e-95d7-4126-b9c2-4a31acdd7efc"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "c41042b5-3aa8-4798-8622-4d98f91c4f73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "033bd718-1cdf-40e0-88d3-28b89a4d6729");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "b2c27a86-a5f2-4ae3-8cb7-937734ca5b20");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "46bbd5f6-7cf0-43d0-8215-65784b0ef168");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9bd1e1c6-cf7d-4e37-9c77-31335d2e6240", "018fa83f-2521-452c-aa4c-0d36f73db11f", "Demo Submitter", "DEMO SUBMITTER" },
                    { "6ba0d9e1-48de-4582-be09-c1f3ce525e1d", "154edf37-6f13-4d6a-8142-8718f16ff6f7", "Demo Developer", "DEMO DEVELOPER" },
                    { "73478721-2e5f-43af-a968-21cee5e260b9", "10e11b92-4e6d-480c-9ebd-3c5b1aca92c3", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "6e5e8cb5-cae5-4c17-ae0a-e187fad15e63", "5665559d-198f-427d-94a5-2e245e629930", "Demo Admin", "DEMO_ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82aa4949-25aa-4237-9fd0-a1f220a7c86d", "AQAAAAEAACcQAAAAEBCoiC3mq4oU0g05jlggbKpwwiVMR5KwnzGDo7YswWFqPszLMhKpafPnZEpAmQ6qwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db3e77be-de11-4b13-8f38-3cc0e10cd42a", "AQAAAAEAACcQAAAAEOqo8Toir6tTpYkPmnLsXltlaWDQY++orVRB58JzZGMLZXKw2RBVkKLbyuY42zx9Tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "258fc59b-8d18-4e5a-93c7-3697b6b22d9b", "AQAAAAEAACcQAAAAEMI0DGKtmCKISsRskWjLQmOwijKuf4886Uif9JZaQdsc5WNBgGciudGHF6+xSAjX8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a7f75b5-babe-4769-b9da-6157c4822ae2", "AQAAAAEAACcQAAAAEJx/pAYyz7jyjheZh3hvFWXx0AYeqRtHSnEnKQk/kOnqS0QgefbjD3KZayS2CCdoBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5faeb7f9-0b2e-407f-bdc4-2eedc0f59731", "AQAAAAEAACcQAAAAEHiShbk/4lQPv13creW3rYyk0pV+IfkFYVkq/pskFrCN7JPVca4GQcwauiz7lAZRNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08f153ea-8201-4dfc-bc26-c6db297e9c8c", "AQAAAAEAACcQAAAAEHwZo0Z/n0ihaq1vdFSYMkyL8/bUkKvRlYgg/u995Eg//klP3tqteB+jCT/jEY3N0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1535a32b-7206-4237-94df-12344391eea5", "AQAAAAEAACcQAAAAEDfq7fgScI0G/QZWbcRmLoJ73gQocL0SYjE6PqoGBviWc6Ztw2MAEaoWkyrvkBF1iA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14ef30c4-70d0-44cd-82b6-4f9995f1336b", 0, "b3d7a847-4b86-4508-8d88-619a29fdab0c", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEM0D/qMDaNBY+OcFiyBPHaQG2fu7ebYlCRtgSh3PW7ghIdL/APxViHmcIl8lQZ+AvA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "29dca70a-75e6-4788-a789-ed7708f1aece", 0, "8a94d830-6e26-439d-af41-75370721f93b", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEDK9M17zQv9LXF/mwkCfB5ipI+zxIEYQC0LT+Kb9GKxK802GVsIX8c8+xNvvRf6Ltg==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "02c8c712-e7a8-4d64-957e-65b8210c22b0", 0, "fb9eb87f-1dd8-41bf-819b-1b3376b09c35", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEBcNjpyJtNY2eO/sSwYnzOqWBkiRhUTERKcORovgz3DQiovBINFUE40elKAzvyVtKg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "79f6b77b-eb72-4ac3-99b9-fdba237466d6", 0, "c826b019-b266-4195-90b6-82951691990f", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEGuyMjKT/snbdKrW9e4qvveBjj/qBTrjqIIEKx65SteIwJZrrM9BWOztwClGrFQXHw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("b1f140fa-3915-49d5-adfa-904a8ea51581"), "Immediate", 4 },
                    { new Guid("d4e7cb56-9986-49a1-84ee-ff7907b6b0e5"), "High", 3 },
                    { new Guid("3e0d86a0-a726-4f9f-9e5c-7ff4298819a5"), "Medium", 2 },
                    { new Guid("a5981e9b-7239-454b-b497-0decc8661162"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("7afcd8a1-1804-4b3a-87be-6c62b98c0934"), "Resolved", 4 },
                    { new Guid("70738404-9e63-4629-86e0-cd106e4452a9"), "In progress", 3 },
                    { new Guid("7854cc26-6713-4413-a5b6-cce3e56c84ed"), "Open", 2 },
                    { new Guid("47d65e34-820a-465e-99d5-f065016e577f"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("0295ac2f-81c8-4bcd-87b4-d225e316d3cc"), "Documentation", 4 },
                    { new Guid("5567acf7-a108-4f64-8a6b-7ce1429e70c8"), "Training", 3 },
                    { new Guid("e6e67cff-a7b9-4456-9ff1-e7b385f069dd"), "Feature request", 2 },
                    { new Guid("25d13134-0282-4bf8-83f0-95f53d8a6942"), "Bug - Error", 1 }
                });
        }
    }
}
