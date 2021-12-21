using Microsoft.EntityFrameworkCore.Migrations;

namespace eBusiness.Migrations
{
    public partial class addQuoteColumntoBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Quote",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quote",
                table: "Blogs");
        }
    }
}
