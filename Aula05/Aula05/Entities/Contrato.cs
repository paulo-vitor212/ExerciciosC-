using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities
{
    class Contrato
    {
        private int numero;
        private DateTime data;
        private double valorTotal;
        private List<Parcela>parcelas = new List<Parcela>();

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            this.Numero = numero;
            this.Data = data;
            this.ValorTotal = valorTotal;
        }

        public int Numero { get => numero; set => numero = value; }
        public DateTime Data { get => data; set => data = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        internal List<Parcela> Parcelas { get => parcelas; set => parcelas = value; }

        public void AdicionarParcela(Parcela parcela)
        {
            Boolean existe = Convert.ToBoolean(parcelas.Find(p => p.Valor == parcela.Valor && p.DataVencimento == parcela.DataVencimento));
            if (!existe)
            {
                parcelas.Add(parcela);
            }
        }
    }
}
