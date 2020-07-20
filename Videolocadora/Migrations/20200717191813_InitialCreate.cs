using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Videolocadora.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmesAtributos",
                columns: table => new
                {
                    codFilme = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    genero = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    anoLancamento = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    imagem = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    classificacao = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    observacao = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ativo = table.Column<bool>(type: "bit", nullable: false),
                    dataCadastro = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmesAtributos", x => x.codFilme);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmesAtributos");
        }
    }
}
