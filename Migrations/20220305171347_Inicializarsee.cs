using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetalleyConsulta.Migrations
{
    public partial class Inicializarsee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductosDetalle",
                table: "ProductosDetalle");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductosDetalle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductosDetalle",
                table: "ProductosDetalle",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosDetalle_ProductoId",
                table: "ProductosDetalle",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductosDetalle",
                table: "ProductosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_ProductosDetalle_ProductoId",
                table: "ProductosDetalle");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductosDetalle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductosDetalle",
                table: "ProductosDetalle",
                column: "ProductoId");
        }
    }
}
