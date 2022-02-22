using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class AddedOrderToTicktConf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("3000c77c-167c-493b-a103-1bc951997b9f"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("640358a7-5eae-4b36-80ca-109dfdd0e447"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("a7a8def0-bdbb-4580-a9ce-8740c2959362"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("d9694ec2-025c-4471-bf34-9d4be711a2f1"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("63fc64ff-fce2-4104-843c-63d608bd4669"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("9bc16b4a-4b6f-4757-bf59-6c6a758dbdf7"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("a6bd17f5-54cc-4e43-bcb6-17ce3f48dfd4"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("ff4ff102-204c-435e-a1ad-86dc0d98b6f8"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("15cd0f2e-fe26-4583-87dc-055b5c9781fa"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("29277290-3fa9-4b8c-b281-ca3d5520da8f"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("40c0ef3f-ee74-4d0a-9c9e-9cfd784ae948"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("b12a717d-aff6-401f-8cea-b3a01c16b8d7"));

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Type",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Status",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Priority",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                column: "ConcurrencyStamp",
                value: "c41042b5-3aa8-4798-8622-4d98f91c4f73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdee224-4d18-482a-b084-e54fa1788095",
                column: "ConcurrencyStamp",
                value: "033bd718-1cdf-40e0-88d3-28b89a4d6729");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8006e3-e50a-49be-94ea-03ab653713cc",
                column: "ConcurrencyStamp",
                value: "b2c27a86-a5f2-4ae3-8cb7-937734ca5b20");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                column: "ConcurrencyStamp",
                value: "46bbd5f6-7cf0-43d0-8215-65784b0ef168");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9bd1e1c6-cf7d-4e37-9c77-31335d2e6240", "018fa83f-2521-452c-aa4c-0d36f73db11f", "Demo Submitter", "DEMO SUBMITTER" },
                    { "6ba0d9e1-48de-4582-be09-c1f3ce525e1d", "154edf37-6f13-4d6a-8142-8718f16ff6f7", "Demo Developer", "DEMO DEVELOPER" },
                    { "73478721-2e5f-43af-a968-21cee5e260b9", "10e11b92-4e6d-480c-9ebd-3c5b1aca92c3", " Demo Project Manager", "DEMO PROJECT MANAGER" },
                    { "6e5e8cb5-cae5-4c17-ae0a-e187fad15e63", "5665559d-198f-427d-94a5-2e245e629930", "Demo Admin", "DEMO_ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82aa4949-25aa-4237-9fd0-a1f220a7c86d", "AQAAAAEAACcQAAAAEBCoiC3mq4oU0g05jlggbKpwwiVMR5KwnzGDo7YswWFqPszLMhKpafPnZEpAmQ6qwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355daad8-1cb5-4caa-8538-e82508b5248a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db3e77be-de11-4b13-8f38-3cc0e10cd42a", "AQAAAAEAACcQAAAAEOqo8Toir6tTpYkPmnLsXltlaWDQY++orVRB58JzZGMLZXKw2RBVkKLbyuY42zx9Tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68f84753-8203-45a0-ac1e-b2a06411d49a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "258fc59b-8d18-4e5a-93c7-3697b6b22d9b", "AQAAAAEAACcQAAAAEMI0DGKtmCKISsRskWjLQmOwijKuf4886Uif9JZaQdsc5WNBgGciudGHF6+xSAjX8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a7f75b5-babe-4769-b9da-6157c4822ae2", "AQAAAAEAACcQAAAAEJx/pAYyz7jyjheZh3hvFWXx0AYeqRtHSnEnKQk/kOnqS0QgefbjD3KZayS2CCdoBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5faeb7f9-0b2e-407f-bdc4-2eedc0f59731", "AQAAAAEAACcQAAAAEHiShbk/4lQPv13creW3rYyk0pV+IfkFYVkq/pskFrCN7JPVca4GQcwauiz7lAZRNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08f153ea-8201-4dfc-bc26-c6db297e9c8c", "AQAAAAEAACcQAAAAEHwZo0Z/n0ihaq1vdFSYMkyL8/bUkKvRlYgg/u995Eg//klP3tqteB+jCT/jEY3N0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df656ced-7b29-4504-baeb-60d628c56739",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1535a32b-7206-4237-94df-12344391eea5", "AQAAAAEAACcQAAAAEDfq7fgScI0G/QZWbcRmLoJ73gQocL0SYjE6PqoGBviWc6Ztw2MAEaoWkyrvkBF1iA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14ef30c4-70d0-44cd-82b6-4f9995f1336b", 0, "b3d7a847-4b86-4508-8d88-619a29fdab0c", "demoPM@gmail.com", true, null, null, false, null, "DEMOPM@GMAIL.COM", "DEMO PROJECT MANAGER", "AQAAAAEAACcQAAAAEM0D/qMDaNBY+OcFiyBPHaQG2fu7ebYlCRtgSh3PW7ghIdL/APxViHmcIl8lQZ+AvA==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo Project Manager" },
                    { "29dca70a-75e6-4788-a789-ed7708f1aece", 0, "8a94d830-6e26-439d-af41-75370721f93b", "DemoDev@gmail.com", true, null, null, false, null, "DEMODEV@GMAIL.COM", "DEMO DEVELOPER", "AQAAAAEAACcQAAAAEDK9M17zQv9LXF/mwkCfB5ipI+zxIEYQC0LT+Kb9GKxK802GVsIX8c8+xNvvRf6Ltg==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo developer" },
                    { "02c8c712-e7a8-4d64-957e-65b8210c22b0", 0, "fb9eb87f-1dd8-41bf-819b-1b3376b09c35", "DemoAdmin@Admin.com", true, null, null, false, null, "DEMOADMIN@ADMIN.COM", "DEMO ADMIN", "AQAAAAEAACcQAAAAEBcNjpyJtNY2eO/sSwYnzOqWBkiRhUTERKcORovgz3DQiovBINFUE40elKAzvyVtKg==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Demo Admin" },
                    { "79f6b77b-eb72-4ac3-99b9-fdba237466d6", 0, "c826b019-b266-4195-90b6-82951691990f", "john@gmail.com", true, null, null, false, null, "JOHN@GMAIL.COM", "DEMO SUBMITTER", "AQAAAAEAACcQAAAAEGuyMjKT/snbdKrW9e4qvveBjj/qBTrjqIIEKx65SteIwJZrrM9BWOztwClGrFQXHw==", null, true, "00000000-0000-0000-0000-000000000000", false, "Demo submitter" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("b1f140fa-3915-49d5-adfa-904a8ea51581"), "Immediate", 4 },
                    { new Guid("d4e7cb56-9986-49a1-84ee-ff7907b6b0e5"), "High", 3 },
                    { new Guid("3e0d86a0-a726-4f9f-9e5c-7ff4298819a5"), "Medium", 2 },
                    { new Guid("a5981e9b-7239-454b-b497-0decc8661162"), "Low", 1 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("7afcd8a1-1804-4b3a-87be-6c62b98c0934"), "Resolved", 4 },
                    { new Guid("70738404-9e63-4629-86e0-cd106e4452a9"), "In progress", 3 },
                    { new Guid("7854cc26-6713-4413-a5b6-cce3e56c84ed"), "Open", 2 },
                    { new Guid("47d65e34-820a-465e-99d5-f065016e577f"), "New", 1 }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("0295ac2f-81c8-4bcd-87b4-d225e316d3cc"), "Documentation", 4 },
                    { new Guid("5567acf7-a108-4f64-8a6b-7ce1429e70c8"), "Training", 3 },
                    { new Guid("e6e67cff-a7b9-4456-9ff1-e7b385f069dd"), "Feature request", 2 },
                    { new Guid("25d13134-0282-4bf8-83f0-95f53d8a6942"), "Bug - Error", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ba0d9e1-48de-4582-be09-c1f3ce525e1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e5e8cb5-cae5-4c17-ae0a-e187fad15e63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73478721-2e5f-43af-a968-21cee5e260b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bd1e1c6-cf7d-4e37-9c77-31335d2e6240");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02c8c712-e7a8-4d64-957e-65b8210c22b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14ef30c4-70d0-44cd-82b6-4f9995f1336b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29dca70a-75e6-4788-a789-ed7708f1aece");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79f6b77b-eb72-4ac3-99b9-fdba237466d6");

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("3e0d86a0-a726-4f9f-9e5c-7ff4298819a5"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("a5981e9b-7239-454b-b497-0decc8661162"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("b1f140fa-3915-49d5-adfa-904a8ea51581"));

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: new Guid("d4e7cb56-9986-49a1-84ee-ff7907b6b0e5"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("47d65e34-820a-465e-99d5-f065016e577f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("70738404-9e63-4629-86e0-cd106e4452a9"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("7854cc26-6713-4413-a5b6-cce3e56c84ed"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("7afcd8a1-1804-4b3a-87be-6c62b98c0934"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("0295ac2f-81c8-4bcd-87b4-d225e316d3cc"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("25d13134-0282-4bf8-83f0-95f53d8a6942"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("5567acf7-a108-4f64-8a6b-7ce1429e70c8"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("e6e67cff-a7b9-4456-9ff1-e7b385f069dd"));

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Type");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Priority");

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
        }
    }
}
