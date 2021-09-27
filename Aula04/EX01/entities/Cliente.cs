using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.entities
{
    class Cliente
    {
        private string nome;
        private string email;
        private DateTime dataNascimento;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    }
}
