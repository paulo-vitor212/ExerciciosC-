using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities
{
    public enum Genero
    {
        F,
        M
    }
    class Funcionario : IComparable
    {
        private int id;
        private string nome;
        private int idade;
        private Genero genero;

        public Funcionario(int id, string nome, int idade, Genero genero)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public Genero Genero { get => genero; set => genero = value; }

        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario))
            {
                throw new ArgumentException("Erro de comparação");
            }

            Funcionario func = obj as Funcionario;

            return idade.CompareTo(func.idade);
        }
    }
}
