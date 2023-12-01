using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotellerie_GDG1.Migrations
{
    /// <inheritdoc />
    public partial class AddTel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tel",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tel",
                table: "Hotels");
        }
    }
}
