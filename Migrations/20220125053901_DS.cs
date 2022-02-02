using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4Jan24.Migrations
{
    public partial class DS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Family", "Hilton", false, null, null, "R", "Surfs Up", 2005 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Family", "Washington", false, null, null, "G", "Megamind", 2006 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Family", "Nieldman", false, null, null, "PG", "Shrek", 2002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
