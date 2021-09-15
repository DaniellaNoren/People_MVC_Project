using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleMVC.Migrations
{
    public partial class SSN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_People_SocialSecurityNr",
                table: "People",
                column: "SocialSecurityNr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_People_SocialSecurityNr",
                table: "People");
        }
    }
}
