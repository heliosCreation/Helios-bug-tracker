using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class Audit : Migration
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                value: "2a892ad0-e37b-4548-a8d9-4c29e41afb85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "78c303c1-3867-4257-8b2e-30db9b541626");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "6c3a15ed-b5a1-42b8-9161-b5c12b311baf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "1823aea1-b0ed-47a3-9010-d2ac40f3f28e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ed43023b-7bcc-44ae-82d6-4914f35ea94d", "3dcfa60f-77cf-4f3d-8bef-515680c55cc7", "Demo Submitter", "DEMO SUBMITTER" },
                    { "5dc6271e-1b91-421e-b4c8-230e3ca30bbb", "4494c4f0-3479-439d-b012-8b69ef7418f0", "Demo Developer", "DEMO DEVELOPER" },
                    { "19292550-9163-49fb-a72c-b991b7d432a9", "354ec10c-9c53-49df-8831-2c3b3791d71a", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "35319cea-39ff-4aed-9a4b-b9064e49a553", "810cd788-4a42-4973-a147-f552b8819e19", "Demo Admin", "DEMO_ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9f9b827-5137-40cc-865e-a619cc2de520", "AQAAAAEAACcQAAAAEEyFBJHseLZLtqfTmxw5f981DimDubG4FxgiuMJyvG9oX+bJ8hYzydLq4AMCNCeXpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d29dd488-5f98-4e1f-ac44-396b20217b1d", "AQAAAAEAACcQAAAAEOZBbAmhWzouNRL8GQEBGvSV6jh8a09XG+Tm0e0uqEEjFUu1yCvkZuOuO0grpvQslA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b047f2cb-b490-4449-9301-5a421ac87abe", "AQAAAAEAACcQAAAAEBeale0aaW8OYS/6F9CzsedYgbPxFXAvNYHT/A7bwa3kBKHilshlDf5kVUxuO9ON1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09762229-9138-4415-bef9-2c69790200ce", "AQAAAAEAACcQAAAAEMLC5a8ULshR55ConkdVmP7Aq6tTkUsuDsSC2A/+qCHWm2Ll8VfZOK1f7/8P2XEjqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e693aced-66ae-40fd-967e-12dc1c7d5cda", "AQAAAAEAACcQAAAAEPgBVudrTqRRx7rWnXgMq4T/vyVB97vezywzUl8c1L/pEChAfDlsaYGojhjszEUoWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a6fe52d-dc42-43fc-92d5-217a01139206", "AQAAAAEAACcQAAAAEGoRRrzU/N6fEc+oImZyRzxwFjNt0LmXH3abN6z0DKNA0fS96ewOK7ZIua4hoo3QhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "363b40a6-0e6a-4d81-8ff2-9810c079133d", "AQAAAAEAACcQAAAAEE4eXtzxmx5BIgeTIT1BK0OvOJ88Ikg+ng23LEahl+Ypr8KhjtDgJLJqQkKWeAsJ/Q==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "872e392a-8224-4517-8097-98934f728b50", 0, "fdef8f44-6f8e-45c9-8bdc-7c73c411f66c", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAECFO28gYkPRRfLNyVb5ijqBb3bhL9cfXoud7mwhntonP9URwU+/fmz6PFhJ3ZlU51A==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "3215f23e-d9a2-4bc7-b61a-8fdda12617a4", 0, "bedc3a31-d30e-459a-84e1-79943edbf281", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEDfUN4VvahggNnLlC1+JbdjcLZX337tw/K8dSKwyxaRhRzHRfHO1sikeUZfQJHvoUA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "d51a9dba-f688-4311-9601-fbcdc4d02322", 0, "e32febf7-a770-4828-8843-599c715ac949", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEHL3feTGxy9lg2NnWz6TcJ30pZWY7isdjs/xjX9UV0HJvPKSfViVbBPzcXMS1Vd04g==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "81e4802f-6387-4e7d-9c40-27a0de3bf497", 0, "07725bba-49e0-4897-8ce1-5e809700a63a", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEKX3gngUY6TQHbSzSBg38eFSfM97PUqEqHLrmf644u3I3pYt09dbtdnkWSNtXypF+g==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("7e1304d6-9683-406c-b231-f4f488cf57ad"), "Immediate", 4 },
                    { new Guid("a5e2901f-f013-4d76-9b48-f0d2ed83a325"), "High", 3 },
                    { new Guid("a617edf6-d9f3-465e-94a7-cba2d7ba1930"), "Medium", 2 },
                    { new Guid("19138e08-9f5f-4580-b2ea-f47f0f7ab05a"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("eeb4ef16-df71-4197-9ae7-cc628dafbf9f"), "Resolved", 4 },
                    { new Guid("84a09be8-47c2-4957-a47d-abb382a45c8f"), "In progress", 3 },
                    { new Guid("841874c0-60eb-4f98-ba2d-876ef6c8af11"), "Open", 2 },
                    { new Guid("d5606306-7321-4383-b7e0-b297653a139f"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("31c30e19-e66e-4239-ae85-908919ee6b66"), "Documentation", 4 },
                    { new Guid("181f641d-aeca-4577-b6fa-15da60a8c74a"), "Training", 3 },
                    { new Guid("3994434c-1b48-4062-b662-8c5ad95d10cf"), "Feature request", 2 },
                    { new Guid("baee1998-1e46-4ced-b34c-41c2451fe8fe"), "Bug - Error", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19292550-9163-49fb-a72c-b991b7d432a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35319cea-39ff-4aed-9a4b-b9064e49a553");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dc6271e-1b91-421e-b4c8-230e3ca30bbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed43023b-7bcc-44ae-82d6-4914f35ea94d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3215f23e-d9a2-4bc7-b61a-8fdda12617a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81e4802f-6387-4e7d-9c40-27a0de3bf497");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "872e392a-8224-4517-8097-98934f728b50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d51a9dba-f688-4311-9601-fbcdc4d02322");

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("19138e08-9f5f-4580-b2ea-f47f0f7ab05a"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("7e1304d6-9683-406c-b231-f4f488cf57ad"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("a5e2901f-f013-4d76-9b48-f0d2ed83a325"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("a617edf6-d9f3-465e-94a7-cba2d7ba1930"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("841874c0-60eb-4f98-ba2d-876ef6c8af11"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("84a09be8-47c2-4957-a47d-abb382a45c8f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("d5606306-7321-4383-b7e0-b297653a139f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("eeb4ef16-df71-4197-9ae7-cc628dafbf9f"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("181f641d-aeca-4577-b6fa-15da60a8c74a"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("31c30e19-e66e-4239-ae85-908919ee6b66"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("3994434c-1b48-4062-b662-8c5ad95d10cf"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("baee1998-1e46-4ced-b34c-41c2451fe8fe"));

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
