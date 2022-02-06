using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class projectTweak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserProject");

            migrationBuilder.DropTable(
                name: "ApplicationUserTicket");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e798ffa-7fa8-4e1b-bc49-b0a76f3fa421");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29988be7-9501-4429-8b05-5c6102c68742");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "506037ee-697f-4b55-b4ca-cb9bf226902a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fcac0df-b6a9-46d5-8c96-259e169f9d10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538a649-7957-44d1-b783-920b3ccbcc93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8ddc5ce-856f-4464-898a-407f6add02f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5488c61-c6c0-46b5-9ec9-7e0ff3a350d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f59a635a-ae1a-47b7-9ed8-0e9f303080db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f5066c7-c502-4048-8438-d725dc55d4db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291508f3-6656-4ff2-b801-bcd405792b62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cfddd63-424e-46ad-b202-1fd94269cefe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "805ea1cb-3a0a-4076-85f8-8bc8ac6070e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ca59f42-0405-4e45-9ef9-c1f92e648ef6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b86afb1d-e945-4a29-91ce-7a82e4b4d757");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4aec3eb-4ad5-44de-8d3c-d2338813caee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d475f214-2fc4-4244-a3e0-06bf62b6fd65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e91815a6-5c63-45e1-950c-3410daeeb13d");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectTeamMembers",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTeamMembers", x => new { x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ProjectTeamMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTeamMembers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ApplicationUserId",
                table: "Tickets",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamMembers_UserId",
                table: "ProjectTeamMembers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_ApplicationUserId",
                table: "Tickets",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_ApplicationUserId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ProjectTeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ApplicationUserId",
                table: "Tickets");

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

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Tickets");

            migrationBuilder.CreateTable(
                name: "ApplicationUserProject",
                columns: table => new
                {
                    ProjectsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProject", x => new { x.ProjectsId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserProject_AspNetUsers_TeamId",
                        column: x => x.TeamId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserTicket",
                columns: table => new
                {
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TicketsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserTicket", x => new { x.TeamId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserTicket_AspNetUsers_TeamId",
                        column: x => x.TeamId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a8ddc5ce-856f-4464-898a-407f6add02f9", "a25386b2-97f3-4930-a24a-be529366ff24", "Demo Submitter", "DEMO SUBMITTER" },
                    { "b5488c61-c6c0-46b5-9ec9-7e0ff3a350d7", "9ab07f0c-ebea-4cd5-b3bf-56100e4a10bc", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "506037ee-697f-4b55-b4ca-cb9bf226902a", "d052b974-6ed8-4ed8-8485-8d2f6383c83c", "Demo Admin", "DEMO_ADMIN" },
                    { "5fcac0df-b6a9-46d5-8c96-259e169f9d10", "afda2c5d-1b94-44e0-9518-d5a55dd86dea", "Submitter", "SUBMITTER" },
                    { "29988be7-9501-4429-8b05-5c6102c68742", "c89d2621-adcb-4e9e-a6dc-8edc540dd49e", "Developer", "DEVELOPER" },
                    { "f59a635a-ae1a-47b7-9ed8-0e9f303080db", "ff0194b0-e7ef-4f6b-876b-59c15d62e5c1", "Project Manager", "PROJECT MANAGER" },
                    { "8538a649-7957-44d1-b783-920b3ccbcc93", "5c0cf457-acc2-4a08-b46c-808ac3ecda86", "Admin", "ADMIN" },
                    { "1e798ffa-7fa8-4e1b-bc49-b0a76f3fa421", "fdefbcee-a4b4-4ff0-acf5-38d410acc01c", "Demo Developer", "DEMO DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f5066c7-c502-4048-8438-d725dc55d4db", 0, "9f403623-dfb9-46d1-a460-9d60efc6bc6b", "alice.cooper@hotmail.com", true, null, null, false, null, "ALICE.COOPER@HOTMAIL.COM", "ALICE COOPER", "AQAAAAEAACcQAAAAEC6xvmbj7IjhgHqd6MbuOI2oAw1vvIH2EKG80L7hr0o9G2mMoZrLhjyPV6ihx0QfPQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Alice cooper" },
                    { "d475f214-2fc4-4244-a3e0-06bf62b6fd65", 0, "94fdb525-4f51-4885-924a-911a3fc4ace9", "jane.doe@hotmail.com", true, null, null, false, null, "JANE.DOE@HOTMAIL.COM", "JANE DOE", "AQAAAAEAACcQAAAAEIBVNKtS1ZYrYhGqFLMmfT/JWun+CPLx9l2pFX09GjV71mK5SFUui/pO14VLsK6L1w==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jane doe" },
                    { "291508f3-6656-4ff2-b801-bcd405792b62", 0, "e578f08c-ef7b-4daa-bc53-f103194a782b", "john.doe@hotmail.com", true, null, null, false, null, "JOHN.DOE@HOTMAIL.COM", "JOHN DOE", "AQAAAAEAACcQAAAAEKNLKgp0D389p4NwqjrMZx+pBJVOvo8ZA0Xk69ybCE1K3ca9RXMzc0cCYGwfa+qcnA==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "John doe" },
                    { "5cfddd63-424e-46ad-b202-1fd94269cefe", 0, "24f18718-e99d-4ab9-a13e-d40b533032c1", "quentin.coui@hotmail.com", true, null, null, false, null, "QUENTIN.COUI@HOTMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJb/fdEtxa0skd6iu7PqmbcGY5o24HuKuJSvQOaWQEHH2bTND7bay4JSZ9cMLrDfAw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Admin" },
                    { "b86afb1d-e945-4a29-91ce-7a82e4b4d757", 0, "50e97083-ca95-4c20-8845-cb16d48d6591", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEIA0G/juKjAziPIGSUjJ8VPbC6d0D57oxghLBe1wTCPvXhcYREjQv6PipPAVblnQPw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "c4aec3eb-4ad5-44de-8d3c-d2338813caee", 0, "cb8372c8-4664-4bb2-9e9a-d9ce24264c7b", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEMq0LyNpG2vXH9YfolrdQWIyF1D+kzT2Qtqh9IZNecpVpS4PhMdIuleQmXidPp+tzQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "8ca59f42-0405-4e45-9ef9-c1f92e648ef6", 0, "f6a1d908-1d85-4eea-9aea-5b04630d49eb", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEDVj2pP8giK2drUHxIOw2RFpFP1vrZFuA/LqLXfbDXid8Bb2i4A954ZcF2kKe8axYA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "e91815a6-5c63-45e1-950c-3410daeeb13d", 0, "1faba3f3-28ad-4154-b040-5caefe81e91e", "jack.nicklefrost@hotmail.com", true, null, null, false, null, "JACK.NICKLEFROST@HOTMAIL.COM", "JACK NICKEFROST", "AQAAAAEAACcQAAAAENuXgZ9L6bHiLYGB231wc1Beh+OlvJ7eH9YRjUo/MJeRA4MWdL0+o0jCBNqzyRT7Xg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jack nicklefrost" },
                    { "805ea1cb-3a0a-4076-85f8-8bc8ac6070e3", 0, "9e7e2955-bc0e-4d1d-a18d-ea6430b9c6c8", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEDJ2GE+JvKHzLfHDwH8HcaZsXDlHcO1nCM6YCWsH/BOwDcbJztafaEXVZP/eR5HUhQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProject_TeamId",
                table: "ApplicationUserProject",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserTicket_TicketsId",
                table: "ApplicationUserTicket",
                column: "TicketsId");
        }
    }
}
