using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digipets.API.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPIMigration14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_TB_Clinicas_ClinicaId",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_TB_Clinicas_ClinicaId",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "TB_Enderecos");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "TB_Admins");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_ClinicaId",
                table: "TB_Enderecos",
                newName: "IX_TB_Enderecos_ClinicaId");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_ClinicaId",
                table: "TB_Admins",
                newName: "IX_TB_Admins_ClinicaId");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "TB_Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Enderecos",
                table: "TB_Enderecos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Admins",
                table: "TB_Admins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Admins_TB_Clinicas_ClinicaId",
                table: "TB_Admins",
                column: "ClinicaId",
                principalTable: "TB_Clinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Enderecos_TB_Clinicas_ClinicaId",
                table: "TB_Enderecos",
                column: "ClinicaId",
                principalTable: "TB_Clinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Admins_TB_Clinicas_ClinicaId",
                table: "TB_Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Enderecos_TB_Clinicas_ClinicaId",
                table: "TB_Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Enderecos",
                table: "TB_Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Admins",
                table: "TB_Admins");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "TB_Enderecos");

            migrationBuilder.RenameTable(
                name: "TB_Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "TB_Admins",
                newName: "Admin");

            migrationBuilder.RenameIndex(
                name: "IX_TB_Enderecos_ClinicaId",
                table: "Endereco",
                newName: "IX_Endereco_ClinicaId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_Admins_ClinicaId",
                table: "Admin",
                newName: "IX_Admin_ClinicaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_TB_Clinicas_ClinicaId",
                table: "Admin",
                column: "ClinicaId",
                principalTable: "TB_Clinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_TB_Clinicas_ClinicaId",
                table: "Endereco",
                column: "ClinicaId",
                principalTable: "TB_Clinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
