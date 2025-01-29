using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_banners_local_presencial_27012025_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<int>(
                name: "poblacion_especifica",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                table: "Ferias_Empleo_Local",
                column: "poblacion_especifica",
                principalTable: "Poblacion_Especifica",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AlterColumn<int>(
                name: "poblacion_especifica",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                table: "Ferias_Empleo_Local",
                column: "poblacion_especifica",
                principalTable: "Poblacion_Especifica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
