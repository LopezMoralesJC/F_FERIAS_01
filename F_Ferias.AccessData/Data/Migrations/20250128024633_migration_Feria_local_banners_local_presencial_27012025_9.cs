using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_banners_local_presencial_27012025_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_actividad_complementaria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_actividades_Complementarias_id_activida~",
                table: "Ferias_Empleo_Local",
                column: "id_actividad_complementaria",
                principalTable: "actividades_Complementarias",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_actividades_Complementarias_id_activida~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_actividad_complementaria",
                table: "Ferias_Empleo_Local",
                column: "id_actividad_complementaria",
                principalTable: "Tipo_Recurso",
                principalColumn: "Id");
        }
    }
}
