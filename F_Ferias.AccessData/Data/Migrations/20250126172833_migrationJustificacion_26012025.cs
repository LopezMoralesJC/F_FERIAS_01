using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migrationJustificacion_26012025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Inversion_id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropIndex(
                name: "IX_Ferias_Empleo_Local_id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "id_feria_inversion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "otra_justificacion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AddColumn<int>(
                name: "justificacion_feria",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoDiscapacidadjustificaciones_FK",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDiscapacidadjustificaciones_FK", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_justificacion_feria",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_TipoDiscapacidadjustificaciones_FK_just~",
                table: "Ferias_Empleo_Local",
                column: "justificacion_feria",
                principalTable: "TipoDiscapacidadjustificaciones_FK",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_TipoDiscapacidadjustificaciones_FK_just~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropTable(
                name: "TipoDiscapacidadjustificaciones_FK");

            migrationBuilder.DropIndex(
                name: "IX_Ferias_Empleo_Local_justificacion_feria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "justificacion_feria",
                table: "Ferias_Empleo_Local");

            migrationBuilder.AddColumn<int>(
                name: "id_feria_inversion",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "otra_justificacion",
                table: "Ferias_Empleo_Local",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_feria_inversion",
                table: "Ferias_Empleo_Local",
                column: "id_feria_inversion");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_Feria_Inversion_id_feria_inversion",
                table: "Ferias_Empleo_Local",
                column: "id_feria_inversion",
                principalTable: "Feria_Inversion",
                principalColumn: "id");
        }
    }
}
