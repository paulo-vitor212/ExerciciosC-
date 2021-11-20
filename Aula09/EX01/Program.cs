using EX01.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            string origemArquivoPath = @"..\..\..\..\inProduto.txt";

            try
            {
                string[] produtos = File.ReadAllLines(origemArquivoPath);

                foreach (string produto in produtos)
                {
                    string[] arrayLine = produto.Split(",");
                    string nome = arrayLine[0];
                    double preco = Convert.ToDouble(arrayLine[1]);

                    Produto p = new Produto();
                    p.Nome = nome;
                    p.Preco = preco;
                    list.Add(p);
                }

                CalculationService calculation = new CalculationService();
                Funcionario funcMaisVelho = calculation.Max(list);

                Console.WriteLine($"O funcionário mais velho da empresa é o {funcMaisVelho.Nome} com {funcMaisVelho.Idade} de idade.");


            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
