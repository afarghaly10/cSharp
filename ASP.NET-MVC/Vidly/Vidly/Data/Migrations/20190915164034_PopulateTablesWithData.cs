using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class PopulateTablesWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                $"INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (0, 0, 0)");
            migrationBuilder.Sql(
                $"INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (30, 1, 10)");
            migrationBuilder.Sql( 
                $"INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (90, 3, 15)");
            migrationBuilder.Sql(
                $"INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (298, 12, 25)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
