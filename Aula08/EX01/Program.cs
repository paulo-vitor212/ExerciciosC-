using EX01.Entities;
using System;
using System.Collections.Generic;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos estudantes para turma A: ");
            int qtdEstudantes = Convert.ToInt32(Console.ReadLine());
            Curso A = new Curso(AddAlunos(qtdEstudantes));

            Console.Write("Quantos estudantes para turma B: ");
            qtdEstudantes = Convert.ToInt32(Console.ReadLine());
            Curso B = new Curso(AddAlunos(qtdEstudantes));

            Console.Write("Quantos estudantes para turma C: ");
            qtdEstudantes = Convert.ToInt32(Console.ReadLine());
            Curso C = new Curso(AddAlunos(qtdEstudantes));

            List<int> TotalEstudantes = A.Merge(B.alunos, C.alunos);
            Console.WriteLine($"Total de alunos: {TotalEstudantes.Count}");
        }

        public static List<int> AddAlunos(int n)
        {
            List<int> alunos = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Código do {i}º estudante: ");
                alunos.Add(Convert.ToInt32(Console.ReadLine()));
            }

            return alunos;
        }
    }
}
