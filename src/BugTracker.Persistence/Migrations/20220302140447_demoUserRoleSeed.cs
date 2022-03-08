using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class demoUserRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "4e7aa6aa-b46f-438d-834c-fe42b2a9360e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "1f628e53-e1bf-4b7e-b906-e9b7225f45e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "fbf12b3b-080b-453e-ac45-f41b2eb1c0ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "f08513df-242a-49bc-ba7c-b4637e1caa51");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96095b44-8c4a-4786-93d3-ee82b5b29481", "726121b3-f732-49b3-a274-a16f603c9dcd", "Demo Submitter", "DEMO SUBMITTER" },
                    { "bc03a370-240d-48a6-a37b-efe518b3f065", "74da1130-60a9-409f-aa17-56852ba8efec", "Demo Developer", "DEMO DEVELOPER" },
                    { "776a748a-cd98-42e8-afdb-ae578902a099", "0872f440-e445-407b-ad92-6739d509505a", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "5eb35880-6e69-451c-bedc-bd863f6b80f6", "95f99477-7653-4612-9c83-c0d8eb130a23", "Demo Admin", "DEMO_ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8325d0a1-d7be-43de-a364-1a2770259580", "AQAAAAEAACcQAAAAEPO/5L1pfPoKOc85kxEnmn7wHjTfLBOSyfaRKT6fejOxMwDHaTlvvY/kt1c1uAtb+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a55e0291-44ab-468a-bfa9-7da3bfe614e5", "AQAAAAEAACcQAAAAEA7uCRZNSsFTpeu708e3HiAmqacTS5V0NLhLYsEokN+7fbiZSrjBZHtIKchF65NWEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a17eff07-11fe-484a-9785-8a6827bf37ce", "AQAAAAEAACcQAAAAEN3IGhRkejWiXfKyoFeVqB9T26NGugnXyLxCD6I6Is9e7VLvUfv/W2Xio1LFkfxuTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3899dce-11ad-4a19-b256-ee224dd2ebba", "AQAAAAEAACcQAAAAEEVaAebHnPYggfIS2czYvA/asBbXsJ1U0SLrruANPI87LfpE9D/NOLKjr4Id5iXZfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f027741-cf93-437e-abd9-78e9240615e3", "AQAAAAEAACcQAAAAECW5b6CDWEfMQMLK+F3Xd+AmL8yAsanK75ej7zQlyXS3yRTVNS/5iERslsC6bMH92Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8cba0b61-3c68-462b-b25d-c237d1974d3d", "AQAAAAEAACcQAAAAEP4/La21fPSCs8c/f6u5fj0wWq0fcPZYPDp4gbOlGm3Q8sgBTTouKOo/XwgLiDyLkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "135c4420-7af8-4bc1-8d3d-a00fac5f6d3d", "AQAAAAEAACcQAAAAEDbNL6ckEi3yj+IOV5KVHMk+wLRJKiDd2u+nll+mZKekOEpaQFwHZgp8w9vdzHy7dQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b7435362-bc74-4a5a-a215-700a8a2760f3", 0, "23c21621-3d3a-47c0-80d9-10f0d2376712", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEEEJytzSJl7M35mFUu5nlMbPi5wh1Dpqx2z3eashLmZUOLExghNY11p5QPiYX+KzpQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "be2ae4ba-1a43-4271-a6a9-14b3b7923f28", 0, "2da1a19b-d786-4529-82fa-836a723d7237", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEFgKdDlk5VMEv56EN9DhhAMkmkRJx0JxrV+M/SnXKG/f5/0sAZGIMx9DCAm7Ii/T1Q==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "ae7fffe3-84fe-44f6-ac9f-287b8529f00f", 0, "6d2488d8-452e-4fc3-9653-ffdc038137a1", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEPqPh31LTMjaSmsDBkJHe1EpKdFRBP2IHwxkNPkLm3LHSIBKcpI8pCVJWHWW8VKczg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "980c3882-9373-474d-b9e0-f25d7c00d67e", 0, "2fe7495d-b00e-4558-90f0-f65c3603e24c", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEB3sxGcM54UM/1nFFmSB/2HLJ0W3sV8bJa1KidG9hPi5XOwmIXqUPhtmz9oTXVk7GA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("93121274-87d4-4743-83de-6890795ef24d"), "Immediate", 4 },
                    { new Guid("c209236f-0634-4f15-a28b-a66a21235fca"), "High", 3 },
                    { new Guid("40550dd0-f775-42a3-85cc-9e723d734955"), "Medium", 2 },
                    { new Guid("8ab19ab3-ffc3-40d7-b7e2-7598e163444e"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("70d10be1-831e-4e9a-b0eb-f84bc6b5575d"), "Resolved", 4 },
                    { new Guid("f588bcf3-458f-4c39-b501-d62978e97dae"), "In progress", 3 },
                    { new Guid("d7ccf6c7-57ce-43d7-9752-f4f5db59ee4d"), "Open", 2 },
                    { new Guid("3ea1321e-e834-4a95-bc0d-7a89ce24caae"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("53ff95c0-29e3-4591-83a6-836d4c9d14fb"), "Documentation", 4 },
                    { new Guid("095fc6bd-f4ab-4790-91fd-26c4e906a401"), "Training", 3 },
                    { new Guid("7bbb8494-0b63-461e-9365-d6d7c1983b44"), "Feature request", 2 },
                    { new Guid("6ae33dd3-a4cd-44d7-bdf6-dca6a06ced01"), "Bug - Error", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5eb35880-6e69-451c-bedc-bd863f6b80f6", "ae7fffe3-84fe-44f6-ac9f-287b8529f00f" },
                    { "776a748a-cd98-42e8-afdb-ae578902a099", "b7435362-bc74-4a5a-a215-700a8a2760f3" },
                    { "bc03a370-240d-48a6-a37b-efe518b3f065", "be2ae4ba-1a43-4271-a6a9-14b3b7923f28" },
                    { "96095b44-8c4a-4786-93d3-ee82b5b29481", "980c3882-9373-474d-b9e0-f25d7c00d67e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96095b44-8c4a-4786-93d3-ee82b5b29481", "980c3882-9373-474d-b9e0-f25d7c00d67e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5eb35880-6e69-451c-bedc-bd863f6b80f6", "ae7fffe3-84fe-44f6-ac9f-287b8529f00f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "776a748a-cd98-42e8-afdb-ae578902a099", "b7435362-bc74-4a5a-a215-700a8a2760f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc03a370-240d-48a6-a37b-efe518b3f065", "be2ae4ba-1a43-4271-a6a9-14b3b7923f28" });

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("40550dd0-f775-42a3-85cc-9e723d734955"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("8ab19ab3-ffc3-40d7-b7e2-7598e163444e"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("93121274-87d4-4743-83de-6890795ef24d"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("c209236f-0634-4f15-a28b-a66a21235fca"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("3ea1321e-e834-4a95-bc0d-7a89ce24caae"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("70d10be1-831e-4e9a-b0eb-f84bc6b5575d"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("d7ccf6c7-57ce-43d7-9752-f4f5db59ee4d"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("f588bcf3-458f-4c39-b501-d62978e97dae"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("095fc6bd-f4ab-4790-91fd-26c4e906a401"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("53ff95c0-29e3-4591-83a6-836d4c9d14fb"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("6ae33dd3-a4cd-44d7-bdf6-dca6a06ced01"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("7bbb8494-0b63-461e-9365-d6d7c1983b44"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb35880-6e69-451c-bedc-bd863f6b80f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776a748a-cd98-42e8-afdb-ae578902a099");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96095b44-8c4a-4786-93d3-ee82b5b29481");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc03a370-240d-48a6-a37b-efe518b3f065");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980c3882-9373-474d-b9e0-f25d7c00d67e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7fffe3-84fe-44f6-ac9f-287b8529f00f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7435362-bc74-4a5a-a215-700a8a2760f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be2ae4ba-1a43-4271-a6a9-14b3b7923f28");

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
        }
    }
}
