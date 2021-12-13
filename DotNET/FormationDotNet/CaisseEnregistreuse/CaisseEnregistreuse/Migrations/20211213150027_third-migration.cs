using Microsoft.EntityFrameworkCore.Migrations;

namespace CaisseEnregistreuse.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProduitVente_Produits_ProduitsId",
                table: "ProduitVente");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduitVente_Ventes_VentesId",
                table: "ProduitVente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProduitVente",
                table: "ProduitVente");

            migrationBuilder.RenameColumn(
                name: "VentesId",
                table: "ProduitVente",
                newName: "VenteId");

            migrationBuilder.RenameColumn(
                name: "ProduitsId",
                table: "ProduitVente",
                newName: "Qty");

            migrationBuilder.RenameIndex(
                name: "IX_ProduitVente_VentesId",
                table: "ProduitVente",
                newName: "IX_ProduitVente_VenteId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProduitVente",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ProduitId",
                table: "ProduitVente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProduitVente",
                table: "ProduitVente",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProduitVente_ProduitId",
                table: "ProduitVente",
                column: "ProduitId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitVente_Produits_ProduitId",
                table: "ProduitVente",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitVente_Ventes_VenteId",
                table: "ProduitVente",
                column: "VenteId",
                principalTable: "Ventes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProduitVente_Produits_ProduitId",
                table: "ProduitVente");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduitVente_Ventes_VenteId",
                table: "ProduitVente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProduitVente",
                table: "ProduitVente");

            migrationBuilder.DropIndex(
                name: "IX_ProduitVente_ProduitId",
                table: "ProduitVente");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProduitVente");

            migrationBuilder.DropColumn(
                name: "ProduitId",
                table: "ProduitVente");

            migrationBuilder.RenameColumn(
                name: "VenteId",
                table: "ProduitVente",
                newName: "VentesId");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "ProduitVente",
                newName: "ProduitsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProduitVente_VenteId",
                table: "ProduitVente",
                newName: "IX_ProduitVente_VentesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProduitVente",
                table: "ProduitVente",
                columns: new[] { "ProduitsId", "VentesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitVente_Produits_ProduitsId",
                table: "ProduitVente",
                column: "ProduitsId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitVente_Ventes_VentesId",
                table: "ProduitVente",
                column: "VentesId",
                principalTable: "Ventes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
