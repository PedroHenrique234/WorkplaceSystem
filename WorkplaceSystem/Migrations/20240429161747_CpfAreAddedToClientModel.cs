using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkplaceSystem.Migrations
{
    /// <inheritdoc />
    public partial class CpfAreAddedToClientModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Clients");
        }
    }
}
