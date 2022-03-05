using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetalleyConsulta.Migrations
{
    public partial class Inicializar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductosDetalle",
                table: "ProductosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_ProductosDetalle_ProductoId",
                table: "ProductosDetalle");

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductosDetalle");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "ProductosDetalle");

            migrationBuilder.DropColumn(
                name: "ExistenciaEmpaque",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Presentacion",
                table: "Productos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductosDetalle",
                table: "ProductosDetalle",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "ProductosDetalle",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExistenciaEmpaque",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Presentacion",
                table: "Productos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductosDetalle",
                table: "ProductosDetalle",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Existencia", "ExistenciaEmpaque", "Ganancia", "Precio", "Presentacion", "ValorInventario" },
                values: new object[] { 1, 50f, "Arroz", 50f, 30m, 20, 100f, null, 0f });

            migrationBuilder.CreateIndex(
                name: "IX_ProductosDetalle_ProductoId",
                table: "ProductosDetalle",
                column: "ProductoId");
        }
    }
}
