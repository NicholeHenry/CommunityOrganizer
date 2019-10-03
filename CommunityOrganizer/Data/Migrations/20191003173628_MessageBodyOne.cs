using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityOrganizer.Data.Migrations
{
    public partial class MessageBodyOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageBodythree",
                table: "InformationBoard",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MessageBodytwo",
                table: "InformationBoard",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageBodythree",
                table: "InformationBoard");

            migrationBuilder.DropColumn(
                name: "MessageBodytwo",
                table: "InformationBoard");
        }
    }
}
