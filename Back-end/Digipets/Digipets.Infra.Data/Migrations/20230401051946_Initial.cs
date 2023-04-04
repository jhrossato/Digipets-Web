using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digipets.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "veterinarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRMV = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_veterinarios_enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tutores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    RG = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    VeterinarioId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tutores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tutores_enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tutores_veterinarios_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "veterinarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "animais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Porte = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Raca = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pelagem = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Castrado = table.Column<bool>(type: "bit", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_animais_tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vacinaAplicadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dose = table.Column<int>(type: "int", nullable: false),
                    DataAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VacinaId = table.Column<int>(type: "int", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacinaAplicadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vacinaAplicadas_animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vacinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vacinas_vacinaAplicadas_Id",
                        column: x => x.Id,
                        principalTable: "vacinaAplicadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_animais_TutorId",
                table: "animais",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_tutores_EnderecoId",
                table: "tutores",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tutores_VeterinarioId",
                table: "tutores",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_vacinaAplicadas_AnimalId",
                table: "vacinaAplicadas",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_veterinarios_EnderecoId",
                table: "veterinarios",
                column: "EnderecoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vacinas");

            migrationBuilder.DropTable(
                name: "vacinaAplicadas");

            migrationBuilder.DropTable(
                name: "animais");

            migrationBuilder.DropTable(
                name: "tutores");

            migrationBuilder.DropTable(
                name: "veterinarios");

            migrationBuilder.DropTable(
                name: "enderecos");
        }
    }
}
