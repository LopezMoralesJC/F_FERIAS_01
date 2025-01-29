using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class migrationFeria_inversion_2_26012025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "cantidad_total_est",
                table: "Feria_Inversion",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cantidad_total_federal",
                table: "Feria_Inversion",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidad_total_est",
                table: "Feria_Inversion");

            migrationBuilder.DropColumn(
                name: "cantidad_total_federal",
                table: "Feria_Inversion");
        }
    }
}
