using Microsoft.EntityFrameworkCore.Migrations;

namespace CoursEFCore.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ecoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formateurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EcoleFormateur",
                columns: table => new
                {
                    EcolesId = table.Column<int>(type: "int", nullable: false),
                    FormateursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EcoleFormateur", x => new { x.EcolesId, x.FormateursId });
                    table.ForeignKey(
                        name: "FK_EcoleFormateur_Ecoles_EcolesId",
                        column: x => x.EcolesId,
                        principalTable: "Ecoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EcoleFormateur_Formateurs_FormateursId",
                        column: x => x.FormateursId,
                        principalTable: "Formateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EcoleFormateur_FormateursId",
                table: "EcoleFormateur",
                column: "FormateursId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EcoleFormateur");

            migrationBuilder.DropTable(
                name: "Ecoles");

            migrationBuilder.DropTable(
                name: "Formateurs");
        }
    }
}
