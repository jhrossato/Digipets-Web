using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digipets.API.Migrations
{
    /// <inheritdoc />
    public partial class FirstFluentAPIMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Animais_TB_Tutores_Id_Tutor",
                table: "TB_Animais");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Clinicas_TB_Admins_Id_Admin",
                table: "TB_Clinicas");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Clinicas_TB_Enderecos_EnderecoId",
                table: "TB_Clinicas");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Tutores_TB_Enderecos_Id_Endereco",
                table: "TB_Tutores");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Tutores_TB_Veterinarios_Id_Veterinario",
                table: "TB_Tutores");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Vacinas_TB_Animais_Id_Animal",
                table: "TB_Vacinas");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_Veterinarios_TB_Clinicas_Id_Clinica",
                table: "TB_Veterinarios");

            migrationBuilder.DropIndex(
                name: "IX_TB_Clinicas_EnderecoId",
                table: "TB_Clinicas");

            migrationBuilder.DropIndex(
                name: "IX_TB_Clinicas_Id_Admin",
                table: "TB_Clinicas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Veterinarios",
                table: "TB_Veterinarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Vacinas",
                table: "TB_Vacinas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Tutores",
                table: "TB_Tutores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Enderecos",
                table: "TB_Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Animais",
                table: "TB_Animais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Admins",
                table: "TB_Admins");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "TB_Clinicas");

            migrationBuilder.DropColumn(
                name: "Id_Admin",
                table: "TB_Clinicas");

            migrationBuilder.DropColumn(
                name: "Id_Endereco",
                table: "TB_Clinicas");

            migrationBuilder.RenameTable(
                name: "TB_Veterinarios",
                newName: "Veterinarios");

            migrationBuilder.RenameTable(
                name: "TB_Vacinas",
                newName: "Vacinas");

            migrationBuilder.RenameTable(
                name: "TB_Tutores",
                newName: "Tutores");

            migrationBuilder.RenameTable(
                name: "TB_Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "TB_Animais",
                newName: "Animais");

            migrationBuilder.RenameTable(
                name: "TB_Admins",
                newName: "Admin");

            migrationBuilder.RenameIndex(
                name: "IX_TB_Veterinarios_Id_Clinica",
                table: "Veterinarios",
                newName: "IX_Veterinarios_Id_Clinica");

            migrationBuilder.RenameIndex(
                name: "IX_TB_Vacinas_Id_Animal",
                table: "Vacinas",
                newName: "IX_Vacinas_Id_Animal");

            migrationBuilder.RenameIndex(
                name: "IX_TB_Tutores_Id_Veterinario",
                table: "Tutores",
                newName: "IX_Tutores_Id_Veterinario");

            migrationBuilder.RenameIndex(
                name: "IX_TB_Tutores_Id_Endereco",
                table: "Tutores",
                newName: "IX_Tutores_Id_Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_TB_Animais_Id_Tutor",
                table: "Animais",
                newName: "IX_Animais_Id_Tutor");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "TB_Clinicas",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_Clinicas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "MAPA",
                table: "TB_Clinicas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TB_Clinicas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<string>(
                name: "CRMV",
                table: "TB_Clinicas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "TB_Clinicas",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<int>(
                name: "ClinicaId",
                table: "Endereco",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeterinarioId",
                table: "Endereco",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClinicaId",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animais",
                table: "Animais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ClinicaId",
                table: "Endereco",
                column: "ClinicaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_VeterinarioId",
                table: "Endereco",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_ClinicaId",
                table: "Admin",
                column: "ClinicaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_TB_Clinicas_ClinicaId",
                table: "Admin",
                column: "ClinicaId",
                principalTable: "TB_Clinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Tutores_Id_Tutor",
                table: "Animais",
                column: "Id_Tutor",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_TB_Clinicas_ClinicaId",
                table: "Endereco",
                column: "ClinicaId",
                principalTable: "TB_Clinicas",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_TB_Clinicas_ClinicaId",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Tutores_Id_Tutor",
                table: "Animais");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_TB_Clinicas_ClinicaId",
                table: "Endereco");

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
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_ClinicaId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_VeterinarioId",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animais",
                table: "Animais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropIndex(
                name: "IX_Admin_ClinicaId",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "ClinicaId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "VeterinarioId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "ClinicaId",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Veterinarios",
                newName: "TB_Veterinarios");

            migrationBuilder.RenameTable(
                name: "Vacinas",
                newName: "TB_Vacinas");

            migrationBuilder.RenameTable(
                name: "Tutores",
                newName: "TB_Tutores");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "TB_Enderecos");

            migrationBuilder.RenameTable(
                name: "Animais",
                newName: "TB_Animais");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "TB_Admins");

            migrationBuilder.RenameIndex(
                name: "IX_Veterinarios_Id_Clinica",
                table: "TB_Veterinarios",
                newName: "IX_TB_Veterinarios_Id_Clinica");

            migrationBuilder.RenameIndex(
                name: "IX_Vacinas_Id_Animal",
                table: "TB_Vacinas",
                newName: "IX_TB_Vacinas_Id_Animal");

            migrationBuilder.RenameIndex(
                name: "IX_Tutores_Id_Veterinario",
                table: "TB_Tutores",
                newName: "IX_TB_Tutores_Id_Veterinario");

            migrationBuilder.RenameIndex(
                name: "IX_Tutores_Id_Endereco",
                table: "TB_Tutores",
                newName: "IX_TB_Tutores_Id_Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_Animais_Id_Tutor",
                table: "TB_Animais",
                newName: "IX_TB_Animais_Id_Tutor");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "TB_Clinicas",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_Clinicas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "MAPA",
                table: "TB_Clinicas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TB_Clinicas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<string>(
                name: "CRMV",
                table: "TB_Clinicas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "TB_Clinicas",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "TB_Clinicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Admin",
                table: "TB_Clinicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Endereco",
                table: "TB_Clinicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Veterinarios",
                table: "TB_Veterinarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Vacinas",
                table: "TB_Vacinas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Tutores",
                table: "TB_Tutores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Enderecos",
                table: "TB_Enderecos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Animais",
                table: "TB_Animais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Admins",
                table: "TB_Admins",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Clinicas_EnderecoId",
                table: "TB_Clinicas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Clinicas_Id_Admin",
                table: "TB_Clinicas",
                column: "Id_Admin",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Animais_TB_Tutores_Id_Tutor",
                table: "TB_Animais",
                column: "Id_Tutor",
                principalTable: "TB_Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Clinicas_TB_Admins_Id_Admin",
                table: "TB_Clinicas",
                column: "Id_Admin",
                principalTable: "TB_Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Clinicas_TB_Enderecos_EnderecoId",
                table: "TB_Clinicas",
                column: "EnderecoId",
                principalTable: "TB_Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Tutores_TB_Enderecos_Id_Endereco",
                table: "TB_Tutores",
                column: "Id_Endereco",
                principalTable: "TB_Enderecos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Tutores_TB_Veterinarios_Id_Veterinario",
                table: "TB_Tutores",
                column: "Id_Veterinario",
                principalTable: "TB_Veterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Vacinas_TB_Animais_Id_Animal",
                table: "TB_Vacinas",
                column: "Id_Animal",
                principalTable: "TB_Animais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Veterinarios_TB_Clinicas_Id_Clinica",
                table: "TB_Veterinarios",
                column: "Id_Clinica",
                principalTable: "TB_Clinicas",
                principalColumn: "Id");
        }
    }
}
