using EX02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidato> list = new List<Candidato>();

            string origemArquivoPath = @"..\..\..\..\CandidatosIn.txt";

            try
            {
                string[] candidatos = File.ReadAllLines(origemArquivoPath);
                List<string> nomes = new List<string>();

                foreach (string candidato in candidatos)
                {
                    string[] arrayLine = candidato.Split(",");
                    string nome = arrayLine[0];
                    int votos = Convert.ToInt32(arrayLine[1]);

                    Candidato c = new Candidato
                    {
                        Nome = nome,
                        Votos = votos
                    };

                    nomes.Add(nome);
                    list.Add(c);
                }

                IEnumerable<string> distinctNames = nomes.Distinct();

                foreach (string nome in distinctNames)
                {
                    var total = list.Where(candidato => candidato.Nome == nome).Sum(candidato => candidato.Votos);

                    Console.WriteLine($"{nome}: {total}");
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
