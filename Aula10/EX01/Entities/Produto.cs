using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities
{
    class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
