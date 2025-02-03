using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_nacional_ModelData_Array_int_Entidades_Feria_NAC_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dataentidades_selection",
                table: "Ferias_Nacional");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dataentidades_selection",
                table: "Ferias_Nacional",
                type: "text",
                nullable: true);
        }
    }
}
