using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_management.Migrations
{
    public partial class tableadding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelsId",
                table: "Commentaire",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Criteria_stars = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Criteria_size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity_Max = table.Column<int>(type: "int", nullable: false),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelsId);
                });

            migrationBuilder.CreateTable(
                name: "Services_Supplementaire",
                columns: table => new
                {
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServciesPrix = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services_Supplementaire", x => x.ServicesId);
                });

            migrationBuilder.CreateTable(
                name: "Chambre",
                columns: table => new
                {
                    ChambreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chambre", x => x.ChambreId);
                    table.ForeignKey(
                        name: "FK_Chambre_Hotels_HotelsId",
                        column: x => x.HotelsId,
                        principalTable: "Hotels",
                        principalColumn: "HotelsId");
                });

            migrationBuilder.CreateTable(
                name: "HotelsServices_Supplementaire",
                columns: table => new
                {
                    HotelsId = table.Column<int>(type: "int", nullable: false),
                    Services_SupplementaireServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelsServices_Supplementaire", x => new { x.HotelsId, x.Services_SupplementaireServicesId });
                    table.ForeignKey(
                        name: "FK_HotelsServices_Supplementaire_Hotels_HotelsId",
                        column: x => x.HotelsId,
                        principalTable: "Hotels",
                        principalColumn: "HotelsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelsServices_Supplementaire_Services_Supplementaire_Services_SupplementaireServicesId",
                        column: x => x.Services_SupplementaireServicesId,
                        principalTable: "Services_Supplementaire",
                        principalColumn: "ServicesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Concerner",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    ChamberId = table.Column<int>(type: "int", nullable: false),
                    ChambresChambreId = table.Column<int>(type: "int", nullable: false),
                    NbAdultes = table.Column<int>(type: "int", nullable: false),
                    NbEnfant = table.Column<int>(type: "int", nullable: false),
                    DateErrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeparture = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerner", x => new { x.ReservationId, x.ChamberId });
                    table.ForeignKey(
                        name: "FK_Concerner_Chambre_ChambresChambreId",
                        column: x => x.ChambresChambreId,
                        principalTable: "Chambre",
                        principalColumn: "ChambreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Concerner_Reservation_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservation",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_HotelsId",
                table: "Commentaire",
                column: "HotelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Chambre_HotelsId",
                table: "Chambre",
                column: "HotelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Concerner_ChambresChambreId",
                table: "Concerner",
                column: "ChambresChambreId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelsServices_Supplementaire_Services_SupplementaireServicesId",
                table: "HotelsServices_Supplementaire",
                column: "Services_SupplementaireServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaire_Hotels_HotelsId",
                table: "Commentaire",
                column: "HotelsId",
                principalTable: "Hotels",
                principalColumn: "HotelsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentaire_Hotels_HotelsId",
                table: "Commentaire");

            migrationBuilder.DropTable(
                name: "Concerner");

            migrationBuilder.DropTable(
                name: "HotelsServices_Supplementaire");

            migrationBuilder.DropTable(
                name: "Chambre");

            migrationBuilder.DropTable(
                name: "Services_Supplementaire");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Commentaire_HotelsId",
                table: "Commentaire");

            migrationBuilder.DropColumn(
                name: "HotelsId",
                table: "Commentaire");
        }
    }
}
