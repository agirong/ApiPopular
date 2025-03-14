using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPopular.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Asesores_CodigoAsesor",
                table: "Solicitudes",
                column: "CodigoAsesor",
                principalTable: "Asesores",
                principalColumn: "CodigoAsesor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Estados_IdEstado",
                table: "Solicitudes",
                column: "IdEstado",
                principalTable: "Estados",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Prestamos_IdPrestamo",
                table: "Solicitudes",
                column: "IdPrestamo",
                principalTable: "Prestamos",
                principalColumn: "IdPrestamo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Asesores_CodigoAsesor",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Estados_IdEstado",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Prestamos_IdPrestamo",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_CodigoAsesor",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_IdEstado",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_IdPrestamo",
                table: "Solicitudes");
        }
    }
}
