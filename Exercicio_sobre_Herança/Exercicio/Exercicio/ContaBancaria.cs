using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class ContaBancaria
    {
        private int agencia;
        private int conta;
        private double saldo;
        private string titular;

        public ContaBancaria(int agencia, int conta, double saldo, string titular)
        {
            this.agencia = agencia;
            this.conta = conta;
            this.saldo = saldo;
            this.titular = titular;

        }

        public int Agecia
        {
            get { return agencia; }
            set { agencia = value; }
        }

        public int Conta
        {
            get { return conta; }
            set { conta = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public virtual double calcularNovoSaldo()
        {
            return saldo;
        }
    }
}
