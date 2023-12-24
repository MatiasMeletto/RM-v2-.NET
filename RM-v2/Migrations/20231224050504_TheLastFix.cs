using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RM_v2.Migrations
{
    public partial class TheLastFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Importe",
                table: "accesorios",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Importe",
                table: "accesorios");
        }
    }
}
