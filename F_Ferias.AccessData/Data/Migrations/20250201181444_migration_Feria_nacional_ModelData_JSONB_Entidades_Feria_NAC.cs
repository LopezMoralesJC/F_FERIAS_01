using F_Ferias.Models.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_nacional_ModelData_JSONB_Entidades_Feria_NAC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Dataentidades_selection_model>(
                name: "Dataentidades_selection_serialize",
                table: "Ferias_Nacional",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "actividad_complementaria",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "talleres_para_personas_buscadoras_empleo",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dataentidades_selection_serialize",
                table: "Ferias_Nacional");

            migrationBuilder.DropColumn(
                name: "actividad_complementaria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "talleres_para_personas_buscadoras_empleo",
                table: "Ferias_Empleo_Local");
        }
    }
}
