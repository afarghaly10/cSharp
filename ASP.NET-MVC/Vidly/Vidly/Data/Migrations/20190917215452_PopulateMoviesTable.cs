using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class PopulateMoviesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Movies(Name, ReleasedDate, DateAdded, NumberInStock, GenreId)" +
                                 $"VALUES ('HangOver', '2009-09-15 00:00:01.00, 2009-10-15 00:00:00.00, 4, 3)");
            
            migrationBuilder.Sql($"INSERT INTO Movies(Name, ReleasedDate, DateAdded, NumberInStock, GenreId)" +
                                 $"VALUES ('Toy Story 4', 2019-06-20 00:00:01.00, 2019-09-17 00:00:00.00, 3, 5)");
            
            migrationBuilder.Sql($"INSERT INTO Movies(Name, ReleasedDate, DateAdded, NumberInStock, GenreId)" +
                                 $"VALUES ('Spider man', 2019-07-02 00:00:01.00, 2019-09-15 00:00:00.00, 6, 2)");
            
            migrationBuilder.Sql($"INSERT INTO Movies(Name, ReleasedDate, DateAdded, NumberInStock, GenreId)" +
                                 $"VALUES ('Die Hard', 2000-07-12 00:00:01.00, 2000-09-16 00:00:00.00, 7, 1)");
            
            migrationBuilder.Sql($"INSERT INTO Movies(Name, ReleasedDate, DateAdded, NumberInStock, GenreId)" +
                                 $"VALUES ('Serenity', 2019-01-25 00:00:01.00, 2019-02-27 00:00:00.00, 5, 7)");
            
            migrationBuilder.Sql($"INSERT INTO Movies(Name, ReleasedDate, DateAdded, NumberInStock, GenreId)" +
                                 $"VALUES ('Long Shot', 2019-05-02 00:00:01.00, 2019-07-02 00:00:00.00, 5, 6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
