using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_banners_local_presencial_27012025_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_justificaciones_FK_justificacion_f~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "comentario",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "direccion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "id_ubicacion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "instalacion_nuevas_empresas",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "mano_obra_emporada",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "notificacion_enviada",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "puesto_nueva_creacion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "rotacion_personal",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<int>(
                name: "justificacion_feria",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_justificaciones_FK_justificacion_f~",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria",
                principalTable: "Tipo_justificaciones_FK",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_justificaciones_FK_justificacion_f~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<int>(
                name: "justificacion_feria",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "comentario",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_ubicacion",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "instalacion_nuevas_empresas",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "mano_obra_emporada",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "notificacion_enviada",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "puesto_nueva_creacion",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "rotacion_personal",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_justificaciones_FK_justificacion_f~",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria",
                principalTable: "Tipo_justificaciones_FK",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
