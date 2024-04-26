using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkplaceSystem.Migrations
{
    /// <inheritdoc />
    public partial class SituationAddInClientModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Situation",
                table: "Clients",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situation",
                table: "Clients");
        }
    }
}
