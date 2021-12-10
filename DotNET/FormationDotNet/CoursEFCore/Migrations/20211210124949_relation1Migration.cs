using Microsoft.EntityFrameworkCore.Migrations;

namespace CoursEFCore.Migrations
{
    public partial class relation1Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresseId",
                table: "personne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personne_Adresse_AdresseId",
                table: "personne");

            migrationBuilder.DropTable(
                name: "Adresse");

            migrationBuilder.DropIndex(
                name: "IX_personne_AdresseId",
                table: "personne");

            migrationBuilder.DropColumn(
                name: "AdresseId",
                table: "personne");
        }
    }
}
