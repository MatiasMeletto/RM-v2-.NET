using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RM_v2.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accesorios_Categoria_CategoriaId",
                table: "accesorios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "categorias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categorias",
                table: "categorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_accesorios_categorias_CategoriaId",
                table: "accesorios",
                column: "CategoriaId",
                principalTable: "categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accesorios_categorias_CategoriaId",
                table: "accesorios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categorias",
                table: "categorias");

            migrationBuilder.RenameTable(
                name: "categorias",
                newName: "Categoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_accesorios_Categoria_CategoriaId",
                table: "accesorios",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
