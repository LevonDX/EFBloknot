using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFBloknot.Data.Migrations
{
    /// <inheritdoc />
    public partial class CityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_CityID",
                table: "Records",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Cities_CityID",
                table: "Records",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Cities_CityID",
                table: "Records");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Records_CityID",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Records");
        }
    }
}
