using Microsoft.EntityFrameworkCore.Migrations;

namespace CoursEFCore.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Personnes",
                table: "Personnes");

            migrationBuilder.RenameTable(
                name: "Personnes",
                newName: "personne");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "personne",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "personne",
                newName: "prenom");

            migrationBuilder.AlterColumn<string>(
                name: "nom",
                table: "personne",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "prenom",
                table: "personne",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "personne",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personne",
                table: "personne",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_personne",
                table: "personne");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "personne");

            migrationBuilder.RenameTable(
                name: "personne",
                newName: "Personnes");

            migrationBuilder.RenameColumn(
                name: "prenom",
                table: "Personnes",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "nom",
                table: "Personnes",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personnes",
                table: "Personnes",
                column: "Id");
        }
    }
}
