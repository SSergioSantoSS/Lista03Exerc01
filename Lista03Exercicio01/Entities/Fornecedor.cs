using System;
using System.Collections.Generic;
using System.Text;

namespace Lista03Exercicio01.Entities
{
    public class Fornecedor
    {
        public Guid IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public Endereco Endereco { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
