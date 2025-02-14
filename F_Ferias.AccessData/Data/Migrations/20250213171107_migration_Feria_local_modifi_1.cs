using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_modifi_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_abc_Directorio_id_unidadresponsable",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_AspNetUsers_user_create",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_clasificacion_clasificacion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Modalidad_modalidad",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Tamanio_id_feriatamanio",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Ferias_Estatus_estatus",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<int>(
                name: "user_create",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "tipo_evento",
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

            migrationBuilder.AlterColumn<string>(
                name: "otra_actividad_economica",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "numeroInt",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "numeroExt",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "modalidad",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<bool>(
                name: "misma_cede",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<int>(
                name: "id_unidadresponsable",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_feriatamanio",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_entidad",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "estatus",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<bool>(
                name: "es_virtual",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "es_usne",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "es_osne",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "es_nacional",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<int>(
                name: "clasificacion",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<bool>(
                name: "evento_virtual_portal_empleo",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_abc_Directorio_id_unidadresponsable",
                table: "Ferias_Empleo_Local",
                column: "id_unidadresponsable",
                principalTable: "abc_Directorio",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_AspNetUsers_user_create",
                table: "Ferias_Empleo_Local",
                column: "user_create",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_clasificacion_clasificacion",
                table: "Ferias_Empleo_Local",
                column: "clasificacion",
                principalTable: "clasificacion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad",
                table: "Ferias_Empleo_Local",
                column: "id_entidad",
                principalTable: "entidades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Modalidad_modalidad",
                table: "Ferias_Empleo_Local",
                column: "modalidad",
                principalTable: "Feria_Modalidad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Tamanio_id_feriatamanio",
                table: "Ferias_Empleo_Local",
                column: "id_feriatamanio",
                principalTable: "Feria_Tamanio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Ferias_Estatus_estatus",
                table: "Ferias_Empleo_Local",
                column: "estatus",
                principalTable: "Ferias_Estatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                table: "Ferias_Empleo_Local",
                column: "tipo_evento",
                principalTable: "Tipo_Evento_Feria",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_abc_Directorio_id_unidadresponsable",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_AspNetUsers_user_create",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_clasificacion_clasificacion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Modalidad_modalidad",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Tamanio_id_feriatamanio",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Ferias_Estatus_estatus",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "evento_virtual_portal_empleo",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<int>(
                name: "user_create",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "tipo_evento",
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

            migrationBuilder.AlterColumn<string>(
                name: "otra_actividad_economica",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "numeroInt",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "numeroExt",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modalidad",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "misma_cede",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_unidadresponsable",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_feriatamanio",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_entidad",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "estatus",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "es_virtual",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "es_usne",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "es_osne",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "es_nacional",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "clasificacion",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_abc_Directorio_id_unidadresponsable",
                table: "Ferias_Empleo_Local",
                column: "id_unidadresponsable",
                principalTable: "abc_Directorio",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_AspNetUsers_user_create",
                table: "Ferias_Empleo_Local",
                column: "user_create",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_clasificacion_clasificacion",
                table: "Ferias_Empleo_Local",
                column: "clasificacion",
                principalTable: "clasificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad",
                table: "Ferias_Empleo_Local",
                column: "id_entidad",
                principalTable: "entidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Modalidad_modalidad",
                table: "Ferias_Empleo_Local",
                column: "modalidad",
                principalTable: "Feria_Modalidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Tamanio_id_feriatamanio",
                table: "Ferias_Empleo_Local",
                column: "id_feriatamanio",
                principalTable: "Feria_Tamanio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Ferias_Estatus_estatus",
                table: "Ferias_Empleo_Local",
                column: "estatus",
                principalTable: "Ferias_Estatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                table: "Ferias_Empleo_Local",
                column: "tipo_evento",
                principalTable: "Tipo_Evento_Feria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
