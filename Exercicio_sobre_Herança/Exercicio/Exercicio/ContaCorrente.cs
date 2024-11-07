using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class ContaCorrente : ContaBancaria
    {
        int taxaJuros;

        public ContaCorrente(int agencia, int conta, double saldo, string titular) : base(agencia, conta, saldo, titular)
        {
            taxaJuros = 0;
        }

        public int TaxaJuros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }

        public double debitar(int taxa, double saque)
        {
            if (this.Saldo > 0)
            {
                this.Saldo -= saque * (taxa/100); 
                return this.Saldo;
            }
            else
            {
                return 0;
            }
        }
    }
}
