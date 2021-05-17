using System;
using System.Collections.Generic;
using System.Text;

namespace Lista03Exercicio01.Entities
{
   public class Produto
    {
        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

    }
}
