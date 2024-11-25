using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class models_banners_fn__migration_24112024_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "feria_logo",
                table: "Ferias_Nacional_Banners");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "feria_logo",
                table: "Ferias_Nacional_Banners",
                type: "bytea",
                nullable: true);
        }
    }
}
