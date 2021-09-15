using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleMVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialSecurityNr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "FirstName", "LastName", "PhoneNr", "SocialSecurityNr" },
                values: new object[,]
                {
                    { 1, "Berlin", "Tina", "Zwanzig", "031-5092-333", "9206901234" },
                    { 2, "Stockholm", "Olle", "Larsson", "074-3232-356", "9206902222" },
                    { 3, "Stockholm", "Karin", "Andersson", "074-3244-444", "9206901111" },
                    { 4, "Göteborg", "Fatima", "Koh", "071-1234-123", "9206905678" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
