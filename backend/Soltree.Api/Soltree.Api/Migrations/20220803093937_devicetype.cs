using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soltree.Api.Migrations
{
    public partial class devicetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "DeviceTypes",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "DeviceTypes");
        }
    }
}
