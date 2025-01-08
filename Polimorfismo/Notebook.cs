using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo {
    internal class Notebook: Produto{

        public string sistemaOp { get; set; }
        public string processador { get; set; }
        public string capArmazenamento{ get; set; }

        public double taxaReajuste { get; set; }

        public Notebook(int id, string tipo, string marca, double preco, string sistemaOp,  string processador, string capArmazenamento): base(id,tipo,marca, preco) {
            this.sistemaOp = sistemaOp;
            this.processador = processador;
            this.capArmazenamento = capArmazenamento;
            this.taxaReajuste = 2.0;
        }

        public override void exibirProduto() {
            base.exibirProduto();
            Console.WriteLine("Sistema Operacional: {0}", sistemaOp);
            Console.WriteLine("Processador: {0}",processador);
            Console.WriteLine("Capacidade de armazenamento: {0}", capArmazenamento);
        }
        public override double reajustarPreco() {
            preco *= 1 + (taxaReajuste / 100);
            return preco;
        }
    }
}
