using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class ContaPoupanca : ContaBancaria 
    {
        private int taxaJuros;
        public ContaPoupanca(int agencia, int conta, double saldo, string titular) :base(agencia, conta, saldo, titular)
        {
            taxaJuros = 0;
        }

        public double calcularNovoSaldo(double taxa, double novoSaldo)
        {
            return this.Saldo += novoSaldo * (taxa/100);
        }

    }
}
