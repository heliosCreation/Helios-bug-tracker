using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class removeUserIsLockedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "73efed47-7889-45c5-9302-a7d41edf0fa9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb35880-6e69-451c-bedc-bd863f6b80f6",
                column: "ConcurrencyStamp",
                value: "81975669-ec8e-4ca4-b5ef-ff66cb1b77a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "89263b42-bad4-4065-995f-77bd6c4c2f6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "1a84437c-db6d-4194-80df-b946b5adf956");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776a748a-cd98-42e8-afdb-ae578902a099",
                column: "ConcurrencyStamp",
                value: "fe785a73-808c-4216-bf3e-373d13d32052");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96095b44-8c4a-4786-93d3-ee82b5b29481",
                column: "ConcurrencyStamp",
                value: "cdcae5df-b7ac-45a1-aa8b-ced4c47126f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc03a370-240d-48a6-a37b-efe518b3f065",
                column: "ConcurrencyStamp",
                value: "397ae19a-cb69-4d22-819c-4959957d3db4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "bb37d836-6f49-4063-864d-75be08c984a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6b0d306-3f89-4ab6-a381-e0d712be0d90", "AQAAAAEAACcQAAAAEBje3ZP0I3A6oDQwtxWtAQfupIKQneAMXHkmUhWY9VEuPgtmyrhio17d/gODfZvfbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "697c6007-7b5b-4b00-81fb-6fe57224c1c4", "AQAAAAEAACcQAAAAEGvM7YrWKhhv+HM6UDeDZIG5grmJ+Jm1Gmf/njDbDPqOR6zFHDtqtBlWXJqXfxjJoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ee027c7-1260-47fc-9340-ffd70a69823b", "AQAAAAEAACcQAAAAEI7zar1tykuPOX69YEYiY0YGTeR1d0k78rM3YtMhzt7KyWrTuKjcU5q6fNje/UBaOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1ef6f19-93c5-4574-a4cd-a8a3d1b9015c", "AQAAAAEAACcQAAAAEHYHIwisxWg0qftDT1XchZ2oVfBEOypXfk+CY6cx097YELZLXM1KieyTT2vz6uVhOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980c3882-9373-474d-b9e0-f25d7c00d67e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e74bc8cb-8a3e-4a1a-8200-3be31183d3e9", "AQAAAAEAACcQAAAAEBEMoO01uxM3d6vYatL73m2mjGB8I3sURK6PWz+f7BD2HsRdXSQEsYGfM/9h9BpBgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7fffe3-84fe-44f6-ac9f-287b8529f00f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3c94892-1e00-48bb-8e12-1b915b69b732", "AQAAAAEAACcQAAAAEFpUoA8lAoPWtaZmMAMbYNyJ58HafQTAyUQiEO+BGhrH+KvSg0VMFMaf4UZgSbrQcg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7435362-bc74-4a5a-a215-700a8a2760f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "759a3d6f-cd67-46b3-b202-ae981f7beca6", "AQAAAAEAACcQAAAAEHinODd29/oHbwfo0z41wrAMxLl4qIAiYL8EI+e6MUftRN/RlGQB9sAzuutTICXBQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38e7f382-d162-4f57-87d2-25a01e2bfc74", "AQAAAAEAACcQAAAAECWrbbIef+pVqxPy/MHW2dmzdeSLKJBkfyAUw9YNROF0sPxqPxymWEwLil0y5cziUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be2ae4ba-1a43-4271-a6a9-14b3b7923f28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4024b5c-67b1-4937-984c-2ae27b3489c0", "AQAAAAEAACcQAAAAEKkuFFzTHv6A98160F6e8fi4xtmFQK5PapGyAIWIDp5SwLFFIXd412sIaAXFGuIS2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e141bfa-f297-47c6-821d-564562fe5401", "AQAAAAEAACcQAAAAEDOJomH01u9NS1lw1idfsU5KWqwMfDO0VRvtZw7/TiQZ1OuigRJgDdGcjJp8gGldKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca562f34-25fb-4ea5-af56-3a14fab45e93", "AQAAAAEAACcQAAAAEGOA3scJeK7KPOMNt7+TlTQfFMzdQ+u1wgEayLP0x+Ob5PV4gdkVHGnlWnTbNmrYng==" });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("72d8db04-a88d-4225-8ce4-2dc663e54ae8"), "Immediate", 4 },
                    { new Guid("72aa93c0-32b2-47ca-9163-29edc5bc2290"), "High", 3 },
                    { new Guid("f391dfdf-0eeb-4b5b-873a-363d3332016d"), "Medium", 2 },
                    { new Guid("edd60849-4574-4e4d-979f-17d8a7ee6361"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("f7f30047-e096-4dd0-96b1-590c87d4b728"), "Resolved", 4 },
                    { new Guid("30bac2fd-ee05-4732-85aa-df8f590c9e61"), "In progress", 3 },
                    { new Guid("3328dc60-57ff-4864-a5ce-11a663391c1e"), "Open", 2 },
                    { new Guid("0af63bb5-6013-4eca-8922-a8d42d5d7e8e"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("79bc0f4f-a431-4f42-b712-ca2ff7f99d73"), "Documentation", 4 },
                    { new Guid("b7581387-f545-43dd-9fd1-9444939e08bc"), "Training", 3 },
                    { new Guid("4c5040e7-737b-458d-ad98-deb05d84f818"), "Feature request", 2 },
                    { new Guid("3ceb7c05-0276-4539-a81f-613b625034c0"), "Bug - Error", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("72aa93c0-32b2-47ca-9163-29edc5bc2290"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("72d8db04-a88d-4225-8ce4-2dc663e54ae8"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("edd60849-4574-4e4d-979f-17d8a7ee6361"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("f391dfdf-0eeb-4b5b-873a-363d3332016d"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("0af63bb5-6013-4eca-8922-a8d42d5d7e8e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("30bac2fd-ee05-4732-85aa-df8f590c9e61"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("3328dc60-57ff-4864-a5ce-11a663391c1e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("f7f30047-e096-4dd0-96b1-590c87d4b728"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("3ceb7c05-0276-4539-a81f-613b625034c0"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("4c5040e7-737b-458d-ad98-deb05d84f818"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("79bc0f4f-a431-4f42-b712-ca2ff7f99d73"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("b7581387-f545-43dd-9fd1-9444939e08bc"));

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
    }
}
