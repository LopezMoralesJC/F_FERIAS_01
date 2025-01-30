using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class _migration_30012025_Perfiles_Estatus_Asociar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_perfil_asignado",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_rol = table.Column<string>(type: "text", nullable: true),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    estatus = table.Column<int>(type: "integer", nullable: false),
                    user_created = table.Column<int>(type: "integer", nullable: true),
                    user_create = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfiles_AspNetUsers_user_create",
                        column: x => x.user_create,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Perfiles_Estatus_user_created",
                        column: x => x.user_created,
                        principalTable: "Estatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_id_perfil_asignado",
                table: "AspNetUsers",
                column: "id_perfil_asignado");

            migrationBuilder.CreateIndex(
                name: "IX_Perfiles_user_create",
                table: "Perfiles",
                column: "user_create");

            migrationBuilder.CreateIndex(
                name: "IX_Perfiles_user_created",
                table: "Perfiles",
                column: "user_created");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Perfiles_id_perfil_asignado",
                table: "AspNetUsers",
                column: "id_perfil_asignado",
                principalTable: "Perfiles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Perfiles_id_perfil_asignado",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Perfiles");

            migrationBuilder.DropTable(
                name: "Estatus");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_id_perfil_asignado",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "id_perfil_asignado",
                table: "AspNetUsers");
        }
    }
}
