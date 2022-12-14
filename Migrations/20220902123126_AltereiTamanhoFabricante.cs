using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CriandoAPI2.Migrations
{
    public partial class AltereiTamanhoFabricante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Aeronave",
                type: "nvarchar(60)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Aeronave",
                type: "nvarchar(50)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);
        }
    }
}
