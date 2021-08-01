using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteProgramacao.Models
{
    //CPNJ (com validação se é valido ou não) Nome, endereço completo.
    public class Editora
    {
        public int editoraId { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public ICollection<Livro> livros { get; set; }
    }
}
