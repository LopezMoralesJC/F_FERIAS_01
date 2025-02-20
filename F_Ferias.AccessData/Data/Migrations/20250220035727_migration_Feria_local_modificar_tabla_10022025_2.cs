using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_modificar_tabla_10022025_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_actividades_Complementarias_id_activida~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_justificaciones_FK_justificacion_f~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropTable(
                name: "Feria_Inversion");

            migrationBuilder.DropIndex(
                name: "IX_Ferias_Empleo_Local_id_actividad_complementaria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropIndex(
                name: "IX_Ferias_Empleo_Local_justificacion_feria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "id_actividad_complementaria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<string>(
                name: "vialidad",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "observacion_servicios_videoconferencias_est",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "municipio",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<float>(
                name: "cantidad_total_est",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidad_total_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<int>(
                name: "vialidad",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "observacion_servicios_videoconferencias_est",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "municipio",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_actividad_complementaria",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Feria_Inversion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_tipo_recurso = table.Column<int>(type: "integer", nullable: false),
                    cantidad_acondicionamiento_est = table.Column<float>(type: "real", nullable: false),
                    cantidad_acondicionamiento_federal = table.Column<float>(type: "real", nullable: false),
                    cantidad_alquiler_est = table.Column<float>(type: "real", nullable: false),
                    cantidad_alquiler_federal = table.Column<float>(type: "real", nullable: false),
                    cantidad_infraestructura_computo_est = table.Column<float>(type: "real", nullable: false),
                    cantidad_infraestructura_computo_federal = table.Column<float>(type: "real", nullable: false),
                    cantidad_promocion_est = table.Column<float>(type: "real", nullable: false),
                    cantidad_promocion_federal = table.Column<float>(type: "real", nullable: false),
                    cantidad_servicios_videoconferencias_est = table.Column<float>(type: "real", nullable: false),
                    cantidad_servicios_videoconferencias_federal = table.Column<float>(type: "real", nullable: false),
                    cantidad_total_est = table.Column<float>(type: "real", nullable: false),
                    cantidad_total_federal = table.Column<float>(type: "real", nullable: false),
                    observacion_acondicionamiento_est = table.Column<string>(type: "text", nullable: true),
                    observacion_acondicionamiento_federal = table.Column<string>(type: "text", nullable: true),
                    observacion_alquiler_est = table.Column<string>(type: "text", nullable: true),
                    observacion_alquiler_federal = table.Column<string>(type: "text", nullable: true),
                    observacion_infraestructura_computo_est = table.Column<string>(type: "text", nullable: true),
                    observacion_infraestructura_computo_federal = table.Column<string>(type: "text", nullable: true),
                    observacion_promocion_estatal = table.Column<string>(type: "text", nullable: true),
                    observacion_promocion_federal = table.Column<string>(type: "text", nullable: true),
                    observacion_recurso_estatal = table.Column<string>(type: "text", nullable: true),
                    observacion_recurso_federal = table.Column<string>(type: "text", nullable: true),
                    observacion_servicios_videoconferencias_est = table.Column<string>(type: "text", nullable: true),
                    observacion_servicios_videoconferencias_federal = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feria_Inversion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Feria_Inversion_Tipo_Recurso_id_tipo_recurso",
                        column: x => x.id_tipo_recurso,
                        principalTable: "Tipo_Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_actividad_complementaria",
                table: "Ferias_Empleo_Local",
                column: "id_actividad_complementaria");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_justificacion_feria",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria");

            migrationBuilder.CreateIndex(
                name: "IX_Feria_Inversion_id_tipo_recurso",
                table: "Feria_Inversion",
                column: "id_tipo_recurso");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_actividades_Complementarias_id_activida~",
                table: "Ferias_Empleo_Local",
                column: "id_actividad_complementaria",
                principalTable: "actividades_Complementarias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_justificaciones_FK_justificacion_f~",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria",
                principalTable: "Tipo_justificaciones_FK",
                principalColumn: "Id");
        }
    }
}
