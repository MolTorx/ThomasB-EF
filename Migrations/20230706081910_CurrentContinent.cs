using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinoWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CurrentContinent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WheightTons",
                table: "Dinosaurs",
                newName: "WheightInTons");

            migrationBuilder.AddColumn<string>(
                name: "CurrentContinent",
                table: "Dinosaurs",
                type: "nvarchar (40)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentContinent",
                table: "Dinosaurs");

            migrationBuilder.RenameColumn(
                name: "WheightInTons",
                table: "Dinosaurs",
                newName: "WheightTons");
        }
    }
}
