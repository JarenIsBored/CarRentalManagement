using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c3bf6568-ed70-409e-80b1-1811d407097c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBB4FL8pxfIH+BahI11+inu8Y/ZFFfSZA/s2i4oBILmb+UVZLC+Rt+e1+M00tlge4w==", null, false, "e26211a9-f8cb-4339-b951-8e1159681f41", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2709), new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2711), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2713), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2995), new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2996), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2999), new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(2999), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(3001), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 11, 25, 15, 44, 14, 393, DateTimeKind.Local).AddTicks(3003), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
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

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 15, 36, 2, 367, DateTimeKind.Local).AddTicks(312), new DateTime(2023, 11, 25, 15, 36, 2, 367, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 15, 36, 2, 367, DateTimeKind.Local).AddTicks(325), new DateTime(2023, 11, 25, 15, 36, 2, 367, DateTimeKind.Local).AddTicks(326) });
        }
    }
}
