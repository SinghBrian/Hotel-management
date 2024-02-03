using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_management.Migrations
{
    public partial class remainingtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatutId",
                table: "Facture",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Chambre",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxPersonne = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoriesId);
                });

            migrationBuilder.CreateTable(
                name: "Statuts",
                columns: table => new
                {
                    StatutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuts", x => x.StatutId);
                });

            migrationBuilder.CreateTable(
                name: "Tarifss",
                columns: table => new
                {
                    TarifsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrixCat = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifss", x => x.TarifsId);
                    table.ForeignKey(
                        name: "FK_Tarifss_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "CategoriesId");
                });

            migrationBuilder.CreateTable(
                name: "Saisons",
                columns: table => new
                {
                    SaisonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarifsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saisons", x => x.SaisonId);
                    table.ForeignKey(
                        name: "FK_Saisons_Tarifss_TarifsId",
                        column: x => x.TarifsId,
                        principalTable: "Tarifss",
                        principalColumn: "TarifsId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facture_StatutId",
                table: "Facture",
                column: "StatutId");

            migrationBuilder.CreateIndex(
                name: "IX_Chambre_CategoriesId",
                table: "Chambre",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Saisons_TarifsId",
                table: "Saisons",
                column: "TarifsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarifss_CategoriesId",
                table: "Tarifss",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chambre_Categories_CategoriesId",
                table: "Chambre",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facture_Statuts_StatutId",
                table: "Facture",
                column: "StatutId",
                principalTable: "Statuts",
                principalColumn: "StatutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chambre_Categories_CategoriesId",
                table: "Chambre");

            migrationBuilder.DropForeignKey(
                name: "FK_Facture_Statuts_StatutId",
                table: "Facture");

            migrationBuilder.DropTable(
                name: "Saisons");

            migrationBuilder.DropTable(
                name: "Statuts");

            migrationBuilder.DropTable(
                name: "Tarifss");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Facture_StatutId",
                table: "Facture");

            migrationBuilder.DropIndex(
                name: "IX_Chambre_CategoriesId",
                table: "Chambre");

            migrationBuilder.DropColumn(
                name: "StatutId",
                table: "Facture");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Chambre");
        }
    }
}
