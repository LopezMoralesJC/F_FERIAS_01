using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class models_banners_fn__migration_24112024_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "feria_logo_ruta",
                table: "Ferias_Nacional");

            migrationBuilder.AddColumn<byte>(
                name: "feria_logo",
                table: "Ferias_Nacional_Banners",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "feria_logo",
                table: "Ferias_Nacional_Banners");

            migrationBuilder.AddColumn<string>(
                name: "feria_logo_ruta",
                table: "Ferias_Nacional",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: true);
        }
    }
}
