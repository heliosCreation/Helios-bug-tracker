using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class ticketTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23597478-5000-4f25-83e1-2b847e9c7aca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "271d538c-b8f7-4ba3-9312-2bdee713b28a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3307d5e4-7a78-46ff-bfb0-56875b3f9c6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39c7fec8-f948-4147-ac7e-0cf38c718616");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43acc8bf-f213-4d2f-b4df-16c9ae25192a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d9e8140-8fcb-4286-baaf-47a70dcfa06b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "675ccb0e-67c9-4b0d-9909-70666db8b0fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5046d72-690f-4af4-b6cc-4b3b7820122a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16d38986-452e-4e8b-9530-3ad68b3dbdeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c0ad215-2e08-4bd4-88af-14625d1900e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7680f0a4-f32b-4b88-86ff-074a312ff099");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f16b756-5ead-43a4-8afd-30337aa6e62f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8496466c-0496-44b9-b2a0-48e88d2eb986");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "914b1d35-ae93-480c-bed1-5bb7e1b04058");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96576522-0f45-4d29-ade2-da5ba3eae90f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c634ed-88a0-486a-a2ae-ba87e1865536");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc18dc97-f001-4f99-b74f-ceacdb91fc97");

            migrationBuilder.CreateTable(
                name: "TicketsTeamMembers",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketsTeamMembers", x => new { x.TicketId, x.UserId });
                    table.ForeignKey(
                        name: "FK_TicketsTeamMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketsTeamMembers_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "089e3fda-7234-4e98-a6e1-65bc92a808f3", "6ed77779-ba75-4098-a23e-f3c83f66e320", "Demo Submitter", "DEMO SUBMITTER" },
                    { "ec3083f8-6888-4933-a787-f7cac560b29b", "2e833e20-3d74-42fd-92e5-6103df0b5db6", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "43827923-9b27-4813-9310-a2059ce2955d", "296d038b-5af1-469a-86b2-029155d03ca5", "Demo Admin", "DEMO_ADMIN" },
                    { "58b71a6e-f7ef-462c-a866-309c7d90ef96", "d2b42aec-1cc5-47e7-be2a-538d85f8c4c0", "Submitter", "SUBMITTER" },
                    { "5866dbd5-d1a8-4d5c-954f-ab82e8024870", "4967c654-6db0-45a6-ac0c-b3d72aae1839", "Developer", "DEVELOPER" },
                    { "975f19ac-2d76-4967-9adf-b6aecd536186", "793dae08-6a8f-474c-b655-644d822e59a3", "Project Manager", "PROJECT MANAGER" },
                    { "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65", "06a6855a-7d93-4686-8e67-5b80a86e5963", "Admin", "ADMIN" },
                    { "476b13d7-0f9d-47e3-a9f8-f6b78884e5e6", "16b83688-bdb7-4e38-bc6c-11d7b50df1b4", "Demo Developer", "DEMO DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "19b1483b-58ab-4e23-9819-7b05365d104f", 0, "3365d352-8545-44fc-9c6f-8ff525d5db49", "alice.cooper@hotmail.com", true, null, null, false, null, "ALICE.COOPER@HOTMAIL.COM", "ALICE COOPER", "AQAAAAEAACcQAAAAEK8BfLXus4XxF9muY0KvUbFpPJrGuU/H+Ws6b9tXFzUfXT+1WOeHjEnVFOJUCmnBIg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Alice cooper" },
                    { "b6c5641b-4656-4f5d-9982-38a8f938e697", 0, "22fb6687-5b78-4ea6-b32e-a39ec0a9fab9", "jane.doe@hotmail.com", true, null, null, false, null, "JANE.DOE@HOTMAIL.COM", "JANE DOE", "AQAAAAEAACcQAAAAEEN10p1DhOFodsEzkBjhVue3l2cUhg0YIaZgWZ48og/s+7FSx/hbBwr7nP0bX0fVTA==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jane doe" },
                    { "54391856-dd23-43fa-958e-b4ca84d9aa65", 0, "65a88850-0617-4c78-8552-c7eb493810b4", "john.doe@hotmail.com", true, null, null, false, null, "JOHN.DOE@HOTMAIL.COM", "JOHN DOE", "AQAAAAEAACcQAAAAELc3nnOP2/dOeZfrbFkiWywdN/xlPmpL2V1Z0ecO2kIlWjYZQ4LFwQs77TUA1k35zw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "John doe" },
                    { "21bbccc8-fc2a-4881-b746-ed9d90fbff9b", 0, "df07423b-7618-4f3f-a8aa-4056ef0c82fd", "quentin.coui@hotmail.com", true, null, null, false, null, "QUENTIN.COUI@HOTMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAELgC6tOU3aceqIqRowyhGkvs/ljD30fvuy+RvZ+Eay+j34flwK2dMjkOZNeYcCSqlw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Admin" },
                    { "65d7121d-9ad2-4149-be59-9c7030a49725", 0, "46e579be-5968-46cc-bfdf-26defebc6edf", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEJhRuT4Z295RLmcZkV28UoJPgw2nSPy/WgTqgn3lOUI8co6BPt8qrn+1SEbAg1nj8w==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "0e1899ff-e159-4c8f-ab1c-7d828731f356", 0, "be038953-24ac-4b60-931b-1d39da3a0ed1", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAECv9r589LDFMHPAYpavToN64VhSrvvwCPINRddSXAaHMQzrM5EK7nYnDw0rBO5jTLg==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "80f52789-f5c7-4718-8b49-bbe0174872ca", 0, "aef55e63-5391-42ce-bf70-8154b931d41d", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAED0ksQpKlinexVN1QhpF7VzstZ44li3qfYsg2Figq20SJeuoXN9ndLDxO+TPJnZGqw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "ab0951cb-04e8-4328-82cc-9acdb0462c6c", 0, "b93e4f41-519a-426e-a888-8f744a5f8243", "jack.nicklefrost@hotmail.com", true, null, null, false, null, "JACK.NICKLEFROST@HOTMAIL.COM", "JACK NICKEFROST", "AQAAAAEAACcQAAAAEM91QZhZNGzul0vBxoL4Zo0H63JN7bykfBJGB1g8i9Gv5kUA3HtbfQEphxBpKH627Q==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jack nicklefrost" },
                    { "81ddac5e-0222-4341-b106-8b5857d2918f", 0, "2d48128c-beb9-4122-90dc-a2b2b13a3d0d", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAENFL91rz2T1rUEAMgLL+upi2va6vYboYcwhs9M7dRvT3Z8jYy+GFuqvyl+huSSyGYQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketsTeamMembers_UserId",
                table: "TicketsTeamMembers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketsTeamMembers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "089e3fda-7234-4e98-a6e1-65bc92a808f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43827923-9b27-4813-9310-a2059ce2955d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "476b13d7-0f9d-47e3-a9f8-f6b78884e5e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5866dbd5-d1a8-4d5c-954f-ab82e8024870");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58b71a6e-f7ef-462c-a866-309c7d90ef96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "975f19ac-2d76-4967-9adf-b6aecd536186");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec3083f8-6888-4933-a787-f7cac560b29b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1899ff-e159-4c8f-ab1c-7d828731f356");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19b1483b-58ab-4e23-9819-7b05365d104f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54391856-dd23-43fa-958e-b4ca84d9aa65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65d7121d-9ad2-4149-be59-9c7030a49725");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80f52789-f5c7-4718-8b49-bbe0174872ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81ddac5e-0222-4341-b106-8b5857d2918f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0951cb-04e8-4328-82cc-9acdb0462c6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c5641b-4656-4f5d-9982-38a8f938e697");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3307d5e4-7a78-46ff-bfb0-56875b3f9c6e", "de657428-bd77-430c-b228-af37a4bb8fb4", "Demo Submitter", "DEMO SUBMITTER" },
                    { "e5046d72-690f-4af4-b6cc-4b3b7820122a", "daf49f60-36b9-4983-8912-f8577c097e0d", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "23597478-5000-4f25-83e1-2b847e9c7aca", "e76af936-1b39-4c46-a69c-ad48f6b5e9f4", "Demo Admin", "DEMO_ADMIN" },
                    { "4d9e8140-8fcb-4286-baaf-47a70dcfa06b", "47dafe49-4e50-4baa-a539-0da0d7be7217", "Submitter", "SUBMITTER" },
                    { "39c7fec8-f948-4147-ac7e-0cf38c718616", "a9e652db-f4f8-4aae-bf32-9520521eabc6", "Developer", "DEVELOPER" },
                    { "43acc8bf-f213-4d2f-b4df-16c9ae25192a", "bd32ddfe-7cd7-4ee5-8b86-649e2b84ebf2", "Project Manager", "PROJECT MANAGER" },
                    { "271d538c-b8f7-4ba3-9312-2bdee713b28a", "42809aba-051d-44bd-a659-869f63ba4b94", "Admin", "ADMIN" },
                    { "675ccb0e-67c9-4b0d-9909-70666db8b0fd", "0861dcb5-6d33-4c01-a030-1d38be3b6d5e", "Demo Developer", "DEMO DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "914b1d35-ae93-480c-bed1-5bb7e1b04058", 0, "0ccacbcb-f41d-48ba-a70d-52b82fe0162f", "alice.cooper@hotmail.com", true, null, null, false, null, "ALICE.COOPER@HOTMAIL.COM", "ALICE COOPER", "AQAAAAEAACcQAAAAEAZXOjGf0gdqOZrgtBEE2fKIedijfZi8gq7vNWa/P0b2izOs4q/2aQWeIJzzhZOs1A==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Alice cooper" },
                    { "16d38986-452e-4e8b-9530-3ad68b3dbdeb", 0, "7881154a-c252-46f6-9ded-dfadf7f9bc25", "jane.doe@hotmail.com", true, null, null, false, null, "JANE.DOE@HOTMAIL.COM", "JANE DOE", "AQAAAAEAACcQAAAAEKIzQjljbFq25wlA/BudJLOe05gGazkAIIHx+19mxJGvvzh765PNHdsyRHZQMTMK2w==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jane doe" },
                    { "7680f0a4-f32b-4b88-86ff-074a312ff099", 0, "882ec4aa-6031-424c-9297-b621593a22eb", "john.doe@hotmail.com", true, null, null, false, null, "JOHN.DOE@HOTMAIL.COM", "JOHN DOE", "AQAAAAEAACcQAAAAEBBpIWP1skvzDCYC+TiBgqdRJ/rWoK/vLOSkjC5/AWj3bi4/weHXpuzKMvgDCGXGlQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "John doe" },
                    { "7f16b756-5ead-43a4-8afd-30337aa6e62f", 0, "d01bbe92-f3c7-4224-a6e3-8713d9f01ea2", "quentin.coui@hotmail.com", true, null, null, false, null, "QUENTIN.COUI@HOTMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEE6rv3B46vjdBhYCplPs5ObQX0cR0pObjKSwRDkBcBtkGHWtrSenF+Vpv8ErqEKYCw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Admin" },
                    { "1c0ad215-2e08-4bd4-88af-14625d1900e5", 0, "0ce7d825-c27a-4cb8-a689-ce9d51b74711", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAENND/dKZimPpLGr34eZwiNXL/iQecHBgqIgE+Pq/SlnP8iObQRPPICcE2WV0hXJ25A==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "8496466c-0496-44b9-b2a0-48e88d2eb986", 0, "141f6992-77a4-4b38-9ce8-7cc43fafbf23", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEF2WKOOp2MIi8HlFemV7SPHdoDDsxHXlNbyRi0xR093junipvrpdVXjN9ZbasV6Qbw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "96576522-0f45-4d29-ade2-da5ba3eae90f", 0, "41d8504d-250d-407d-b7a6-f56456569c8c", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEL33LdOQkywCLFtrxQu1UzCgwv+Gb1Tsld4bwCEGAZkDfhE6SnjXlbCSM/iqTzgFWg==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "b9c634ed-88a0-486a-a2ae-ba87e1865536", 0, "febc63cc-fb3c-462e-a8d7-6a53d2d0f716", "jack.nicklefrost@hotmail.com", true, null, null, false, null, "JACK.NICKLEFROST@HOTMAIL.COM", "JACK NICKEFROST", "AQAAAAEAACcQAAAAEIwOFbSMwHyM3UNz2eV9/q0YTcfpBgCqlw7u+BkuxlfcX8qhxAfqDlW8LQlZr1HKXg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jack nicklefrost" },
                    { "fc18dc97-f001-4f99-b74f-ceacdb91fc97", 0, "3eb40e1a-5ddb-4639-b3ef-a1ef3ae0cf50", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEOWONWVLOewwR6/yTZA+PLZImbpwdGsS1jjdLBSBD0eAiXzzy5oBEvdPbopjuTA/sw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });
        }
    }
}
