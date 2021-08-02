using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteProgramacao.Migrations
{
    public partial class ConexaoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autores",
                columns: table => new
                {
                    autorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeAutor = table.Column<string>(maxLength: 100, nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Celular = table.Column<int>(nullable: false),
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
                    NomeEditora = table.Column<string>(maxLength: 100, nullable: true),
                    Endereco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_editoras", x => x.editoraId);
                });

            migrationBuilder.CreateTable(
                name: "livro",
                columns: table => new
                {
                    livroId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Edicao = table.Column<int>(nullable: false),
                    DtLancamento = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    editoraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    autorId = table.Column<int>(nullable: false),
                    autoresautorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro", x => x.editoraId);
                    table.UniqueConstraint("AK_livro_autorId", x => x.autorId);
                    table.ForeignKey(
                        name: "FK_livro_editoras_autorId",
                        column: x => x.autorId,
                        principalTable: "editoras",
                        principalColumn: "editoraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_livro_autores_autoresautorId",
                        column: x => x.autoresautorId,
                        principalTable: "autores",
                        principalColumn: "autorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_livro_autoresautorId",
                table: "livro",
                column: "autoresautorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livro");

            migrationBuilder.DropTable(
                name: "editoras");

            migrationBuilder.DropTable(
                name: "autores");
        }
    }
}
