using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityOrganizer.Data.Migrations
{
    public partial class headlines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HeadLineThree",
                table: "InformationBoard",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadLineTwo",
                table: "InformationBoard",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadLineThree",
                table: "InformationBoard");

            migrationBuilder.DropColumn(
                name: "HeadLineTwo",
                table: "InformationBoard");
        }
    }
}
