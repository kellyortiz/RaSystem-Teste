using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteProgramacao.Migrations
{
    public partial class CriacaoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autores",
                columns: table => new
                {
                    autorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.autorId);
                });

            migrationBuilder.CreateTable(
                name: "editoras",
                columns: table => new
                {
                    editoraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_editoras", x => x.editoraId);
                });

            migrationBuilder.CreateTable(
                name: "livros",
                columns: table => new
                {
                    livroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Edicao = table.Column<int>(nullable: false),
                    DtLancamento = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    editoraId = table.Column<int>(nullable: false),
                    autorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livros", x => x.livroId);
                    table.ForeignKey(
                        name: "FK_livros_autores_autorId",
                        column: x => x.autorId,
                        principalTable: "autores",
                        principalColumn: "autorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_livros_editoras_editoraId",
                        column: x => x.editoraId,
                        principalTable: "editoras",
                        principalColumn: "editoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_livros_autorId",
                table: "livros",
                column: "autorId");

            migrationBuilder.CreateIndex(
                name: "IX_livros_editoraId",
                table: "livros",
                column: "editoraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livros");

            migrationBuilder.DropTable(
                name: "autores");

            migrationBuilder.DropTable(
                name: "editoras");
        }
    }
}
