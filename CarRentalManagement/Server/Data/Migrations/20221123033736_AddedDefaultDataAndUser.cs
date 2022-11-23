using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3b7cb915-8305-4a1f-9d2c-81cade5595d0", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "9312ebb0-799f-4b9c-8d7c-8cc89da30d2e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "293ad891-ccd4-4dbf-9784-0199cecae02c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEClH5vOMiOoOCp4DBgCTbBRUkrm2gkKbUosWnoeI5kOqLxLEAzv1s0BhJUhbwqrLoA==", null, false, "aec9c323-9b3b-40c0-9470-50b216b6d9b1", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 23, 11, 37, 35, 651, DateTimeKind.Local).AddTicks(2108), new DateTime(2022, 11, 23, 11, 37, 35, 652, DateTimeKind.Local).AddTicks(5783), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 23, 11, 37, 35, 652, DateTimeKind.Local).AddTicks(6928), new DateTime(2022, 11, 23, 11, 37, 35, 652, DateTimeKind.Local).AddTicks(6933), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 23, 11, 37, 35, 654, DateTimeKind.Local).AddTicks(5083), new DateTime(2022, 11, 23, 11, 37, 35, 654, DateTimeKind.Local).AddTicks(5095), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 23, 11, 37, 35, 654, DateTimeKind.Local).AddTicks(5100), new DateTime(2022, 11, 23, 11, 37, 35, 654, DateTimeKind.Local).AddTicks(5102), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 23, 11, 37, 35, 655, DateTimeKind.Local).AddTicks(551), new DateTime(2022, 11, 23, 11, 37, 35, 655, DateTimeKind.Local).AddTicks(562), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 23, 11, 37, 35, 655, DateTimeKind.Local).AddTicks(567), new DateTime(2022, 11, 23, 11, 37, 35, 655, DateTimeKind.Local).AddTicks(568), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 23, 11, 37, 35, 655, DateTimeKind.Local).AddTicks(571), new DateTime(2022, 11, 23, 11, 37, 35, 655, DateTimeKind.Local).AddTicks(573), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 23, 11, 37, 35, 655, DateTimeKind.Local).AddTicks(575), new DateTime(2022, 11, 23, 11, 37, 35, 655, DateTimeKind.Local).AddTicks(577), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

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
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
