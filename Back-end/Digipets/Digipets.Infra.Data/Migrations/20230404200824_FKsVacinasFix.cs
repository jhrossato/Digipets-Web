using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digipets.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FKsVacinasFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vacinas_vacinaAplicadas_Id",
                table: "vacinas");

            

            migrationBuilder.CreateIndex(
                name: "IX_vacinaAplicadas_VacinaId",
                table: "vacinaAplicadas",
                column: "VacinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_vacinaAplicadas_vacinas_VacinaId",
                table: "vacinaAplicadas",
                column: "VacinaId",
                principalTable: "vacinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vacinaAplicadas_vacinas_VacinaId",
                table: "vacinaAplicadas");

            migrationBuilder.DropIndex(
                name: "IX_vacinaAplicadas_VacinaId",
                table: "vacinaAplicadas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "vacinas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_vacinas_vacinaAplicadas_Id",
                table: "vacinas",
                column: "Id",
                principalTable: "vacinaAplicadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
