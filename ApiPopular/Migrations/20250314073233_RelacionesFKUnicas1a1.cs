using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPopular.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesFKUnicas1a1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "SolicitudesNoSolicitud",
                table: "Prestamos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SolicitudesNoSolicitud",
                table: "Estados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SolicitudesNoSolicitud",
                table: "Asesores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_SolicitudesNoSolicitud",
                table: "Prestamos",
                column: "SolicitudesNoSolicitud");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_SolicitudesNoSolicitud",
                table: "Estados",
                column: "SolicitudesNoSolicitud");

            migrationBuilder.CreateIndex(
                name: "IX_Asesores_SolicitudesNoSolicitud",
                table: "Asesores",
                column: "SolicitudesNoSolicitud");

            migrationBuilder.AddForeignKey(
                name: "FK_Asesores_Solicitudes_SolicitudesNoSolicitud",
                table: "Asesores",
                column: "SolicitudesNoSolicitud",
                principalTable: "Solicitudes",
                principalColumn: "NoSolicitud");

            migrationBuilder.AddForeignKey(
                name: "FK_Estados_Solicitudes_SolicitudesNoSolicitud",
                table: "Estados",
                column: "SolicitudesNoSolicitud",
                principalTable: "Solicitudes",
                principalColumn: "NoSolicitud");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Solicitudes_SolicitudesNoSolicitud",
                table: "Prestamos",
                column: "SolicitudesNoSolicitud",
                principalTable: "Solicitudes",
                principalColumn: "NoSolicitud");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asesores_Solicitudes_SolicitudesNoSolicitud",
                table: "Asesores");

            migrationBuilder.DropForeignKey(
                name: "FK_Estados_Solicitudes_SolicitudesNoSolicitud",
                table: "Estados");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Solicitudes_SolicitudesNoSolicitud",
                table: "Prestamos");

            migrationBuilder.DropIndex(
                name: "IX_Prestamos_SolicitudesNoSolicitud",
                table: "Prestamos");

            migrationBuilder.DropIndex(
                name: "IX_Estados_SolicitudesNoSolicitud",
                table: "Estados");

            migrationBuilder.DropIndex(
                name: "IX_Asesores_SolicitudesNoSolicitud",
                table: "Asesores");

            migrationBuilder.DropColumn(
                name: "SolicitudesNoSolicitud",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "SolicitudesNoSolicitud",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "SolicitudesNoSolicitud",
                table: "Asesores");

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
    }
}
