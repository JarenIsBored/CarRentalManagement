using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class bookingnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ef60ed9-bd36-4554-82c6-94e5635bca62", "AQAAAAIAAYagAAAAEMoja/NUX7VNy3Y3JvPZTD3OJgidPchG7/OpIJc0x3vDoehXCXn0dmJP5Gm7aiIqZQ==", "26b0b90b-6a02-4614-b701-edc9d36b8427" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(6497), new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(6523), new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(7768), new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(7773), new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(7779), new DateTime(2024, 1, 5, 15, 38, 37, 35, DateTimeKind.Local).AddTicks(7780) });
        }
    }
}
