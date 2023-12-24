using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RM_v2.Migrations
{
    public partial class addCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "accesorios",
                newName: "CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "accesorios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "accesorios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accesorios_CategoriaId",
                table: "accesorios",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_accesorios_Categoria_CategoriaId",
                table: "accesorios",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accesorios_Categoria_CategoriaId",
                table: "accesorios");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_accesorios_CategoriaId",
                table: "accesorios");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "accesorios",
                newName: "Categoria");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "accesorios",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "accesorios",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
