using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class models_banners_fn__migration_24112024_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ferias_Nacional_Banners",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    feria_logo_ruta = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    nombre_feria_logo_ruta = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    id_feria_nacional = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferias_Nacional_Banners", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ferias_Nacional_Banners_Ferias_Nacional_id_feria_nacional",
                        column: x => x.id_feria_nacional,
                        principalTable: "Ferias_Nacional",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Nacional_Banners_id_feria_nacional",
                table: "Ferias_Nacional_Banners",
                column: "id_feria_nacional");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ferias_Nacional_Banners");
        }
    }
}
