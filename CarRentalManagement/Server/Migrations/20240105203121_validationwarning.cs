using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class validationwarning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "143a6c1e-b9b7-4baf-b680-5c47e7b9abc5", "AQAAAAIAAYagAAAAEAaBcz4qi7SUWygSuJxhUIo7mQyLsCwij/eLTWTml7rTosHDKtHVWRiAjm3hivwI7g==", "f544ed07-b2c0-4975-afb7-45cd2d0167f5" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 4, 31, 20, 709, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 1, 6, 4, 31, 20, 709, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 4, 31, 20, 709, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 1, 6, 4, 31, 20, 709, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1106), new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1117), new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1636), new DateTime(2024, 1, 6, 4, 31, 20, 710, DateTimeKind.Local).AddTicks(1637) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0119451-1312-43f2-ae48-ebe307783951", "AQAAAAIAAYagAAAAEATVNanm6iStab8rsdQMy1pnFaNf5rb1dMwBalv/7fq/z5mRPdPD/T1NZrE6lRDzOQ==", "1934a43b-6dfc-401f-8a45-2d6f3d649a2f" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(2209), new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(2954), new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(3270), new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(3274), new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(3278), new DateTime(2024, 1, 6, 3, 48, 10, 986, DateTimeKind.Local).AddTicks(3279) });
        }
    }
}
