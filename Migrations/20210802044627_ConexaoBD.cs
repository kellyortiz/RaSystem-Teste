﻿using System;
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
                    CPF = table.Column<string>(maxLength: 11, nullable: true),
                    Celular = table.Column<int>(maxLength: 11, nullable: false),
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
                    CNPJ = table.Column<string>(maxLength: 14, nullable: true),
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
                    table.PrimaryKey("PK_livro", x => x.livroId);
                    table.ForeignKey(
                        name: "FK_livro_autores_autorId",
                        column: x => x.autorId,
                        principalTable: "autores",
                        principalColumn: "autorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_livro_editoras_editoraId",
                        column: x => x.editoraId,
                        principalTable: "editoras",
                        principalColumn: "editoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_livro_autorId",
                table: "livro",
                column: "autorId");

            migrationBuilder.CreateIndex(
                name: "IX_livro_editoraId",
                table: "livro",
                column: "editoraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livro");

            migrationBuilder.DropTable(
                name: "autores");

            migrationBuilder.DropTable(
                name: "editoras");
        }
    }
}
