using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digipets.API.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPIMigration12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Tutores_Id_Tutor",
                table: "Animais");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Veterinarios_VeterinarioId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutores_Endereco_Id_Endereco",
                table: "Tutores");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutores_Veterinarios_Id_Veterinario",
                table: "Tutores");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacinas_Animais_Id_Animal",
                table: "Vacinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinarios_TB_Clinicas_Id_Clinica",
                table: "Veterinarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacinas",
                table: "Vacinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutores",
                table: "Tutores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animais",
                table: "Animais");

            migrationBuilder.RenameTable(
                name: "Veterinarios",
                newName: "Veterinario");

            migrationBuilder.RenameTable(
                name: "Vacinas",
                newName: "Vacina");

            migrationBuilder.RenameTable(
                name: "Tutores",
                newName: "Tutor");

            migrationBuilder.RenameTable(
                name: "Animais",
                newName: "Animal");

            migrationBuilder.RenameIndex(
                name: "IX_Veterinarios_Id_Clinica",
                table: "Veterinario",
                newName: "IX_Veterinario_Id_Clinica");

            migrationBuilder.RenameIndex(
                name: "IX_Vacinas_Id_Animal",
                table: "Vacina",
                newName: "IX_Vacina_Id_Animal");

            migrationBuilder.RenameIndex(
                name: "IX_Tutores_Id_Veterinario",
                table: "Tutor",
                newName: "IX_Tutor_Id_Veterinario");

            migrationBuilder.RenameIndex(
                name: "IX_Tutores_Id_Endereco",
                table: "Tutor",
                newName: "IX_Tutor_Id_Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_Animais_Id_Tutor",
                table: "Animal",
                newName: "IX_Animal_Id_Tutor");

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Veterinario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Veterinario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Veterinario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Tutor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tutor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Tutor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinario",
                table: "Veterinario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacina",
                table: "Vacina",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutor",
                table: "Tutor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animal",
                table: "Animal",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Tutor_Id_Tutor",
                table: "Animal",
                column: "Id_Tutor",
                principalTable: "Tutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Veterinario_VeterinarioId",
                table: "Endereco",
                column: "VeterinarioId",
                principalTable: "Veterinario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutor_Endereco_Id_Endereco",
                table: "Tutor",
                column: "Id_Endereco",
                principalTable: "Endereco",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tutor_Veterinario_Id_Veterinario",
                table: "Tutor",
                column: "Id_Veterinario",
                principalTable: "Veterinario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacina_Animal_Id_Animal",
                table: "Vacina",
                column: "Id_Animal",
                principalTable: "Animal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinario_TB_Clinicas_Id_Clinica",
                table: "Veterinario",
                column: "Id_Clinica",
                principalTable: "TB_Clinicas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Tutor_Id_Tutor",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Veterinario_VeterinarioId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutor_Endereco_Id_Endereco",
                table: "Tutor");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutor_Veterinario_Id_Veterinario",
                table: "Tutor");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacina_Animal_Id_Animal",
                table: "Vacina");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinario_TB_Clinicas_Id_Clinica",
                table: "Veterinario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterinario",
                table: "Veterinario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacina",
                table: "Vacina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutor",
                table: "Tutor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animal",
                table: "Animal");

            migrationBuilder.RenameTable(
                name: "Veterinario",
                newName: "Veterinarios");

            migrationBuilder.RenameTable(
                name: "Vacina",
                newName: "Vacinas");

            migrationBuilder.RenameTable(
                name: "Tutor",
                newName: "Tutores");

            migrationBuilder.RenameTable(
                name: "Animal",
                newName: "Animais");

            migrationBuilder.RenameIndex(
                name: "IX_Veterinario_Id_Clinica",
                table: "Veterinarios",
                newName: "IX_Veterinarios_Id_Clinica");

            migrationBuilder.RenameIndex(
                name: "IX_Vacina_Id_Animal",
                table: "Vacinas",
                newName: "IX_Vacinas_Id_Animal");

            migrationBuilder.RenameIndex(
                name: "IX_Tutor_Id_Veterinario",
                table: "Tutores",
                newName: "IX_Tutores_Id_Veterinario");

            migrationBuilder.RenameIndex(
                name: "IX_Tutor_Id_Endereco",
                table: "Tutores",
                newName: "IX_Tutores_Id_Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_Animal_Id_Tutor",
                table: "Animais",
                newName: "IX_Animais_Id_Tutor");

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Admin",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Admin",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Admin",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Veterinarios",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Veterinarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Veterinarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Tutores",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tutores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Tutores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacinas",
                table: "Vacinas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutores",
                table: "Tutores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animais",
                table: "Animais",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Tutores_Id_Tutor",
                table: "Animais",
                column: "Id_Tutor",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Veterinarios_VeterinarioId",
                table: "Endereco",
                column: "VeterinarioId",
                principalTable: "Veterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutores_Endereco_Id_Endereco",
                table: "Tutores",
                column: "Id_Endereco",
                principalTable: "Endereco",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tutores_Veterinarios_Id_Veterinario",
                table: "Tutores",
                column: "Id_Veterinario",
                principalTable: "Veterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacinas_Animais_Id_Animal",
                table: "Vacinas",
                column: "Id_Animal",
                principalTable: "Animais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinarios_TB_Clinicas_Id_Clinica",
                table: "Veterinarios",
                column: "Id_Clinica",
                principalTable: "TB_Clinicas",
                principalColumn: "Id");
        }
    }
}
