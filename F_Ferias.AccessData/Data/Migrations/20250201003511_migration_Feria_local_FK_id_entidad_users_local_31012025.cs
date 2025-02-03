using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_FK_id_entidad_users_local_31012025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_entidad_federativa_pertenece",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_id_entidad_federativa_pertenece",
                table: "AspNetUsers",
                column: "id_entidad_federativa_pertenece");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_entidades_id_entidad_federativa_pertenece",
                table: "AspNetUsers",
                column: "id_entidad_federativa_pertenece",
                principalTable: "entidades",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_entidades_id_entidad_federativa_pertenece",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_id_entidad_federativa_pertenece",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "id_entidad_federativa_pertenece",
                table: "AspNetUsers");
        }
    }
}
