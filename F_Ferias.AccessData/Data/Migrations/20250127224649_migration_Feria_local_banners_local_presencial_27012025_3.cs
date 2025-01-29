using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migration_Feria_local_banners_local_presencial_27012025_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ferias_Locales_Banners_FK_Ferias_Empleo_Local_ferias_empleo~",
                table: "ferias_Locales_Banners_FK");

            migrationBuilder.DropIndex(
                name: "IX_ferias_Locales_Banners_FK_ferias_empleo_localid",
                table: "ferias_Locales_Banners_FK");

            migrationBuilder.DropColumn(
                name: "ferias_empleo_localid",
                table: "ferias_Locales_Banners_FK");

            migrationBuilder.CreateIndex(
                name: "IX_ferias_Locales_Banners_FK_id_feria_local",
                table: "ferias_Locales_Banners_FK",
                column: "id_feria_local");

            migrationBuilder.AddForeignKey(
                name: "FK_ferias_Locales_Banners_FK_Ferias_Empleo_Local_id_feria_local",
                table: "ferias_Locales_Banners_FK",
                column: "id_feria_local",
                principalTable: "Ferias_Empleo_Local",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ferias_Locales_Banners_FK_Ferias_Empleo_Local_id_feria_local",
                table: "ferias_Locales_Banners_FK");

            migrationBuilder.DropIndex(
                name: "IX_ferias_Locales_Banners_FK_id_feria_local",
                table: "ferias_Locales_Banners_FK");

            migrationBuilder.AddColumn<int>(
                name: "ferias_empleo_localid",
                table: "ferias_Locales_Banners_FK",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ferias_Locales_Banners_FK_ferias_empleo_localid",
                table: "ferias_Locales_Banners_FK",
                column: "ferias_empleo_localid");

            migrationBuilder.AddForeignKey(
                name: "FK_ferias_Locales_Banners_FK_Ferias_Empleo_Local_ferias_empleo~",
                table: "ferias_Locales_Banners_FK",
                column: "ferias_empleo_localid",
                principalTable: "Ferias_Empleo_Local",
                principalColumn: "id");
        }
    }
}
