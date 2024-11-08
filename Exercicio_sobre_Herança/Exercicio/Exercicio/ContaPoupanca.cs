using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class ContaPoupanca : ContaBancaria 
    {
        private double taxaJuros;
        public ContaPoupanca(int agencia, int conta, double saldo, string titular) :base(agencia, conta, saldo, titular)
        {
            taxaJuros = 1.10;
        }

        public double TaxaJuros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }


        public override void creditar(double valor)
        {
            base.creditar(valor);
            this.Saldo *= taxaJuros;
            
        }

    }
}
