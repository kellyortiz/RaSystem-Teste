using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteProgramacao.Models
{
    public class Livro
    {

     //   Nome do Livro, Edição, Data de Lançamento, Editora e Autor.

        public int livroId { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Edição")]
        public int Edicao { get; set; }

        [Display(Name = "Data de Lançamento"),
        DataType(DataType.Date),
        DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtLancamento { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public int editoraId { get; set; }

        [Display(Name = "Editora")]
        [ForeignKey("editoraId")]

        public int autorId { get; set; }

        [Display(Name = "Autor(a)")]
        [ForeignKey("autorId")]

        public Editora editoras { get; set; }
        public Autor autores { get; set; }
    }
}
