using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinoWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Foreignkeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReptileVols",
                table: "ReptileVols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReptileMars",
                table: "ReptileMars");

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "ReptileVols",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "WheightInTons",
                table: "ReptileVols",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Diet",
                table: "ReptileMars",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "ReptileMars",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 0)
                .OldAnnotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "WheightInTons",
                table: "ReptileMars",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<int>(
                name: "Id1",
                table: "ReptileMars",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id2",
                table: "ReptileMars",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReptileVols",
                table: "ReptileVols",
                columns: new[] { "Size", "WheightInTons" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReptileMars",
                table: "ReptileMars",
                columns: new[] { "Size", "WheightInTons" });

            migrationBuilder.CreateIndex(
                name: "IX_ReptileMars_Id1_Id2",
                table: "ReptileMars",
                columns: new[] { "Id1", "Id2" });

            migrationBuilder.AddForeignKey(
                name: "FK_ReptileMars_ReptileVols_Id1_Id2",
                table: "ReptileMars",
                columns: new[] { "Id1", "Id2" },
                principalTable: "ReptileVols",
                principalColumns: new[] { "Size", "WheightInTons" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReptileMars_ReptileVols_Id1_Id2",
                table: "ReptileMars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReptileVols",
                table: "ReptileVols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReptileMars",
                table: "ReptileMars");

            migrationBuilder.DropIndex(
                name: "IX_ReptileMars_Id1_Id2",
                table: "ReptileMars");

            migrationBuilder.DropColumn(
                name: "WheightInTons",
                table: "ReptileVols");

            migrationBuilder.DropColumn(
                name: "WheightInTons",
                table: "ReptileMars");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "ReptileMars");

            migrationBuilder.DropColumn(
                name: "Id2",
                table: "ReptileMars");

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "ReptileVols",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Diet",
                table: "ReptileMars",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "ReptileMars",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 4)
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReptileVols",
                table: "ReptileVols",
                column: "Size");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReptileMars",
                table: "ReptileMars",
                column: "Size");
        }
    }
}
