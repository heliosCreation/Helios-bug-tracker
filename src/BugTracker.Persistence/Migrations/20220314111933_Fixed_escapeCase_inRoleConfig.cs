using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class Fixed_escapeCase_inRoleConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "8cca5ce2-d0b1-4f99-934c-4a00fc292de4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb35880-6e69-451c-bedc-bd863f6b80f6",
                column: "ConcurrencyStamp",
                value: "3dde004c-adea-4caf-b83a-9992c3bca0c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "7b456e26-9128-4be5-8c44-deda99c2677d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "e3a2383a-44fa-4e9e-80c4-40d1902ef6fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776a748a-cd98-42e8-afdb-ae578902a099",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "c09735ee-59a2-4d9a-9308-e3f61aae2a46", "Demo Project Manager" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96095b44-8c4a-4786-93d3-ee82b5b29481",
                column: "ConcurrencyStamp",
                value: "303f0a14-5e1f-4d67-8681-43acd23879d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc03a370-240d-48a6-a37b-efe518b3f065",
                column: "ConcurrencyStamp",
                value: "fe09e68e-89b3-4028-98b4-34bbffee31c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "5abd1a2c-8dac-47af-84b4-667be6c74c95");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "725342a7-ea11-4f60-ab7d-20075d701cba", "AQAAAAEAACcQAAAAEA8Z7LtPnT57gL0xxrhQ4asjuHn7/EPMPMB2G3sq6rsMH9H34jFDpN/I9vL53DyRUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38ba46fd-8b0d-40ac-8c18-b63a6903defc", "AQAAAAEAACcQAAAAEK+T/NtBoVLwgEqYFa9IJcxxLXreKfRXeFAN1CUOyK6yzGj7zm1wXZqBTjn0vW8DfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8be6454-601a-4c84-8368-c179a19e723a", "AQAAAAEAACcQAAAAEJO7hRneP+0mIDPPTVVYUAHmGHzIJUsZXbRbjAzH9DvSgVsLLwFnHbUu3jg6DmtGGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d6db2da-68bf-4752-9032-d4bf7c38b774", "AQAAAAEAACcQAAAAEFKpdCAYfONKuHVBkZKP/bnsaSryUdSibIKbIrRBppBsoH6fXPHeOPU7v55lZQHxAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980c3882-9373-474d-b9e0-f25d7c00d67e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0da655f1-1973-4dc5-9db7-d6be70f7e14e", "AQAAAAEAACcQAAAAEN6uYPna0abCrPgyvHDhjRdquo/76037XBo+aZP1Im9wAmxXl2RHbexH/S1T3mjSyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7fffe3-84fe-44f6-ac9f-287b8529f00f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0e6a746-b4c8-4028-9f67-69ec2f732a5e", "AQAAAAEAACcQAAAAEAG8iXCWbeCGLMkxrA2rkWvDIZ+cZbabduxlGuUqcYiBCHqwO08y+yIfrTbpHJB2Vw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7435362-bc74-4a5a-a215-700a8a2760f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ec84792-30ba-4d5e-a51e-ac34412eeadf", "AQAAAAEAACcQAAAAEDh3SvXUy/7mitaVsV9+rlPDFwG6n3JJ7RJKAOL0925gAF8Dy03R7rJmWaHY7spq0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0c23ea7-bbf0-423a-8c1d-52919146cc0d", "AQAAAAEAACcQAAAAELenpAKq8Z/3k5OpbCtDSir85KJFibzhbEBlgJP5GeAH5wagW2RFb9q/1AJ2sIY9Kg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be2ae4ba-1a43-4271-a6a9-14b3b7923f28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb8a18e3-1b5e-447a-b08f-dcff7443d4c7", "AQAAAAEAACcQAAAAECKabRVR0t1jNFrbPDzcrdokXRoIgK6K7RHZ849oz+2ekYVpcAsDWh6FvAPe4Pd4Fw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3ffd89c-fea0-468a-bf61-b5363911aa53", "AQAAAAEAACcQAAAAEI0NpyqK5pY04ltIX/BmzgGPamhT0cWkK+vIL1fsoQ0lvdrNQUp4F8zrg4pY+TAkxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "400ed094-d854-4c29-a53a-0eb88f837494", "AQAAAAEAACcQAAAAEPjzqct8Vqw33r1p9wON5IVUqNZhShmqVLgi6XKA+dYXCrhBVazmlXdT3xQj9XQbsA==" });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("c102a477-7715-4d59-9c73-1daf474d724c"), "Immediate", 4 },
                    { new Guid("c2d9fe5e-bd8e-4182-9018-09d9443915aa"), "High", 3 },
                    { new Guid("8d2132fe-57e4-4550-8474-4ab9df43a1a4"), "Medium", 2 },
                    { new Guid("539a7d92-bbe2-44aa-92c8-5838b7cbbd63"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("f37fa255-4407-41d9-9a5e-74a5ebd0ed79"), "Resolved", 4 },
                    { new Guid("a34e6f7d-c519-48ec-bee4-3e8223cb09df"), "In progress", 3 },
                    { new Guid("790f19fe-6962-417a-865e-9a17a6b96a27"), "Open", 2 },
                    { new Guid("7eac310d-7430-4df0-9c28-e1fdc2fa7f09"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("ebbdc382-46b6-449c-8e41-ef57aff6f338"), "Documentation", 4 },
                    { new Guid("a5c122e1-8f78-4c2c-b294-3b0c42fd957d"), "Training", 3 },
                    { new Guid("492fc53e-a13f-46fa-a7a0-862668e336c0"), "Feature request", 2 },
                    { new Guid("7bd93521-8dba-41bb-ba48-fefa1e6764c9"), "Bug - Error", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("539a7d92-bbe2-44aa-92c8-5838b7cbbd63"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("8d2132fe-57e4-4550-8474-4ab9df43a1a4"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("c102a477-7715-4d59-9c73-1daf474d724c"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("c2d9fe5e-bd8e-4182-9018-09d9443915aa"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("790f19fe-6962-417a-865e-9a17a6b96a27"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("7eac310d-7430-4df0-9c28-e1fdc2fa7f09"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("a34e6f7d-c519-48ec-bee4-3e8223cb09df"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("f37fa255-4407-41d9-9a5e-74a5ebd0ed79"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("492fc53e-a13f-46fa-a7a0-862668e336c0"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("7bd93521-8dba-41bb-ba48-fefa1e6764c9"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("a5c122e1-8f78-4c2c-b294-3b0c42fd957d"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("ebbdc382-46b6-449c-8e41-ef57aff6f338"));

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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "861ebeeb-8941-4a0f-ba57-a659abe0232e", " Demo Project Manager" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82b77835-3447-4b26-ae98-a26fd64288be", "AQAAAAEAACcQAAAAECVHVDfihYgW5lOmp+JxSe+HsLjT+ftYH7ogsOpJj5BIeLBXxP7olQETl+54qH7cGg==" });

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
    }
}
