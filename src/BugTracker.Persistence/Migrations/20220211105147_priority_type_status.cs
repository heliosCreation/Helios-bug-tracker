using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class priority_type_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d43b4f3-cf4c-497c-bc84-2f3e6351881e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "461f41d5-9c6c-4d27-a11f-a9bd66c1da86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "943bef04-4033-4206-b0d7-3c75517d552a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccf426f5-c344-40cb-ad59-ec468ef526b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d882544-b17a-44ca-893d-a1dec8d263bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33113608-2ce2-4da2-a77d-31294998d9fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4521ea1a-28b0-40c5-9416-b1c692b07061");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7deddea-55c8-4dd1-ab7f-a69841effbb5");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tickets");

            migrationBuilder.AddColumn<Guid>(
                name: "PriorityId",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StatusId",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Priority",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "86b6a1d3-d65f-4b79-9dc9-4d9c0aae5b79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "5c120876-1eab-4de9-9cda-9427a5ee5070");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "dbddad63-4318-49ff-ac71-d21a222adf65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "561c2388-ad80-4b13-9f65-13984b1350b3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b6c5506-564e-453b-9e49-beb94976a5ae", "65e32bb1-b2b9-4a7b-9a21-9d759c4a04de", "Demo Submitter", "DEMO SUBMITTER" },
                    { "88365a89-e0ae-4c96-8e63-d6b2f31e6148", "0ca520ff-70dd-4860-8fe7-3086c6d317fb", "Demo Developer", "DEMO DEVELOPER" },
                    { "d52e37c3-dad1-4276-9381-f10b0c144eb8", "9b2eca2d-4070-48a0-a0f6-cdaaa50eaff2", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "901690c8-9b09-4fb9-983f-6d1b709b984a", "a42f1040-e713-46de-8dd7-8cdf0a6d59db", "Demo Admin", "DEMO_ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e1cf084-230d-42cf-a73e-f116af831e66", "AQAAAAEAACcQAAAAEIBwtd0YWFhr0T+sl/fuuvHR3qLjgsaHf8prKvWXmFbKBdwJy3IN/a0H/+fwFY8jwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3900c6c2-88d4-47e5-b871-0861300f5abd", "AQAAAAEAACcQAAAAEICJ4DkrLOBFrybO8PIOBWwC118QYdX45/PoThe/IsMSmuzwr0UN2zDcFz8HCcAzxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "778219af-24a0-4150-82ba-bc6fe1faba67", "AQAAAAEAACcQAAAAEJ9XV7JZIyzwvrIg8S0YaAz2mx0T1nXELdhCBOtWR7ConCC6TeV6eIsP24xE1+fwvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31ddd8b8-25b2-4509-9925-9c7e800c699a", "AQAAAAEAACcQAAAAEJ3qFoAU+wN3Q6PiKDEVmxnViJsW4Yw+EmnNBq1ZSIIu80Pp9Bx7LKPmeZ1lj5TP3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c1a6904-06df-4ed6-b21b-d9130fd31bec", "AQAAAAEAACcQAAAAEJOv+X7HoFMUjhQ7rtD0ujwY/Kk6BT3O5MHi22hs8u7t+S72sHtuE4ogeLedvgOlvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c17e06d-daab-438c-9c2e-ff65abc29d12", "AQAAAAEAACcQAAAAEBsJ7hjPsHR0MKRr5+verT3KPcCyDdkF0fq3jTZi8l3CXA4ItrugbsFokdrG3b8J3Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8db2df9-1676-4ed2-81df-06a508dfafc6", "AQAAAAEAACcQAAAAEC2A/lJo2Kvp/IWhY7RLAstRe3VhHPFxEh7sXOeFkN78FxD4QzdYLt1Ue9JoNaFVeQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "34f678aa-8848-47a3-bf51-4b9c1293e040", 0, "59c8767a-9e6a-464a-93cf-76e9781fe448", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEG5E+SqT7GYjD7hQH9FkJYpTXSFvvYmmRGuYEJGgc+ji2KohBkDzCpzNuGrFobrjQA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "272cdd91-246d-458f-8432-aff13411c717", 0, "bf24ef2a-f88f-47a8-a9e9-470cc3a28c74", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEFekct9QH/s2fAUKWSVtpmtO8wKQEWJoZNNmzVOfOeeFheYoogVRfwxmIPx4TR/8dw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "1da9be2f-790f-4111-aff0-3e1c8522230f", 0, "b680c706-3a80-4b54-87ce-012dff26e852", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEORBLNV7kn9TivEUo2vv5jTOAH/sNLMvUWVS5s3cRLyLYVmdmljE4Nr/FNX4sKeySw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "edde5b8d-7b86-4969-8734-6b5e32642a60", 0, "efbffba6-c2da-453f-b764-18482c5ec4c6", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEAoOPaa28QjvPjONh7zZsrNcvcpkyWK+1oFiHkrsepsrWaPOvCM2YXk25ICJWoyMVA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d9694ec2-025c-4471-bf34-9d4be711a2f1"), "Immediate" },
                    { new Guid("3000c77c-167c-493b-a103-1bc951997b9f"), "High" },
                    { new Guid("a7a8def0-bdbb-4580-a9ce-8740c2959362"), "Medium" },
                    { new Guid("640358a7-5eae-4b36-80ca-109dfdd0e447"), "Low" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("63fc64ff-fce2-4104-843c-63d608bd4669"), "Resolved" },
                    { new Guid("9bc16b4a-4b6f-4757-bf59-6c6a758dbdf7"), "In progress" },
                    { new Guid("a6bd17f5-54cc-4e43-bcb6-17ce3f48dfd4"), "Open" },
                    { new Guid("ff4ff102-204c-435e-a1ad-86dc0d98b6f8"), "New" }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("15cd0f2e-fe26-4583-87dc-055b5c9781fa"), "Documentation" },
                    { new Guid("b12a717d-aff6-401f-8cea-b3a01c16b8d7"), "Training" },
                    { new Guid("40c0ef3f-ee74-4d0a-9c9e-9cfd784ae948"), "Feature request" },
                    { new Guid("29277290-3fa9-4b8c-b281-ca3d5520da8f"), "Bug - Error" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PriorityId",
                table: "Tickets",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TypeId",
                table: "Tickets",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Priority_PriorityId",
                table: "Tickets",
                column: "PriorityId",
                principalTable: "Priority",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Status_StatusId",
                table: "Tickets",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Type_TypeId",
                table: "Tickets",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Priority_PriorityId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Status_StatusId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Type_TypeId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PriorityId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TypeId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b6c5506-564e-453b-9e49-beb94976a5ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88365a89-e0ae-4c96-8e63-d6b2f31e6148");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "901690c8-9b09-4fb9-983f-6d1b709b984a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d52e37c3-dad1-4276-9381-f10b0c144eb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1da9be2f-790f-4111-aff0-3e1c8522230f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "272cdd91-246d-458f-8432-aff13411c717");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34f678aa-8848-47a3-bf51-4b9c1293e040");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edde5b8d-7b86-4969-8734-6b5e32642a60");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "Tickets",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Tickets",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Tickets",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "f5230756-98df-4545-a2e5-6df4797dac6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "59ee6f8f-01b3-4921-bdac-d78275c8acd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "fbb7e5af-2f10-47ef-b18b-bd4b0f2476b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "91267d5b-3ba3-4bf1-9a8d-06e0a45e1cd5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d43b4f3-cf4c-497c-bc84-2f3e6351881e", "28a4ccdd-69db-4249-8674-4caee4b8cbf9", "Demo Admin", "DEMO_ADMIN" },
                    { "461f41d5-9c6c-4d27-a11f-a9bd66c1da86", "5b9a569f-7038-42d4-a8b7-076b57d41550", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "943bef04-4033-4206-b0d7-3c75517d552a", "e8a146e0-ff27-41cf-a4df-b6dc320b7f9f", "Demo Developer", "DEMO DEVELOPER" },
                    { "ccf426f5-c344-40cb-ad59-ec468ef526b0", "9cee348a-0967-4bbb-bec0-f2c2a9194b7d", "Demo Submitter", "DEMO SUBMITTER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccbcd404-6dcf-4960-b483-2071368066eb", "AQAAAAEAACcQAAAAEL1t1FUrZZ/u7Jt0kzDXoFg5xY6K2zK0/lUxzeTmGeC5h42I0fLBlDtMzECX4e08GA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bf257ef-e05a-491d-ba4c-94d109d39f42", "AQAAAAEAACcQAAAAEDJW1ynfoG4k9LennONKBiUSKFW5d/0PsSWPNRdpubuIOmHjW3XIz0gi30yrXksFtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fc81fbb-3464-4560-8bf6-9d761405618c", "AQAAAAEAACcQAAAAEHccTeGpG5b2NDYi7mxz1RZMDY78TJmh7qUahw1mTWtoRnLF1+aEQ9VSJnWljdPr+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "282b898c-a051-4b75-8db0-4c0e160d47de", "AQAAAAEAACcQAAAAEKFce9cU/iU+rp/5C3U8BZ9isGR9Ul2NE53jjAFN/RDS6u2vYFrR2NCKUmE6vzdEjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5b765aa-2163-4446-8048-7f41907ab22f", "AQAAAAEAACcQAAAAEIh44B+tOtBgnY8lopMt1rZ+/map99NPI+GORmY0emK6rJGo55N3Ans0/JG0ggRYxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2398e0b0-ed2d-46cc-aef4-2234df1e6dd6", "AQAAAAEAACcQAAAAEIQeTGMbaqEbaUnAsQ8pslEOGpdbhFI514Ofa41+Ik9cfM7tWprkndjsEf/be0hvlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4517a2c8-f8d3-4a72-9df2-cbd0365d83cd", "AQAAAAEAACcQAAAAEAoFgOdZkH30FQrfrbT2t9DKv/ulACbjvUjal31iqAjiPi0shRifCaLUHWFJao24tw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c7deddea-55c8-4dd1-ab7f-a69841effbb5", 0, "3ca4dc2c-f21b-4c04-b461-28840c77fba6", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEOawT/p04zZVAsXaSnEhByM2HqH7pOs1R1TPhBrbBQyq69Xk0PpA9uEQreGcdc1Vug==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" },
                    { "0d882544-b17a-44ca-893d-a1dec8d263bd", 0, "aa107294-b518-4a11-ae1c-51e652d69e0d", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEMslX4e9ZszLnAqqo9hKG7LtB/BSZcc/Ft+31aWgFI1zwrvh6XYLbVz/ZfN8eH2XUQ==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "4521ea1a-28b0-40c5-9416-b1c692b07061", 0, "12ff272f-81c0-48bc-ac20-3153e9342ced", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEKyW0uQORHprLlwAYsjGAcVxH89zLBeph03gp+mMGZf8uJjar/7lcrAsw68J0lZvOg==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "33113608-2ce2-4da2-a77d-31294998d9fa", 0, "321966b4-cc40-46fa-a1b8-b6ef054166bc", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEKDZWevQWIvqW96CkSt3OFJTzdnNj+BwFfv3Sv2KPNbQDmzH7qqtzCEVh2qQsWEYRQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" }
                });
        }
    }
}
