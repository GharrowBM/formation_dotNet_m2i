using Microsoft.EntityFrameworkCore.Migrations;

namespace CaisseEnregistreuse.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Ventes_VenteId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_VenteId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "VenteId",
                table: "Produits");

            migrationBuilder.CreateTable(
                name: "ProduitVente",
                columns: table => new
                {
                    ProduitsId = table.Column<int>(type: "int", nullable: false),
                    VentesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitVente", x => new { x.ProduitsId, x.VentesId });
                    table.ForeignKey(
                        name: "FK_ProduitVente_Produits_ProduitsId",
                        column: x => x.ProduitsId,
                        principalTable: "Produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProduitVente_Ventes_VentesId",
                        column: x => x.VentesId,
                        principalTable: "Ventes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProduitVente_VentesId",
                table: "ProduitVente",
                column: "VentesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProduitVente");

            migrationBuilder.AddColumn<int>(
                name: "VenteId",
                table: "Produits",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produits_VenteId",
                table: "Produits",
                column: "VenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Ventes_VenteId",
                table: "Produits",
                column: "VenteId",
                principalTable: "Ventes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
