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
          RegularExpression(@"^[a-zA-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Apenas Letras!")]
        public string NomeAutor { get; set; }

        [Display(Name = "CPF"),
            RegularExpression(@"^(\d{3}.\d{3}.\d{3}-\d{2})|(\d{11})$", ErrorMessage = "CPF em formato inválido.")]
        public string CPF { get; set; }
        public int Celular { get; set; }
        [Display(Name = "E-mail"),
            RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
        public ICollection<Livro> livro { get; set; }
    }
}
