using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinWebPage.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserGame1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "UserGames",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameName",
                table: "UserGames");
        }
    }
}
