using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_management.Migrations
{
    public partial class updatehotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelsServices_Supplementaire");

            migrationBuilder.AddColumn<int>(
                name: "HotelsId",
                table: "Services_Supplementaire",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_Supplementaire_HotelsId",
                table: "Services_Supplementaire",
                column: "HotelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Supplementaire_Hotels_HotelsId",
                table: "Services_Supplementaire",
                column: "HotelsId",
                principalTable: "Hotels",
                principalColumn: "HotelsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Supplementaire_Hotels_HotelsId",
                table: "Services_Supplementaire");

            migrationBuilder.DropIndex(
                name: "IX_Services_Supplementaire_HotelsId",
                table: "Services_Supplementaire");

            migrationBuilder.DropColumn(
                name: "HotelsId",
                table: "Services_Supplementaire");

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

            migrationBuilder.CreateIndex(
                name: "IX_HotelsServices_Supplementaire_Services_SupplementaireServicesId",
                table: "HotelsServices_Supplementaire",
                column: "Services_SupplementaireServicesId");
        }
    }
}
