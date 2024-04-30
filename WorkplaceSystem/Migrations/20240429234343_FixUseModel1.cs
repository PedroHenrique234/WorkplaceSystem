using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkplaceSystem.Migrations
{
    /// <inheritdoc />
    public partial class FixUseModel1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontlyUsage",
                table: "Uses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "MontlyUsage",
                table: "Uses",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
