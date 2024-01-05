using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedb_cust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da2adb01-c802-4c70-bce4-7c61e58263a9", "AQAAAAIAAYagAAAAEKrcVbBXTHmw8SI2mxO12+IKUsq/uKrUDiZFJDXFiV7Bsietb8yEE6SCd56cluBVkQ==", "734d448e-502b-4c28-af67-efb33f236be5" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(6982), new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(7629), new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(7640), new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 1, 5, 9, 30, 24, 222, DateTimeKind.Local).AddTicks(7645) });
        }
    }
}
