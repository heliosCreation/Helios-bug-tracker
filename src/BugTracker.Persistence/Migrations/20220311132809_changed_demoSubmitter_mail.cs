using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class changed_demoSubmitter_mail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "385dcb9c-b242-43ed-8ebf-8300f6dbfc56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb35880-6e69-451c-bedc-bd863f6b80f6",
                column: "ConcurrencyStamp",
                value: "ee4d7382-60a3-4d34-9f38-7ac1f491b8cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "b5b73189-b935-4b8f-a0c7-e5f8bdebf2fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "cad4bb08-4d3f-4109-b07e-1f1a6600a4a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776a748a-cd98-42e8-afdb-ae578902a099",
                column: "ConcurrencyStamp",
                value: "8ae4e0ee-9b67-429f-9c15-0939632dcad2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96095b44-8c4a-4786-93d3-ee82b5b29481",
                column: "ConcurrencyStamp",
                value: "90e76ad8-808f-42fa-b6fd-48baa05c9533");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc03a370-240d-48a6-a37b-efe518b3f065",
                column: "ConcurrencyStamp",
                value: "48dda377-a5ce-4ee3-bf36-0a47b9d76bee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "8b47da6e-d4a9-49a8-9b57-9db4d70b1ddb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0093b57b-0c83-4aad-8615-f54312a449eb", "AQAAAAEAACcQAAAAEPuk2Da6GQbKNHNFOdzEJUfZC7efCV6zBYrWPhbYaGID7g/27Ugxdv9bTi7kqP2hcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23b5cd20-cae9-413e-9350-bbce122f44b7", "AQAAAAEAACcQAAAAEN4X0MwTaGRSwHrxFIFrWpI7IbGzgPOP15kB66JAfarTN7a88R8meBwJRoPZSu7F/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9b948c7-5d26-4207-8d90-5365a2067052", "AQAAAAEAACcQAAAAENRG/T8UnNnPrNjY54Papa5CrUJKicKjLgUg7HQzwnb4+eWbfgX3F/rd1OcIortYZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa892774-d8dd-49a6-a7ec-1e3c925becb9", "AQAAAAEAACcQAAAAEPm4LxPmldL7QBAKr4wpwrX2l+CgpnYYHiYz5G/mJd/uYhwVg2jnDaqgtd5khwESzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980c3882-9373-474d-b9e0-f25d7c00d67e",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash" },
                values: new object[] { "e551b929-69fd-4745-89e3-2e0c8692d29f", "demoSubmitter@gmail.com", "AQAAAAEAACcQAAAAEOGqZX8BMOYKxXV44tMyqhNMmxkOC8OX1YMRqdF786FQLmO16MPJ+fwGCQIxdJD89A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7fffe3-84fe-44f6-ac9f-287b8529f00f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adc3cd2d-0467-4fcd-8285-dd60abfa4f6b", "AQAAAAEAACcQAAAAEMeZ1sKqPHnoJH1FGXqV2HxyhVESOU3trzATglRtR7yQa4D0FphjleHWztB8K1gxbA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7435362-bc74-4a5a-a215-700a8a2760f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ae8fed7-35bf-4476-acdb-622fdc35f0de", "AQAAAAEAACcQAAAAEAMsa71p5UZWL/YQcQO6B/z7h9IH71xzUShphUYDgL6SgBrhnFgXbiw5wrNJ88WfXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ad0ece4-bea9-49d8-8b3e-e45ecafbbe18", "AQAAAAEAACcQAAAAEBv5IYVBV50pivQL21RRw45tbGAOjod6lf40KclHdY5fQIq6S3iaZWe50nPjKJOldg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be2ae4ba-1a43-4271-a6a9-14b3b7923f28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ce8840d-129a-4cb3-939e-3de41b72fe79", "AQAAAAEAACcQAAAAEEL3QNCCyLdxzGobWZyA4iwq+6+LwG3/G723wYKHr5IC3C/bhScfU7MpsANfdr3mEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99f4c451-40cc-42dd-bf73-254f33a48263", "AQAAAAEAACcQAAAAECthXF++XGNLF5caf97J5zwxuD/xrYeYOyYIBHid73QgJWfwrvknsht917u6utgT5Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1c3c252-bed6-4e0c-b4aa-d3d52b03d145", "AQAAAAEAACcQAAAAEOgeCkTxj+dEb6w24Nu9Dl3nbjm1z5/Jz/2ktgJHH4dWnjMgMA/FT4U/c4m+A7vi0w==" });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("b6d61d0c-e311-4ec7-a211-bb8ff1c147fb"), "Immediate", 4 },
                    { new Guid("8025d5df-4493-408d-91a3-a17bac41012c"), "High", 3 },
                    { new Guid("7d539a43-f620-4cdb-ae55-c4ceccc66e20"), "Medium", 2 },
                    { new Guid("61d3262e-bb37-41f8-90ea-62f1b179f3e6"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("68644a1d-8680-460f-852d-27d8513a288f"), "Resolved", 4 },
                    { new Guid("9443d4ce-12e1-4560-8359-a3b168d83c65"), "In progress", 3 },
                    { new Guid("2d9224ae-9754-4528-adb8-a72701c3edf8"), "Open", 2 },
                    { new Guid("a9ff29a1-c446-4962-8dc0-503e5a68ed68"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("c611424a-e97d-40e7-b497-e3bb9436f1d4"), "Documentation", 4 },
                    { new Guid("d0182d0d-1b6c-4985-85c6-2af672fb1f53"), "Training", 3 },
                    { new Guid("f397f3a8-4e92-4c1a-885f-194f6ac4d537"), "Feature request", 2 },
                    { new Guid("d72624d7-f93b-4587-80c3-ced5c4886ca0"), "Bug - Error", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("61d3262e-bb37-41f8-90ea-62f1b179f3e6"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("7d539a43-f620-4cdb-ae55-c4ceccc66e20"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("8025d5df-4493-408d-91a3-a17bac41012c"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("b6d61d0c-e311-4ec7-a211-bb8ff1c147fb"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("2d9224ae-9754-4528-adb8-a72701c3edf8"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("68644a1d-8680-460f-852d-27d8513a288f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("9443d4ce-12e1-4560-8359-a3b168d83c65"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("a9ff29a1-c446-4962-8dc0-503e5a68ed68"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("c611424a-e97d-40e7-b497-e3bb9436f1d4"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("d0182d0d-1b6c-4985-85c6-2af672fb1f53"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("d72624d7-f93b-4587-80c3-ced5c4886ca0"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("f397f3a8-4e92-4c1a-885f-194f6ac4d537"));

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
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash" },
                values: new object[] { "e74bc8cb-8a3e-4a1a-8200-3be31183d3e9", "john@gmail.com", "AQAAAAEAACcQAAAAEBEMoO01uxM3d6vYatL73m2mjGB8I3sURK6PWz+f7BD2HsRdXSQEsYGfM/9h9BpBgQ==" });

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
    }
}
