using System;
using System.Collections.Generic;
using EX01.Entities;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();
            list.Add(new Produto("TV", 900));
            list.Add(new Produto("Mouse", 50));
            list.Add(new Produto("Tablet", 300));
            list.Add(new Produto("HD Case", 80));

            Action<Produto> act = AumentarValor;
            list.ForEach(act);
            Console.WriteLine("Produtos com valores aumentados em 20% se começar começar com a letra T:");
            ImprimirProdutos(list);

            Console.WriteLine("\n\n");

            list.RemoveAll(p => p.Preco < 100);
            Console.WriteLine("Produtos acima de R$ 100,00:");
            ImprimirProdutos(list);
        }

        public static void AumentarValor(Produto p)
        {
            string firstCharacter = p.Nome.Substring(0, 1).ToUpper();
            if(firstCharacter == "T")
            {
                p.Preco += p.Preco * 0.2;
            }
        }

        public static void ImprimirProdutos(List<Produto> list)
        {
            foreach (Produto produto in list)
            {
                Console.WriteLine($"{produto.Nome}: {produto.Preco:C2}");
            }
        }
    }
}
