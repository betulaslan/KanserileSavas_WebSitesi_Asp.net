using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detays");

            migrationBuilder.CreateTable(
                name: "yonetimUyes",
                columns: table => new
                {
                    YonetimUyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yonetimUyes", x => x.YonetimUyeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "yonetimUyes");

            migrationBuilder.CreateTable(
                name: "Detays",
                columns: table => new
                {
                    DetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnaSayfaID = table.Column<int>(type: "int", nullable: false),
                    CommentUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yazı = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detays", x => x.DetayID);
                    table.ForeignKey(
                        name: "FK_Detays_AnaSayfas_AnaSayfaID",
                        column: x => x.AnaSayfaID,
                        principalTable: "AnaSayfas",
                        principalColumn: "AnaSayfaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detays_AnaSayfaID",
                table: "Detays",
                column: "AnaSayfaID");
        }
    }
}
