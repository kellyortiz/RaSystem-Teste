using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace TesteProgramacao.Models
{
    //CPNJ (com validação se é valido ou não) Nome, endereço completo.
    public class Editora
    {
        public int editoraId { get; set; }

        [Display(Name = "CNPJ"),
               RegularExpression(@"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$", ErrorMessage = "CNPJ em formato inválido.")]
        public string CNPJ { get; set; }

        [Display(Name = "Nome da Editora"),
            StringLength(100),
            RegularExpression(@"^[a-zA-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Apenas Letras!")]
        public string NomeEditora { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public ICollection<Livro> livro { get; set; }
    }
}
