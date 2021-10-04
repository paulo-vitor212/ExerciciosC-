using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities
{
    class Parcela
    {
        private DateTime dataVencimento;
        private double valor;

        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
