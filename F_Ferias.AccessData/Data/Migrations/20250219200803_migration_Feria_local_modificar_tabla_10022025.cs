using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_modificar_tabla_10022025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad_federativa_feria_l~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Inversion_id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_tipo_recurso",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropIndex(
                name: "IX_Ferias_Empleo_Local_id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.RenameColumn(
                name: "otra_tipo_recurso",
                table: "Ferias_Empleo_Local",
                newName: "observacion_servicios_videoconferencias_federal");

            migrationBuilder.AlterColumn<int>(
                name: "tipo_evento",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "poblacion_especifica",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "otros_tipo_poblacion",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "otros_tipo_justificacion",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_tipo_recurso",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_entidad_federativa_feria_local",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_acondicionamiento_est",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_acondicionamiento_federal",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_alquiler_federal",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_infraestructura_computo_est",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_infraestructura_computo_federal",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_promocion_est",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_promocion_federal",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_servicios_videoconferencias_est",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_servicios_videoconferencias_federal",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_total_federal",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "observacion_acondicionamiento_est",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_acondicionamiento_federal",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_alquiler_federal",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_infraestructura_computo_est",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_infraestructura_computo_federal",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_promocion_estatal",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_promocion_federal",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_recurso_estatal",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_recurso_federal",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion_servicios_videoconferencias_est",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad_federativa_feria_l~",
                table: "Ferias_Empleo_Local",
                column: "id_entidad_federativa_feria_local",
                principalTable: "entidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                table: "Ferias_Empleo_Local",
                column: "poblacion_especifica",
                principalTable: "Poblacion_Especifica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                table: "Ferias_Empleo_Local",
                column: "tipo_evento",
                principalTable: "Tipo_Evento_Feria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_tipo_recurso",
                table: "Ferias_Empleo_Local",
                column: "id_tipo_recurso",
                principalTable: "Tipo_Recurso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad_federativa_feria_l~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_tipo_recurso",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_acondicionamiento_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_acondicionamiento_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_alquiler_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_infraestructura_computo_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_infraestructura_computo_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_promocion_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_promocion_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_servicios_videoconferencias_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_servicios_videoconferencias_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "cantidad_total_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_acondicionamiento_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_acondicionamiento_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_alquiler_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_infraestructura_computo_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_infraestructura_computo_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_promocion_estatal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_promocion_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_recurso_estatal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_recurso_federal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_servicios_videoconferencias_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.RenameColumn(
                name: "observacion_servicios_videoconferencias_federal",
                table: "Ferias_Empleo_Local",
                newName: "otra_tipo_recurso");

            migrationBuilder.AlterColumn<int>(
                name: "tipo_evento",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "poblacion_especifica",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "otros_tipo_poblacion",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "otros_tipo_justificacion",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_tipo_recurso",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_entidad_federativa_feria_local",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "id_feria_inversion",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_feria_inversion",
                table: "Ferias_Empleo_Local",
                column: "id_feria_inversion");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad_federativa_feria_l~",
                table: "Ferias_Empleo_Local",
                column: "id_entidad_federativa_feria_local",
                principalTable: "entidades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Inversion_id_feria_inversion",
                table: "Ferias_Empleo_Local",
                column: "id_feria_inversion",
                principalTable: "Feria_Inversion",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                table: "Ferias_Empleo_Local",
                column: "poblacion_especifica",
                principalTable: "Poblacion_Especifica",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                table: "Ferias_Empleo_Local",
                column: "tipo_evento",
                principalTable: "Tipo_Evento_Feria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_tipo_recurso",
                table: "Ferias_Empleo_Local",
                column: "id_tipo_recurso",
                principalTable: "Tipo_Recurso",
                principalColumn: "Id");
        }
    }
}
