using Microsoft.EntityFrameworkCore.Migrations;

namespace OtroRegistroConDetalle.Migrations
{
    public partial class AgregandoPermisos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "PermisoId", "Descripcion", "Nombre", "VecesAsignado" },
                values: new object[] { 1, "Se  hace un descuento de 10% al cliente", "Descuenta", false });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "PermisoId", "Descripcion", "Nombre", "VecesAsignado" },
                values: new object[] { 2, "Se le puede realizar una venta al cliente", "Vende", false });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "PermisoId", "Descripcion", "Nombre", "VecesAsignado" },
                values: new object[] { 3, "El cliente puede realizar una compra", "Compra", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 3);
        }
    }
}
