using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteProgramacao.Models
{
    public class Livro
    {

     //   Nome do Livro, Edição, Data de Lançamento, Editora e Autor.

        public int livroId { get; set; }
        public string Nome { get; set; }
        public int Edicao { get; set; }
        public DateTime DtLancamento { get; set; }
        public string Email { get; set; }

        public int editoraId { get; set; }
        public int autorId { get; set; }

        public Editora editoras { get; set; }
        public Autor autores { get; set; }
    }
}
