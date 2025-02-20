using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_modificar_tabla_10022025_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_justificacion_feria",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria");

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

            migrationBuilder.DropIndex(
                name: "IX_Ferias_Empleo_Local_justificacion_feria",
                table: "Ferias_Empleo_Local");
        }
    }
}
