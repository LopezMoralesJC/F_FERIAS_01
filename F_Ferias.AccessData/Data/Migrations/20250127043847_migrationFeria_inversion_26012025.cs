using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migrationFeria_inversion_26012025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estatus",
                table: "Feria_Inversion");

            migrationBuilder.RenameColumn(
                name: "observacion_promocion_est",
                table: "Feria_Inversion",
                newName: "observacion_servicios_videoconferencias_federal");

            migrationBuilder.RenameColumn(
                name: "observacion_promocion",
                table: "Feria_Inversion",
                newName: "observacion_servicios_videoconferencias_est");

            migrationBuilder.RenameColumn(
                name: "observacion_infraestructura_computo",
                table: "Feria_Inversion",
                newName: "observacion_recurso_federal");

            migrationBuilder.RenameColumn(
                name: "observacion_alquiler",
                table: "Feria_Inversion",
                newName: "observacion_recurso_estatal");

            migrationBuilder.RenameColumn(
                name: "observacion_alimentos_bebidas_est",
                table: "Feria_Inversion",
                newName: "observacion_promocion_federal");

            migrationBuilder.RenameColumn(
                name: "observacion_alimentos_bebidas",
                table: "Feria_Inversion",
                newName: "observacion_promocion_estatal");

            migrationBuilder.RenameColumn(
                name: "observacion_acondicionamiento",
                table: "Feria_Inversion",
                newName: "observacion_infraestructura_computo_federal");

            migrationBuilder.RenameColumn(
                name: "cantidad_promocion",
                table: "Feria_Inversion",
                newName: "cantidad_servicios_videoconferencias_federal");

            migrationBuilder.RenameColumn(
                name: "cantidad_infraestructura_computo",
                table: "Feria_Inversion",
                newName: "cantidad_servicios_videoconferencias_est");

            migrationBuilder.RenameColumn(
                name: "cantidad_alquiler",
                table: "Feria_Inversion",
                newName: "cantidad_promocion_federal");

            migrationBuilder.RenameColumn(
                name: "cantidad_alimentos_bebidas_est",
                table: "Feria_Inversion",
                newName: "cantidad_infraestructura_computo_federal");

            migrationBuilder.RenameColumn(
                name: "cantidad_alimentos_bebidas",
                table: "Feria_Inversion",
                newName: "cantidad_alquiler_federal");

            migrationBuilder.RenameColumn(
                name: "cantidad_acondicionamiento",
                table: "Feria_Inversion",
                newName: "cantidad_acondicionamiento_federal");

            migrationBuilder.AddColumn<int>(
                name: "id_feria_inversion",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_acondicionamiento_federal",
                table: "Feria_Inversion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_alquiler_federal",
                table: "Feria_Inversion",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_feria_inversion",
                table: "Ferias_Empleo_Local",
                column: "id_feria_inversion");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Inversion_id_feria_inversion",
                table: "Ferias_Empleo_Local",
                column: "id_feria_inversion",
                principalTable: "Feria_Inversion",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Inversion_id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropIndex(
                name: "IX_Ferias_Empleo_Local_id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_acondicionamiento_federal",
                table: "Feria_Inversion");

            migrationBuilder.DropColumn(
                name: "observacion_alquiler_federal",
                table: "Feria_Inversion");

            migrationBuilder.RenameColumn(
                name: "observacion_servicios_videoconferencias_federal",
                table: "Feria_Inversion",
                newName: "observacion_promocion_est");

            migrationBuilder.RenameColumn(
                name: "observacion_servicios_videoconferencias_est",
                table: "Feria_Inversion",
                newName: "observacion_promocion");

            migrationBuilder.RenameColumn(
                name: "observacion_recurso_federal",
                table: "Feria_Inversion",
                newName: "observacion_infraestructura_computo");

            migrationBuilder.RenameColumn(
                name: "observacion_recurso_estatal",
                table: "Feria_Inversion",
                newName: "observacion_alquiler");

            migrationBuilder.RenameColumn(
                name: "observacion_promocion_federal",
                table: "Feria_Inversion",
                newName: "observacion_alimentos_bebidas_est");

            migrationBuilder.RenameColumn(
                name: "observacion_promocion_estatal",
                table: "Feria_Inversion",
                newName: "observacion_alimentos_bebidas");

            migrationBuilder.RenameColumn(
                name: "observacion_infraestructura_computo_federal",
                table: "Feria_Inversion",
                newName: "observacion_acondicionamiento");

            migrationBuilder.RenameColumn(
                name: "cantidad_servicios_videoconferencias_federal",
                table: "Feria_Inversion",
                newName: "cantidad_promocion");

            migrationBuilder.RenameColumn(
                name: "cantidad_servicios_videoconferencias_est",
                table: "Feria_Inversion",
                newName: "cantidad_infraestructura_computo");

            migrationBuilder.RenameColumn(
                name: "cantidad_promocion_federal",
                table: "Feria_Inversion",
                newName: "cantidad_alquiler");

            migrationBuilder.RenameColumn(
                name: "cantidad_infraestructura_computo_federal",
                table: "Feria_Inversion",
                newName: "cantidad_alimentos_bebidas_est");

            migrationBuilder.RenameColumn(
                name: "cantidad_alquiler_federal",
                table: "Feria_Inversion",
                newName: "cantidad_alimentos_bebidas");

            migrationBuilder.RenameColumn(
                name: "cantidad_acondicionamiento_federal",
                table: "Feria_Inversion",
                newName: "cantidad_acondicionamiento");

            migrationBuilder.AddColumn<int>(
                name: "estatus",
                table: "Feria_Inversion",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
