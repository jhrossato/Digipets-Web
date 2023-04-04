using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digipets.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FKsVacinasFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "vacinas",
                type: "int",
                nullable: false
                )
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey("PK_vacinas", "vacinas", "Id");

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

        }
    }
}
