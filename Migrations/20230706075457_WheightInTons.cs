using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinoWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class WheightInTons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WheightTons",
                table: "Dinosaurs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WheightTons",
                table: "Dinosaurs");
        }
    }
}
