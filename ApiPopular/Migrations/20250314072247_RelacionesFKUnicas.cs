using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPopular.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesFKUnicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_CodigoAsesor",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_IdEstado",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_IdPrestamo",
                table: "Solicitudes");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_CodigoAsesor",
                table: "Solicitudes",
                column: "CodigoAsesor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_IdEstado",
                table: "Solicitudes",
                column: "IdEstado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_IdPrestamo",
                table: "Solicitudes",
                column: "IdPrestamo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_CodigoAsesor",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_IdEstado",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_IdPrestamo",
                table: "Solicitudes");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_CodigoAsesor",
                table: "Solicitudes",
                column: "CodigoAsesor");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_IdEstado",
                table: "Solicitudes",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_IdPrestamo",
                table: "Solicitudes",
                column: "IdPrestamo");
        }
    }
}
