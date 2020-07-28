using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCoreL2Services.Migrations
{
    public partial class decToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "DBEntityBase",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Price" },
                values: new object[] { new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4199), 6.0 });

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Price" },
                values: new object[] { new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4556), 6.0 });

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Price" },
                values: new object[] { new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4569), 6.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "DBEntityBase",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Price" },
                values: new object[] { new DateTime(2020, 7, 28, 18, 34, 30, 991, DateTimeKind.Utc).AddTicks(4728), 6m });

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Price" },
                values: new object[] { new DateTime(2020, 7, 28, 18, 34, 30, 991, DateTimeKind.Utc).AddTicks(5106), 6m });

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "Price" },
                values: new object[] { new DateTime(2020, 7, 28, 18, 34, 30, 991, DateTimeKind.Utc).AddTicks(5121), 6m });
        }
    }
}
