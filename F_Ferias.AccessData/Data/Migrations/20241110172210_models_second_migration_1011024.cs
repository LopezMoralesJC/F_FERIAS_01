using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class models_second_migration_1011024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_actividad_complementaria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Oficina_AspNetUsers_user_create",
                table: "Oficina");

            migrationBuilder.DropForeignKey(
                name: "FK_Oficina_Ferias_Estatus_estatus",
                table: "Oficina");

            migrationBuilder.DropIndex(
                name: "IX_Oficina_estatus",
                table: "Oficina");

            migrationBuilder.AlterColumn<int>(
                name: "user_create",
                table: "Oficina",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id_actividad_complementaria",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_id_consejero_asignado",
                table: "Oficina",
                column: "id_consejero_asignado");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_actividad_complementaria",
                table: "Ferias_Empleo_Local",
                column: "id_actividad_complementaria",
                principalTable: "Tipo_Recurso",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Oficina_AspNetUsers_id_consejero_asignado",
                table: "Oficina",
                column: "id_consejero_asignado",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Oficina_AspNetUsers_user_create",
                table: "Oficina",
                column: "user_create",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_actividad_complementaria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Oficina_AspNetUsers_id_consejero_asignado",
                table: "Oficina");

            migrationBuilder.DropForeignKey(
                name: "FK_Oficina_AspNetUsers_user_create",
                table: "Oficina");

            migrationBuilder.DropIndex(
                name: "IX_Oficina_id_consejero_asignado",
                table: "Oficina");

            migrationBuilder.AlterColumn<int>(
                name: "user_create",
                table: "Oficina",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_actividad_complementaria",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_estatus",
                table: "Oficina",
                column: "estatus");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_actividad_complementaria",
                table: "Ferias_Empleo_Local",
                column: "id_actividad_complementaria",
                principalTable: "Tipo_Recurso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oficina_AspNetUsers_user_create",
                table: "Oficina",
                column: "user_create",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oficina_Ferias_Estatus_estatus",
                table: "Oficina",
                column: "estatus",
                principalTable: "Ferias_Estatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
