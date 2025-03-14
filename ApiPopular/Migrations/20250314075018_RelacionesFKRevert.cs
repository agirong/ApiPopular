using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPopular.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesFKRevert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
