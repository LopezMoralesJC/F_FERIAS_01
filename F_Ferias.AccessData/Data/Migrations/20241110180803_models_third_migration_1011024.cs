using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class models_third_migration_1011024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_entidad",
                table: "C_FUNCIONARIOS_PORTALEMPLEO",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_C_FUNCIONARIOS_PORTALEMPLEO_id_entidad",
                table: "C_FUNCIONARIOS_PORTALEMPLEO",
                column: "id_entidad");

            migrationBuilder.AddForeignKey(
                name: "FK_C_FUNCIONARIOS_PORTALEMPLEO_entidades_id_entidad",
                table: "C_FUNCIONARIOS_PORTALEMPLEO",
                column: "id_entidad",
                principalTable: "entidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C_FUNCIONARIOS_PORTALEMPLEO_entidades_id_entidad",
                table: "C_FUNCIONARIOS_PORTALEMPLEO");

            migrationBuilder.DropIndex(
                name: "IX_C_FUNCIONARIOS_PORTALEMPLEO_id_entidad",
                table: "C_FUNCIONARIOS_PORTALEMPLEO");

            migrationBuilder.DropColumn(
                name: "id_entidad",
                table: "C_FUNCIONARIOS_PORTALEMPLEO");
        }
    }
}
