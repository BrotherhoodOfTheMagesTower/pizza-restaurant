using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaRestaurant.Data.Migrations
{
    public partial class AlteredPizzaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "pizza",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "pizza");
        }
    }
}
