using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digipets.API.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPIMigration13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Veterinario_VeterinarioId",
                table: "Endereco");

            migrationBuilder.DropTable(
                name: "Vacina");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "Veterinario");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_VeterinarioId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "VeterinarioId",
                table: "Endereco");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VeterinarioId",
                table: "Endereco",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Veterinario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Clinica = table.Column<int>(type: "int", nullable: true),
                    CRMV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veterinario_TB_Clinicas_Id_Clinica",
                        column: x => x.Id_Clinica,
                        principalTable: "TB_Clinicas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Endereco = table.Column<int>(type: "int", nullable: true),
                    Id_Veterinario = table.Column<int>(type: "int", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutor_Endereco_Id_Endereco",
                        column: x => x.Id_Endereco,
                        principalTable: "Endereco",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tutor_Veterinario_Id_Veterinario",
                        column: x => x.Id_Veterinario,
                        principalTable: "Veterinario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Tutor = table.Column<int>(type: "int", nullable: false),
                    Castrado = table.Column<bool>(type: "bit", nullable: true),
                    Especie = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pelagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porte = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Raca = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Tutor_Id_Tutor",
                        column: x => x.Id_Tutor,
                        principalTable: "Tutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Animal = table.Column<int>(type: "int", nullable: false),
                    Data_Aplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dose = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacina_Animal_Id_Animal",
                        column: x => x.Id_Animal,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_VeterinarioId",
                table: "Endereco",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_Id_Tutor",
                table: "Animal",
                column: "Id_Tutor");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_Id_Endereco",
                table: "Tutor",
                column: "Id_Endereco");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_Id_Veterinario",
                table: "Tutor",
                column: "Id_Veterinario");

            migrationBuilder.CreateIndex(
                name: "IX_Vacina_Id_Animal",
                table: "Vacina",
                column: "Id_Animal");

            migrationBuilder.CreateIndex(
                name: "IX_Veterinario_Id_Clinica",
                table: "Veterinario",
                column: "Id_Clinica");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Veterinario_VeterinarioId",
                table: "Endereco",
                column: "VeterinarioId",
                principalTable: "Veterinario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
