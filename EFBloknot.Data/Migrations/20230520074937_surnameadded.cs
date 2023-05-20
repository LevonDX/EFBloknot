using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFBloknot.Data.Migrations
{
    /// <inheritdoc />
    public partial class surnameadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Records");
        }
    }
}
