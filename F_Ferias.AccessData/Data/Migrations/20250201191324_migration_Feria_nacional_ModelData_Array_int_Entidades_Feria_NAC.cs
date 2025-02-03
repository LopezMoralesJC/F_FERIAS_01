using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_nacional_ModelData_Array_int_Entidades_Feria_NAC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Dataentidades_selection",
                table: "Ferias_Nacional",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "jsonb",
                oldNullable: true);

            migrationBuilder.AddColumn<int[]>(
                name: "data_entidades_selection",
                table: "Ferias_Nacional",
                type: "integer[]",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data_entidades_selection",
                table: "Ferias_Nacional");

            migrationBuilder.AlterColumn<string>(
                name: "Dataentidades_selection",
                table: "Ferias_Nacional",
                type: "jsonb",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
