﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteProgramacao.Models;

namespace TesteProgramacao.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteProgramacao.Models.Autor", b =>
                {
                    b.Property<int>("autorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF");

                    b.Property<string>("Celular");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("autorId");

                    b.ToTable("autores");
                });

            modelBuilder.Entity("TesteProgramacao.Models.Editora", b =>
                {
                    b.Property<int>("editoraId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.HasKey("editoraId");

                    b.ToTable("editoras");
                });

            modelBuilder.Entity("TesteProgramacao.Models.Livro", b =>
                {
                    b.Property<int>("livroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtLancamento");

                    b.Property<int>("Edicao");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<int>("autorId");

                    b.Property<int>("editoraId");

                    b.HasKey("livroId");

                    b.HasIndex("autorId");

                    b.HasIndex("editoraId");

                    b.ToTable("livros");
                });

            modelBuilder.Entity("TesteProgramacao.Models.Livro", b =>
                {
                    b.HasOne("TesteProgramacao.Models.Autor", "autores")
                        .WithMany("livros")
                        .HasForeignKey("autorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TesteProgramacao.Models.Editora", "editoras")
                        .WithMany("livros")
                        .HasForeignKey("editoraId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
