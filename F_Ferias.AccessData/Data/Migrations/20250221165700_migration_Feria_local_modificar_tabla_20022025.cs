using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_modificar_tabla_20022025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "observacion_recurso_estatal",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "observacion_promocion_estatal",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_alquiler_est",
                table: "Ferias_Empleo_Local",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "observacion_alquiler_est",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidad_alquiler_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "observacion_alquiler_est",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<string>(
                name: "observacion_recurso_estatal",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "observacion_promocion_estatal",
                table: "Ferias_Empleo_Local",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
