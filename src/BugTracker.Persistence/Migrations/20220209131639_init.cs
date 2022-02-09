using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedAmountOfHours = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { "69d47cc8-79a3-4601-8183-2fd8a4326f72", "bd39a6f6-89b8-44c2-b403-5cf619b537d0", "Demo Submitter", "DEMO SUBMITTER" },
                    { "e70ac21e-7c3e-491a-aa84-9e8e9cc726aa", "6dd6846f-f589-4a7b-ba39-99e47d570419", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "0edcc443-328a-457e-ab6a-63e7d16651c1", "8aeb5dbc-48ea-4032-9685-013ee55ae0e1", "Demo Admin", "DEMO_ADMIN" },
                    { "6cdee224-4d18-482a-b084-e54fa1788095", "2bb41198-53e4-4a8b-b24b-e6435be5cc7a", "Submitter", "SUBMITTER" },
                    { "04614fbc-b0b7-4344-a2e9-8046742ac7cb", "70bb5116-85d0-480e-8c79-950126cd0138", "Developer", "DEVELOPER" },
                    { "6e8006e3-e50a-49be-94ea-03ab653713cc", "f25e405f-ce30-405d-a8e4-83f01445b29a", "Project Manager", "PROJECT MANAGER" },
                    { "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65", "f1ec8df9-4d4c-4c53-8ca2-fd2c30b5083e", "Admin", "ADMIN" },
                    { "775b167f-8c45-4e57-8b77-42a307d8d40a", "5120f684-8223-4f67-bb08-fd9a81f8b3f8", "Demo Developer", "DEMO DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "df656ced-7b29-4504-baeb-60d628c56739", 0, "354f5bff-41e0-4db0-8f62-16092de58423", "dean.moriarty@hotmail.com", true, null, null, false, null, "DEAN.MORIARTY@HOTMAIL.COM", "DEAN MORIARTY", "AQAAAAEAACcQAAAAEJfiKY0Pmbejf9CqH9vefu46BSGEaztE9Eb4XYHhNjQsfn56HSdCee7By1nyTAqytg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Dean Moriarty" },
                    { "b964514f-fc0c-47f2-b16b-dfd7cbf8c167", 0, "bf76bcac-796d-4228-adcd-447d74e7b042", "alice.cooper@hotmail.com", true, null, null, false, null, "ALICE.COOPER@HOTMAIL.COM", "ALICE COOPER", "AQAAAAEAACcQAAAAECMe/Z1DLgFin6o06bKZTPBr8kI1WvLTq5l8c182yEF0T71cotnHtve4B80OxLhO7g==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Alice cooper" },
                    { "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63", 0, "a0365a46-72cb-4e3b-95f7-169df26941a7", "jack.nicklefrost@hotmail.com", true, null, null, false, null, "JACK.NICKLEFROST@HOTMAIL.COM", "JACK NICKEFROST", "AQAAAAEAACcQAAAAEKLju+XNIdZEFcyeAQ+XjtQ6VekZ3NfFwf+IIP4WKNepuObnAoJ9EbP+6S4u1kLwHg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jack nicklefrost" },
                    { "c31a5e3d-a2ef-4065-a12c-2f9647f24070", 0, "c8471381-93f4-4f2a-9ee7-043678fc8b6c", "jane.doe@hotmail.com", true, null, null, false, null, "JANE.DOE@HOTMAIL.COM", "JANE DOE", "AQAAAAEAACcQAAAAEPn/Kd+fSvjE17SJMVytyNew0ec7rDVTMPusQYa00Mj0ql5nRByUfpup0x0UImD5dg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Jane doe" },
                    { "355daad8-1cb5-4caa-8538-e82508b5248a", 0, "f8d21ea8-9bd0-4986-bb88-4d864331d52f", "john.doe@hotmail.com", true, null, null, false, null, "JOHN.DOE@HOTMAIL.COM", "JOHN DOE", "AQAAAAEAACcQAAAAEGG09sQ32SpJyzdWhUu//rR47tX3raT3UfXPn7hYNM5R34Tj/1tNLa+arxxDiOrmKA==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "John doe" },
                    { "21bbccc8-fc2a-4881-b746-ed9d90fbff9b", 0, "8213b02c-8cce-4f8e-86f5-39ecc66c0ce6", "quentin.coui@hotmail.com", true, null, null, false, null, "QUENTIN.COUI@HOTMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEPnhTljdIyAShE2bj9Ey+aCHYI4DcTWN7o8mG4nRzVYyC9Lo0f9S8KRuCI7pFnrV2g==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Admin" },
                    { "1aaf3589-9535-4af6-b0c0-58fa0d043b70", 0, "fbdf1a3b-f2a9-4912-8094-8395b173da9c", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAENIrh5G84HrXxmzTZvc4LV+trzi2Y4JyEdOiH4bqMI3kMb5gKFXVE8V+p0Tpalk0Gw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "09945c60-db72-43b0-b5e9-83e5c58a0930", 0, "a5338781-fa2e-4e1b-bfd1-e2d75387970e", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEM75vKbqn1CU2U8r3/tJ64KlsWMI3vDiTdmtSVMruxf8pilQgRyL2CWM/Qx+JajWsw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "fd44e26a-adb7-418f-b3d5-0cc50016537f", 0, "cfd0af7b-b251-42e8-9cea-f10b0dd171d2", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEHA7VuEg0HEtvP+6O4FGX6LIWCPdoiIjBUzLfvCc0zcmt/HCGk/hsvTja+aUUft5Ug==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "68f84753-8203-45a0-ac1e-b2a06411d49a", 0, "19887ac5-baa7-49b1-ae05-b6f66aafefcd", "hanna.steinbeck@hotmail.com", true, null, null, false, null, "HANNA.STEINBECK@HOTMAIL.COM", "HANNA STEINBECK", "AQAAAAEAACcQAAAAEAhROO+RBoBEd6pU0W/jmEZfpchMXhPzqa/HdkuaJTMQSchBXrm1CmPWXunqH0RoIQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Hanna steinbeck" },
                    { "75097cf6-771d-4303-b75a-0c8f94938a92", 0, "08199328-9e01-40e1-ac9c-cd7e0fb1c2a1", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEDsYtElxLoAQvwPqozqWC1nNSqezsgno7gGg1BGIh66CY6WssjlKS68J/AB6BN7itQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProjectId",
                table: "Comments",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamMembers_UserId",
                table: "ProjectTeamMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ApplicationUserId",
                table: "Tickets",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProjectId",
                table: "Tickets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketsTeamMembers_UserId",
                table: "TicketsTeamMembers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ProjectTeamMembers");

            migrationBuilder.DropTable(
                name: "TicketsTeamMembers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
