using Microsoft.EntityFrameworkCore.Migrations;

namespace PIXIE_PHOTOS.Data.Migrations
{
    public partial class _addPhotosToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "title",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "Album_Title",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Album_Title",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
