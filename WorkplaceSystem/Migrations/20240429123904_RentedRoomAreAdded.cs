using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkplaceSystem.Migrations
{
    /// <inheritdoc />
    public partial class RentedRoomAreAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentedRoom",
                table: "Uses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentedRoom",
                table: "Uses");
        }
    }
}
