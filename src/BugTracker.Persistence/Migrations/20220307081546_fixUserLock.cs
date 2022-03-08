using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class fixUserLock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsLocked",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "3c95323c-508f-4b61-8ab7-2317a82f1cdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb35880-6e69-451c-bedc-bd863f6b80f6",
                column: "ConcurrencyStamp",
                value: "362e64ce-3322-4096-a7bc-0fe0a55f77ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "d64b37ba-03ba-451c-a54d-01c85d50321c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "8889c0b9-975e-4c33-ac23-610059569a84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776a748a-cd98-42e8-afdb-ae578902a099",
                column: "ConcurrencyStamp",
                value: "4dbbe89c-ebcf-4fca-a8d3-725bc4f4f77d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96095b44-8c4a-4786-93d3-ee82b5b29481",
                column: "ConcurrencyStamp",
                value: "2675b34b-9c46-4a9b-aed7-d18b62da7493");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc03a370-240d-48a6-a37b-efe518b3f065",
                column: "ConcurrencyStamp",
                value: "bf4c126f-2d84-4446-8804-aca04ba8eb9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "ccdb6f65-15c1-4051-8904-36013ed0be98");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43ff6bdf-527c-44e6-ada9-48de92d2e63e", "AQAAAAEAACcQAAAAED4Ysf6wqReYuZgpRvfNrzZ1b5KASNyzd7Hv/PUISzhRxR4SWBucz2n6tcMtamZGaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7b1e95d-b419-4db3-9f23-138a75241a73", "AQAAAAEAACcQAAAAECGugSYV/L+uy8M48HtU7EQ6uHLNVvdzQlOCfleudUNeWMv3nQM2dhiRtC+Ggxd6WA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac0e0ae5-eee7-4518-ba9f-6829a016a5f3", "AQAAAAEAACcQAAAAEHviMCiR7RtuizYbDQOqOZauHSQN6fJwbOIaIrJQEqesK6nuuwxaGbbDyR3zMVh6tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9fb62b5-2ad9-4fb9-8362-86e99bd5e2cb", "AQAAAAEAACcQAAAAELEvbEIPBfEcUyefbKPGIlH388AtShEsHUfU/NFgiMsz9rOnV6r4yYcAATtbW2ANag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980c3882-9373-474d-b9e0-f25d7c00d67e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcb5f624-8fb4-4bcf-a4d7-d1ad7b79e1c8", "AQAAAAEAACcQAAAAEFL/amogj9cfHEf26Zy2UidMMFFImMygZJSjFBAXeZMQSi3Ak7GVXLKlrxU/JlyZ7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7fffe3-84fe-44f6-ac9f-287b8529f00f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "228b0e57-8869-4f16-bb57-ffb20c6dacee", "AQAAAAEAACcQAAAAEF8IunIgMseeDxMmZwaR6UMt8zE1s5yWwARvynTBF7O3EN0uF7i8BfpO3pcHpA3xcg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7435362-bc74-4a5a-a215-700a8a2760f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c91eb915-a09e-4848-88c8-ae62d7538a29", "AQAAAAEAACcQAAAAEAHdEPOg3Xc4RHYJhWPGtS+jRCAZmkxC8oqB8bmeYsemyBjJPWd3eY145uKOGOS/lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d71f4230-40c4-47cb-b900-be3b4e95f307", "AQAAAAEAACcQAAAAEANBpDZabBPLPWAxT7woltpN1q4aV5OFe5425amhIHgK3MQOvoIfX/ezPnrDCYCC8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be2ae4ba-1a43-4271-a6a9-14b3b7923f28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2c98f19-d8ba-4669-a737-29ab92a25474", "AQAAAAEAACcQAAAAEGQhizr9lPQw/4cBfaQNhOFYBmVIGQGNdV2869eXC3QgXbhz/WlKBKwR/Oz7E0gcBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3c8852e-0f5d-41bc-b6f4-3840ae19682a", "AQAAAAEAACcQAAAAEKWjcrs7RuScW3JxzycbFxkkdEB1AlD2LS2TfxCE9aQJIyPJSYK1/AgEOa+p3XCmoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c242d74-997b-4025-af0c-1c860871264a", "AQAAAAEAACcQAAAAEJxCE8EGvVqHF0omO4WT0bksbxcp5MHRbBhJVtE+0J7HqyHrGrqkranhZSPvxqTqzw==" });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("77cbbcf4-3bec-4383-aedd-c9d802214b39"), "Immediate", 4 },
                    { new Guid("18c3ca5c-5390-4ba1-80bb-b3c1c26ceb12"), "High", 3 },
                    { new Guid("3a0cfa22-7263-4be8-acb4-23cc53ea37bb"), "Medium", 2 },
                    { new Guid("a85af8c9-122f-4426-9332-9a0750331541"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("1136a5dc-2379-40e3-8a3e-6b8b42ac1ced"), "Resolved", 4 },
                    { new Guid("85b15fe9-207b-4e43-9019-e3aef0e5cbfb"), "In progress", 3 },
                    { new Guid("afc460e2-b1e0-4e03-abfc-db0254b9a289"), "Open", 2 },
                    { new Guid("bb6d4d3f-a06f-42b2-91cd-2a1dc6c27814"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("12ddeb8a-9f93-4bae-961b-4337c38f5707"), "Documentation", 4 },
                    { new Guid("befa7895-6aaf-45a5-909c-75d649be0e50"), "Training", 3 },
                    { new Guid("9cd391bb-1879-4ae3-9517-d69d0f0d2e21"), "Feature request", 2 },
                    { new Guid("c50fa6c8-0677-4ac4-8846-399c1891b50e"), "Bug - Error", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("18c3ca5c-5390-4ba1-80bb-b3c1c26ceb12"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("3a0cfa22-7263-4be8-acb4-23cc53ea37bb"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("77cbbcf4-3bec-4383-aedd-c9d802214b39"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("a85af8c9-122f-4426-9332-9a0750331541"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("1136a5dc-2379-40e3-8a3e-6b8b42ac1ced"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("85b15fe9-207b-4e43-9019-e3aef0e5cbfb"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("afc460e2-b1e0-4e03-abfc-db0254b9a289"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("bb6d4d3f-a06f-42b2-91cd-2a1dc6c27814"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("12ddeb8a-9f93-4bae-961b-4337c38f5707"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("9cd391bb-1879-4ae3-9517-d69d0f0d2e21"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("befa7895-6aaf-45a5-909c-75d649be0e50"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("c50fa6c8-0677-4ac4-8846-399c1891b50e"));

            migrationBuilder.DropColumn(
                name: "IsLocked",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "4e7aa6aa-b46f-438d-834c-fe42b2a9360e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb35880-6e69-451c-bedc-bd863f6b80f6",
                column: "ConcurrencyStamp",
                value: "95f99477-7653-4612-9c83-c0d8eb130a23");

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
                keyValue: "776a748a-cd98-42e8-afdb-ae578902a099",
                column: "ConcurrencyStamp",
                value: "0872f440-e445-407b-ad92-6739d509505a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96095b44-8c4a-4786-93d3-ee82b5b29481",
                column: "ConcurrencyStamp",
                value: "726121b3-f732-49b3-a274-a16f603c9dcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc03a370-240d-48a6-a37b-efe518b3f065",
                column: "ConcurrencyStamp",
                value: "74da1130-60a9-409f-aa17-56852ba8efec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "f08513df-242a-49bc-ba7c-b4637e1caa51");

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
                keyValue: "980c3882-9373-474d-b9e0-f25d7c00d67e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fe7495d-b00e-4558-90f0-f65c3603e24c", "AQAAAAEAACcQAAAAEB3sxGcM54UM/1nFFmSB/2HLJ0W3sV8bJa1KidG9hPi5XOwmIXqUPhtmz9oTXVk7GA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7fffe3-84fe-44f6-ac9f-287b8529f00f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d2488d8-452e-4fc3-9653-ffdc038137a1", "AQAAAAEAACcQAAAAEPqPh31LTMjaSmsDBkJHe1EpKdFRBP2IHwxkNPkLm3LHSIBKcpI8pCVJWHWW8VKczg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7435362-bc74-4a5a-a215-700a8a2760f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23c21621-3d3a-47c0-80d9-10f0d2376712", "AQAAAAEAACcQAAAAEEEJytzSJl7M35mFUu5nlMbPi5wh1Dpqx2z3eashLmZUOLExghNY11p5QPiYX+KzpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f027741-cf93-437e-abd9-78e9240615e3", "AQAAAAEAACcQAAAAECW5b6CDWEfMQMLK+F3Xd+AmL8yAsanK75ej7zQlyXS3yRTVNS/5iERslsC6bMH92Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be2ae4ba-1a43-4271-a6a9-14b3b7923f28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2da1a19b-d786-4529-82fa-836a723d7237", "AQAAAAEAACcQAAAAEFgKdDlk5VMEv56EN9DhhAMkmkRJx0JxrV+M/SnXKG/f5/0sAZGIMx9DCAm7Ii/T1Q==" });

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
        }
    }
}
