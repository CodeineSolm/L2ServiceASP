using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCoreL2Services.Migrations
{
    public partial class _Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBEntityBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Preview = table.Column<string>(nullable: true),
                    Subpreview = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDiscription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBEntityBase", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DBEntityBase",
                columns: new[] { "Id", "DateAdded", "Description", "MetaDiscription", "MetaKeywords", "MetaTitle", "Preview", "Price", "Subpreview", "Subtitle", "Title" },
                values: new object[] { 1, new DateTime(2020, 7, 28, 18, 34, 30, 991, DateTimeKind.Utc).AddTicks(4728), "Buy adena instantly, we have unlimited amount of gold.", null, null, null, "images/adena.jpg", 6m, "images/equip1.jpg, images/equip2.jpg, images/equip3.jpg", "Equip your character fast to compete", "Adena" });

            migrationBuilder.InsertData(
                table: "DBEntityBase",
                columns: new[] { "Id", "DateAdded", "Description", "MetaDiscription", "MetaKeywords", "MetaTitle", "Preview", "Price", "Subpreview", "Subtitle", "Title" },
                values: new object[] { 2, new DateTime(2020, 7, 28, 18, 34, 30, 991, DateTimeKind.Utc).AddTicks(5106), "Fastest exp u ever seen.", null, null, null, "images/exp.jpg", 6m, "images/endgame1.jpg, images/endgame2.jpg, images/endgame3.jpg", "You need high level for endgame.", "Experience" });

            migrationBuilder.InsertData(
                table: "DBEntityBase",
                columns: new[] { "Id", "DateAdded", "Description", "MetaDiscription", "MetaKeywords", "MetaTitle", "Preview", "Price", "Subpreview", "Subtitle", "Title" },
                values: new object[] { 3, new DateTime(2020, 7, 28, 18, 34, 30, 991, DateTimeKind.Utc).AddTicks(5121), "40k, 80k, 100k mobs is boring.", null, null, null, "images/quests.jpg", 6m, "images/quest1.jpg, images/quest2.jpg, images/quest3.jpg", "If u dont have time to do quests", "Quests" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBEntityBase");
        }
    }
}
