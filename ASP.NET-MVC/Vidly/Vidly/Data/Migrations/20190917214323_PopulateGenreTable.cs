using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class PopulateGenreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Genre (Name) VALUES ('Action')");
            migrationBuilder.Sql($"INSERT INTO Genre (Name) VALUES ('Adventure')");
            migrationBuilder.Sql($"INSERT INTO Genre (Name) VALUES ('Comedy')");
            migrationBuilder.Sql($"INSERT INTO Genre (Name) VALUES ('Drama')");
            migrationBuilder.Sql($"INSERT INTO Genre (Name) VALUES ('Family')");
            migrationBuilder.Sql($"INSERT INTO Genre (Name) VALUES ('Romance')");
            migrationBuilder.Sql($"INSERT INTO Genre (Name) VALUES ('Thriller')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
