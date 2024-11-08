using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class ContaCorrente : ContaBancaria
    {
        private double taxaJuros;

        public ContaCorrente(int agencia, int conta, double saldo, string titular) : base(agencia, conta, saldo, titular)
        {
            this.taxaJuros = 1.10;
        }

        public double TaxaJuros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }

        public override void debitar( double saque)
        {
            if (this.Saldo >= saque+taxaJuros)
            {
                this.Saldo -= saque * taxaJuros; 
            }
        }
    }
}
