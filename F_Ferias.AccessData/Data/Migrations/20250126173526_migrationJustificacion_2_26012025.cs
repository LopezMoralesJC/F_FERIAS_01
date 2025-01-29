using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migrationJustificacion_2_26012025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_TipoDiscapacidadjustificaciones_FK_just~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDiscapacidadjustificaciones_FK",
                table: "TipoDiscapacidadjustificaciones_FK");

            migrationBuilder.RenameTable(
                name: "TipoDiscapacidadjustificaciones_FK",
                newName: "Tipo_justificaciones_FK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo_justificaciones_FK",
                table: "Tipo_justificaciones_FK",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_justificaciones_FK_justificacion_f~",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria",
                principalTable: "Tipo_justificaciones_FK",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Tipo_justificaciones_FK_justificacion_f~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo_justificaciones_FK",
                table: "Tipo_justificaciones_FK");

            migrationBuilder.RenameTable(
                name: "Tipo_justificaciones_FK",
                newName: "TipoDiscapacidadjustificaciones_FK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDiscapacidadjustificaciones_FK",
                table: "TipoDiscapacidadjustificaciones_FK",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_TipoDiscapacidadjustificaciones_FK_just~",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria",
                principalTable: "TipoDiscapacidadjustificaciones_FK",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
