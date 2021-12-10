using Microsoft.EntityFrameworkCore.Migrations;

namespace CoursEFCore.Migrations
{
    public partial class relation2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personne_Adresse_AdresseId",
                table: "personne");

            migrationBuilder.DropIndex(
                name: "IX_personne_AdresseId",
                table: "personne");

            migrationBuilder.DropColumn(
                name: "AdresseId",
                table: "personne");

            migrationBuilder.AddColumn<int>(
                name: "PersonneId",
                table: "Adresse",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adresse_PersonneId",
                table: "Adresse",
                column: "PersonneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresse_personne_PersonneId",
                table: "Adresse",
                column: "PersonneId",
                principalTable: "personne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresse_personne_PersonneId",
                table: "Adresse");

            migrationBuilder.DropIndex(
                name: "IX_Adresse_PersonneId",
                table: "Adresse");

            migrationBuilder.DropColumn(
                name: "PersonneId",
                table: "Adresse");

            migrationBuilder.AddColumn<int>(
                name: "AdresseId",
                table: "personne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_personne_AdresseId",
                table: "personne",
                column: "AdresseId");

            migrationBuilder.AddForeignKey(
                name: "FK_personne_Adresse_AdresseId",
                table: "personne",
                column: "AdresseId",
                principalTable: "Adresse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
