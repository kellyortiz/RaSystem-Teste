using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteProgramacao.Models
{
    public class Autor
    {
        public int autorId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public ICollection<Livro> livros { get; set; }
    }
}
