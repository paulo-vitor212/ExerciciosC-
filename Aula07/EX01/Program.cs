using EX01.Entities;
using EX01.Service;
using System;
using System.Collections.Generic;
using System.IO;

namespace EX01
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            string origemArquivoPath = @"..\..\..\..\Funcionarios.txt";
            try
            {
                string[] funcionarios = File.ReadAllLines(origemArquivoPath);

                foreach (string funcionario in funcionarios)
                {
                    string[] arrayLine = funcionario.Split(",");
                    int id = Convert.ToInt32(arrayLine[0]);
                    string name = arrayLine[1];
                    int idade = Convert.ToInt32(arrayLine[2]);
                    Genero genero = arrayLine[3] == "F" ? Genero.F : Genero.M;

                    Funcionario func = new Funcionario(id, name, idade, genero);
    
                    list.Add(func);
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
