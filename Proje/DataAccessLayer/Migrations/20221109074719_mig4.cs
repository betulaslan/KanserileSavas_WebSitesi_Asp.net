using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detays",
                columns: table => new
                {
                    DetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yazı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnaSayfaID = table.Column<int>(type: "int", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detays");
        }
    }
}
