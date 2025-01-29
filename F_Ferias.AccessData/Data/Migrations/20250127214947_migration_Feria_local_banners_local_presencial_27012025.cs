using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_banners_local_presencial_27012025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_actividad_Economica_Feria_actividad_eco~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "feria_logo",
                table: "Ferias_Empleo_Local");

            migrationBuilder.RenameColumn(
                name: "zona",
                table: "Ferias_Empleo_Local",
                newName: "numeroInt");

            migrationBuilder.RenameColumn(
                name: "asentamiento",
                table: "Ferias_Empleo_Local",
                newName: "numeroExt");

            migrationBuilder.AlterColumn<string>(
                name: "vialidad",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "actividad_economica",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "calle",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "colonia",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_entidad_federativa_feria_local",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "municipio",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "referencias_direccion",
                table: "Ferias_Empleo_Local",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ferias_Locales_Banners_FK",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    feria_logo_ruta = table.Column<string>(type: "text", nullable: true),
                    nombre_feria_logo_ruta = table.Column<string>(type: "text", nullable: true),
                    id_feria_local = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ferias_Locales_Banners_FK", x => x.id);
                    table.ForeignKey(
                        name: "FK_ferias_Locales_Banners_FK_Ferias_Empleo_Local_id_feria_local",
                        column: x => x.id_feria_local,
                        principalTable: "Ferias_Empleo_Local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_entidad_federativa_feria_local",
                table: "Ferias_Empleo_Local",
                column: "id_entidad_federativa_feria_local");

            migrationBuilder.CreateIndex(
                name: "IX_ferias_Locales_Banners_FK_id_feria_local",
                table: "ferias_Locales_Banners_FK",
                column: "id_feria_local");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_actividad_Economica_Feria_actividad_eco~",
                table: "Ferias_Empleo_Local",
                column: "actividad_economica",
                principalTable: "actividad_Economica_Feria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad_federativa_feria_l~",
                table: "Ferias_Empleo_Local",
                column: "id_entidad_federativa_feria_local",
                principalTable: "entidades",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_actividad_Economica_Feria_actividad_eco~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Ferias_Empleo_Local_entidades_id_entidad_federativa_feria_l~",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropTable(
                name: "ferias_Locales_Banners_FK");

            migrationBuilder.DropIndex(
                name: "IX_Ferias_Empleo_Local_id_entidad_federativa_feria_local",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "calle",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "colonia",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "id_entidad_federativa_feria_local",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "municipio",
                table: "Ferias_Empleo_Local");

            migrationBuilder.DropColumn(
                name: "referencias_direccion",
                table: "Ferias_Empleo_Local");

            migrationBuilder.RenameColumn(
                name: "numeroInt",
                table: "Ferias_Empleo_Local",
                newName: "zona");

            migrationBuilder.RenameColumn(
                name: "numeroExt",
                table: "Ferias_Empleo_Local",
                newName: "asentamiento");

            migrationBuilder.AlterColumn<int>(
                name: "vialidad",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "actividad_economica",
                table: "Ferias_Empleo_Local",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "feria_logo",
                table: "Ferias_Empleo_Local",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddForeignKey(
                name: "FK_Ferias_Empleo_Local_actividad_Economica_Feria_actividad_eco~",
                table: "Ferias_Empleo_Local",
                column: "actividad_economica",
                principalTable: "actividad_Economica_Feria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
