using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "39187fce-60ab-454c-9d1d-1ab8663ccb70", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "3e48d077-1086-413c-88e0-31ded54bacfe", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "4a9d4c7f-c4e0-4c5e-b706-b53fc1016199", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELga78EUWKrOfn6o1pZrkpXzWGDcGHNxiRxJOWE6p3g1wQ+ZdoQgWH5FEb75JiaixA==", null, false, "35ed7a2b-e9f7-4109-89ae-94ccf2d389f3", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "da556316-c746-4ff6-a45b-83ddcb1e26db", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIWKFT4QKr91t5XtqdrKGvEoi61b5o8F55Rp//NnhB2Ql7mdVLVZvZdQtFiXPOSF3g==", null, false, "8c69209c-3a44-4382-8dff-37792c20adc1", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 9, 6, 17, 43, 32, 656, DateTimeKind.Local).AddTicks(8599), new DateTime(2021, 9, 6, 17, 43, 32, 657, DateTimeKind.Local).AddTicks(1601), "Black", "System" },
                    { 2, "System", new DateTime(2021, 9, 6, 17, 43, 32, 657, DateTimeKind.Local).AddTicks(2363), new DateTime(2021, 9, 6, 17, 43, 32, 657, DateTimeKind.Local).AddTicks(2368), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(959), new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(964), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(1241), new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(1244), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(3878), new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(3884), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(4156), new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(4160), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(4161), new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(4162), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(4163), new DateTime(2021, 9, 6, 17, 43, 32, 658, DateTimeKind.Local).AddTicks(4164), "X5", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
