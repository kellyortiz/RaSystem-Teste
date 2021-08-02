using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteProgramacao.Models
{
    public class Autor
    {
        public int autorId { get; set; }
        [Display(Name = "Nome do Autor"),
          StringLength(100),
          RegularExpression(@"^[a-z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Apenas Letras!")]
        public string NomeAutor { get; set; }

        [Display(Name = "CPF"),
            DisplayFormat(DataFormatString = "{0:###.###.###-##}", ApplyFormatInEditMode = true),
            StringLength(11, MinimumLength = 11)]
        public string CPF { get; set; }

        [Display(Name = "Celular"),
            StringLength(11, MinimumLength = 11)]
        public int Celular { get; set; }

        [Display(Name = "E-mail")]
            [RegularExpression(".+\\@.+\\..+", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
        public ICollection<Livro> livro { get; set; }
    }
}
