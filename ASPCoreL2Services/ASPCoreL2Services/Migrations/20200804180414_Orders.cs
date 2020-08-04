using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCoreL2Services.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(nullable: true),
                    Server = table.Column<string>(nullable: true),
                    Service = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 8, 4, 18, 4, 14, 138, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Subpreview" },
                values: new object[] { new DateTime(2020, 8, 4, 18, 4, 14, 138, DateTimeKind.Utc).AddTicks(2952), "/images/endgame1.jpg, /images/endgame2.jpg, /images/endgame3.jpg" });

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 8, 4, 18, 4, 14, 138, DateTimeKind.Utc).AddTicks(2966));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Subpreview" },
                values: new object[] { new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4556), "images/endgame1.jpg, images/endgame2.jpg, images/endgame3.jpg" });

            migrationBuilder.UpdateData(
                table: "DBEntityBase",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 7, 28, 18, 35, 57, 706, DateTimeKind.Utc).AddTicks(4569));
        }
    }
}
