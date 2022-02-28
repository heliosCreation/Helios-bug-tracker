using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class updateComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Projects_ProjectId",
                table: "Comments");

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

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Comments",
                newName: "TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ProjectId",
                table: "Comments",
                newName: "IX_Comments_TicketId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "bfdcd061-2428-4f54-835c-8bc0dec970dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "41e55994-ef2e-4bdd-b019-d4dadcadf1cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "becc2d97-b92f-48e3-be34-a6f03654fe1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "40ba0a32-206f-4166-8257-ffbccbe7547a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0270ec62-5ecf-4818-8589-ebbfd0796400", "7bdbf042-bc84-40c4-a9a7-9b1c033d9d0e", "Demo Submitter", "DEMO SUBMITTER" },
                    { "e36776c8-253f-4544-874f-cd0b66d1daa2", "89cbc4cf-7c54-47e1-aedb-506a32bb4faf", "Demo Developer", "DEMO DEVELOPER" },
                    { "ef5d4f99-2af2-4ab1-92ec-f1f5e02631bb", "bfbc4e48-7f70-4134-b779-7efbe6582446", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "bf419664-2be9-46d3-8e43-58d08de78fcb", "011631b4-a1f2-4d48-86db-801aa1a24ae8", "Demo Admin", "DEMO_ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79639346-c7c0-4a3c-bc2e-b34fc34a2a02", "AQAAAAEAACcQAAAAENJjqOGv6nPwSl0cUU2yJ7xgtHB5QM18sRIF9MYDHkfcMzEzmkG/qCICuNxU8rFl4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c731300-7732-49e1-bb08-3b014884c7d1", "AQAAAAEAACcQAAAAEGVPVIr7xvaG4/rztzgR8zD3GQ+JvotVyBBTjR+4Gn1tvinDcLVUMD3fylR8de8DYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99316999-f27e-475f-904d-52f7593f060b", "AQAAAAEAACcQAAAAEAUFS4L2I92qYEZ9A8XSPt9lNjJllGt4uz1aJgPqwGaKTURaidWupiqzNzqsYIdNIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "783f5686-7795-400f-a6c0-6afc8fcd42a1", "AQAAAAEAACcQAAAAEFz75dRo2RvFMFTYg1GHuPoXextcOAG/vtwzLU+VHH4BOOLeQoOUdlXpxHYfomWL7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a815863-f723-4aa0-bad3-61e0b5627462", "AQAAAAEAACcQAAAAEPaU2bjPfsb5Hyd+DICKX7ZjxUjOcKP7mcWfXWyAmD/aiRSt2gyGaSiZUQg5UBavJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "883e4753-d72e-48a6-abed-ddc6f56ed5b0", "AQAAAAEAACcQAAAAEJ5DY1nBDmSbIifvbRWRCHEOxQ02o3wPkXcfmkTndDkrh5Vox6dTay8sdZGnr8vsMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01682bc7-c9d6-41be-b1f7-9ad00f248e15", "AQAAAAEAACcQAAAAEOJ6MBeN75A+jPoXKq2V/iAu0hYUXnAZ/82BJEcq+R0pyT7txpe7DFImbFxqgxbxbA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8d6a73cd-a0d2-45f7-be91-cafd4c1eac56", 0, "63e84dd8-d276-479d-90a9-793d49ed8697", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEN/U3aKcZFdIAAJcrHjB17QBnqgDg+1SwmCwiBWO5jzMRHuqu5o02oQ8BtbWuSxsng==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "f6106931-07cd-43c6-94d3-f4e472b32516", 0, "2df7975c-a40a-4dcd-b6ad-4c8b31208dc7", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEEYTESc0au0/Dk8X2U/Ve5Wu7h6RnKesDllV1UCNE14kEW+SvEJ2050Ds1R/o25CGA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "a8ac7a93-d56b-48a7-a707-15a01e71b218", 0, "32d14e8c-d66b-45a2-948d-6422546fd561", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAELhN9yw4geJmPc5X48o/ivR4o3GiBGPkYFLHEpwnSPvuppJfS8HSi9GQaIn9JFn8KQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "33a54361-bee6-4b8a-861a-c55b855f3c3d", 0, "d9477ad3-1350-414e-88e7-023e8e74fa21", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAENrg4eBjAIKWy4VtKrTjy3sZlG0HvuTwJzAUhr0XW2+HskI3kUUN88idyZqrGjufJw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("9ba61ced-7a7c-4aa6-9ffb-56387a610e49"), "Immediate", 4 },
                    { new Guid("ef6d7f9e-7a3b-42a1-a495-29f2b635a3df"), "High", 3 },
                    { new Guid("b3d753bd-85de-4642-8ace-62d9237bbd37"), "Medium", 2 },
                    { new Guid("a0fe08bf-8a8d-463b-8f45-2ceed0ac071d"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("7495033f-f823-4ec9-a59f-e68aa0404a28"), "Resolved", 4 },
                    { new Guid("1fa3568f-cb42-4e30-86aa-52fe96b63d86"), "In progress", 3 },
                    { new Guid("43cd8763-5fd6-460f-bff5-f4e7592f79e5"), "Open", 2 },
                    { new Guid("4e554cf2-b56b-4574-bcad-30b4a6e7a556"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("2cab3432-c8e3-4038-9688-b08e00f3597f"), "Documentation", 4 },
                    { new Guid("621ba773-f888-46f9-9b8f-12a11bfa74b0"), "Training", 3 },
                    { new Guid("e91e6842-f83c-4cd9-a97e-38122dbdb804"), "Feature request", 2 },
                    { new Guid("ce371b6e-8ba8-48b9-b6fa-b933d41774a1"), "Bug - Error", 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Tickets_TicketId",
                table: "Comments",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Tickets_TicketId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0270ec62-5ecf-4818-8589-ebbfd0796400");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf419664-2be9-46d3-8e43-58d08de78fcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e36776c8-253f-4544-874f-cd0b66d1daa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef5d4f99-2af2-4ab1-92ec-f1f5e02631bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33a54361-bee6-4b8a-861a-c55b855f3c3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d6a73cd-a0d2-45f7-be91-cafd4c1eac56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8ac7a93-d56b-48a7-a707-15a01e71b218");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6106931-07cd-43c6-94d3-f4e472b32516");

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("9ba61ced-7a7c-4aa6-9ffb-56387a610e49"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("a0fe08bf-8a8d-463b-8f45-2ceed0ac071d"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("b3d753bd-85de-4642-8ace-62d9237bbd37"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("ef6d7f9e-7a3b-42a1-a495-29f2b635a3df"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("1fa3568f-cb42-4e30-86aa-52fe96b63d86"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("43cd8763-5fd6-460f-bff5-f4e7592f79e5"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("4e554cf2-b56b-4574-bcad-30b4a6e7a556"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("7495033f-f823-4ec9-a59f-e68aa0404a28"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("2cab3432-c8e3-4038-9688-b08e00f3597f"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("621ba773-f888-46f9-9b8f-12a11bfa74b0"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("ce371b6e-8ba8-48b9-b6fa-b933d41774a1"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("e91e6842-f83c-4cd9-a97e-38122dbdb804"));

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Comments",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_TicketId",
                table: "Comments",
                newName: "IX_Comments_ProjectId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Projects_ProjectId",
                table: "Comments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
