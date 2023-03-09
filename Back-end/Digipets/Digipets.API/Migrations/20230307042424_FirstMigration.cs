using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digipets.API.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(28)", maxLength: 28, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(28)", maxLength: 28, nullable: false),
                    CEP = table.Column<int>(type: "int", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_Clinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CRMV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    MAPA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id_Endereco = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false),
                    Id_Admin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Clinicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_Clinicas_TB_Admins_Id_Admin",
                        column: x => x.Id_Admin,
                        principalTable: "TB_Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_Clinicas_TB_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "TB_Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Veterinarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRMV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Id_Clinica = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Veterinarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_Veterinarios_TB_Clinicas_Id_Clinica",
                        column: x => x.Id_Clinica,
                        principalTable: "TB_Clinicas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TB_Tutores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    RG = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    Id_Endereco = table.Column<int>(type: "int", nullable: true),
                    Id_Veterinario = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Tutores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_Tutores_TB_Enderecos_Id_Endereco",
                        column: x => x.Id_Endereco,
                        principalTable: "TB_Enderecos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TB_Tutores_TB_Veterinarios_Id_Veterinario",
                        column: x => x.Id_Veterinario,
                        principalTable: "TB_Veterinarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Animais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Porte = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Raca = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pelagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Castrado = table.Column<bool>(type: "bit", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Tutor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Animais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_Animais_TB_Tutores_Id_Tutor",
                        column: x => x.Id_Tutor,
                        principalTable: "TB_Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Vacinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Dose = table.Column<int>(type: "int", nullable: true),
                    Data_Aplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Animal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Vacinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_Vacinas_TB_Animais_Id_Animal",
                        column: x => x.Id_Animal,
                        principalTable: "TB_Animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Animais_Id_Tutor",
                table: "TB_Animais",
                column: "Id_Tutor");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Clinicas_EnderecoId",
                table: "TB_Clinicas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Clinicas_Id_Admin",
                table: "TB_Clinicas",
                column: "Id_Admin",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_Tutores_Id_Endereco",
                table: "TB_Tutores",
                column: "Id_Endereco");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Tutores_Id_Veterinario",
                table: "TB_Tutores",
                column: "Id_Veterinario");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Vacinas_Id_Animal",
                table: "TB_Vacinas",
                column: "Id_Animal");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Veterinarios_Id_Clinica",
                table: "TB_Veterinarios",
                column: "Id_Clinica");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Vacinas");

            migrationBuilder.DropTable(
                name: "TB_Animais");

            migrationBuilder.DropTable(
                name: "TB_Tutores");

            migrationBuilder.DropTable(
                name: "TB_Veterinarios");

            migrationBuilder.DropTable(
                name: "TB_Clinicas");

            migrationBuilder.DropTable(
                name: "TB_Admins");

            migrationBuilder.DropTable(
                name: "TB_Enderecos");
        }
    }
}
