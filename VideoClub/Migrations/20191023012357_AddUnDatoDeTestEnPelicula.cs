using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoClub.Migrations
{
    public partial class AddUnDatoDeTestEnPelicula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UnDatoDeTest",
                table: "Peliculas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnDatoDeTest",
                table: "Peliculas");
        }
    }
}
