using Microsoft.EntityFrameworkCore.Migrations;

namespace Bryan.TesteGFT.DbEFCore.Migrations
{
    public partial class AddCNPJColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Company",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Company");
        }
    }
}
