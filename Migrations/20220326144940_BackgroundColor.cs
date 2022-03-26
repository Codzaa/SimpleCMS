using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cms.Migrations
{
    public partial class BackgroundColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SiteBackgroundColor",
                table: "CustomSites",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PageBackgroundColor",
                table: "CustomPages",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteBackgroundColor",
                table: "CustomSites");

            migrationBuilder.DropColumn(
                name: "PageBackgroundColor",
                table: "CustomPages");
        }
    }
}
