using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class changed_demoSubmitter_Normalizedmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "ffabc0e0-900e-4803-800f-8523f19bb057");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb35880-6e69-451c-bedc-bd863f6b80f6",
                column: "ConcurrencyStamp",
                value: "0afa9f2f-9cc4-498f-9fca-795980129913");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "4415d736-5e84-44ab-9d96-66de5867a027");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "66bbedee-0ae3-4ebf-8d4d-aa3560503c9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776a748a-cd98-42e8-afdb-ae578902a099",
                column: "ConcurrencyStamp",
                value: "861ebeeb-8941-4a0f-ba57-a659abe0232e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96095b44-8c4a-4786-93d3-ee82b5b29481",
                column: "ConcurrencyStamp",
                value: "e3dae9fb-e01d-482d-a3fb-5b82a16c97f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc03a370-240d-48a6-a37b-efe518b3f065",
                column: "ConcurrencyStamp",
                value: "164fe1db-e3f7-4eb5-91ef-07e23f6b2d42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "4dd12a2c-ec3d-46e3-bbed-1a17030edaf0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a94b3a9a-aed3-4ae6-aa27-d3e2439c6b0d", "AQAAAAEAACcQAAAAEMTkJblz2Hg2HUQrUK1tji0Zl+LHSUIctsR+nn/DoF1erpRrWX6Ilwr5/IUeh6XfGQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a828ee0d-5ea0-4d67-ac17-bcb9c9ae529e", "AQAAAAEAACcQAAAAEAr8jUPfcA0gmK+uhKF4ESPwyFjGxazKf8NjwF1z3Eedqbzdwk/tjI7UF8w06YU68g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07627431-7d65-4416-aae3-137fa24b4ede", "AQAAAAEAACcQAAAAEPLrHfg4EF7Ory3QC0/ntwag4hSpKW2XyCQyILgMKLyWFDLlo7sq+gEqJGiG9kXBcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f37740b-3e92-4999-9c19-385979ab072e", "AQAAAAEAACcQAAAAEGu0SQbR2YsiQmzjB3ox2JFL3DHkws+1/0Xsn0TiMyLS6tVQJ4/KcQevjr/ApRmOig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980c3882-9373-474d-b9e0-f25d7c00d67e",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "82b77835-3447-4b26-ae98-a26fd64288be", "DEMOSUBMITTER@GMAIL.COM", "AQAAAAEAACcQAAAAECVHVDfihYgW5lOmp+JxSe+HsLjT+ftYH7ogsOpJj5BIeLBXxP7olQETl+54qH7cGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7fffe3-84fe-44f6-ac9f-287b8529f00f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e11d96c3-19fe-46da-b292-11e72105740f", "AQAAAAEAACcQAAAAEDcSHz1qRJ4DPzAbWuU5WhA9aexjO7dSBIisMG9vZ6eJ5NNdg71SorPjFvztKYYRFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7435362-bc74-4a5a-a215-700a8a2760f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c5df302-7b7f-4d3f-a5ce-7693171dd9ff", "AQAAAAEAACcQAAAAEMh1Tbrr+WwCH3dGbGRHLhnwhxsyoEv77VFCqG3WSWzLzbzwOLRawUPR2t1x3RYtpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc5fa7a0-7b55-42ba-86ec-4c52950a0fc4", "AQAAAAEAACcQAAAAEFGMX6bq+/Nmw8lZbXc/4jXPY+OamqQcYtk0jRpSFBtQ2H6sDOL0MlERQcy/mTcBsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be2ae4ba-1a43-4271-a6a9-14b3b7923f28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b756354b-e915-4bcd-bacc-cdbc471c3ffb", "AQAAAAEAACcQAAAAEPRjMkw7CRPJpVkz7/sukmRH26IcCCaWekEMKyl9utedaHVk6waY+OogbYPMuere2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68dca0ae-0d72-4d75-ac07-afb1fe4fb901", "AQAAAAEAACcQAAAAEPell63jvW9LpfoLtbQthNduBXlI8x+H0aZ2DUThTWaRwOVt/so8i/eS7oLkLONzmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "330dab25-7bdb-418f-a6bb-6960bb691ea1", "AQAAAAEAACcQAAAAELyENEbqDx5uvp1QhGlt/XBk5picxRMfDIfrSmMX8KDjDA5Ab7XhJHvjii+iz3sKfA==" });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("1db45798-7182-4417-8e8a-fcac8e31914b"), "Immediate", 4 },
                    { new Guid("1320561a-4170-4915-a88c-ecc2083af6f7"), "High", 3 },
                    { new Guid("9238d00b-03cd-45b0-9038-98054b96eec6"), "Medium", 2 },
                    { new Guid("2545ec5e-148b-4972-a27d-836468e70de9"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("887da2e3-3ca3-434a-af36-f12389463130"), "Resolved", 4 },
                    { new Guid("47209107-a132-434b-93a8-2b49159b205c"), "In progress", 3 },
                    { new Guid("686444a0-d290-4a32-bd22-c3d31b552b61"), "Open", 2 },
                    { new Guid("861f231d-5885-43fc-839b-d5f0ca948e69"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("d394f006-fd76-485a-b07e-9193978712ee"), "Documentation", 4 },
                    { new Guid("dac9f222-9443-4c01-b4bc-4e63c551c1c3"), "Training", 3 },
                    { new Guid("cd240213-9b75-450a-bfbd-44aa816279a9"), "Feature request", 2 },
                    { new Guid("f5ee5e41-3882-4a9b-8399-2f6ca44320b6"), "Bug - Error", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("1320561a-4170-4915-a88c-ecc2083af6f7"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("1db45798-7182-4417-8e8a-fcac8e31914b"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("2545ec5e-148b-4972-a27d-836468e70de9"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("9238d00b-03cd-45b0-9038-98054b96eec6"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("47209107-a132-434b-93a8-2b49159b205c"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("686444a0-d290-4a32-bd22-c3d31b552b61"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("861f231d-5885-43fc-839b-d5f0ca948e69"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("887da2e3-3ca3-434a-af36-f12389463130"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("cd240213-9b75-450a-bfbd-44aa816279a9"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("d394f006-fd76-485a-b07e-9193978712ee"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("dac9f222-9443-4c01-b4bc-4e63c551c1c3"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("f5ee5e41-3882-4a9b-8399-2f6ca44320b6"));

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "e551b929-69fd-4745-89e3-2e0c8692d29f", "JOHN@GMAIL.COM", "AQAAAAEAACcQAAAAEOGqZX8BMOYKxXV44tMyqhNMmxkOC8OX1YMRqdF786FQLmO16MPJ+fwGCQIxdJD89A==" });

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
    }
}
