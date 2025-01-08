using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo {
    internal class Guitarra: Produto{

        public string cor { get; set; }
        public int qtdDeCordas{ get; set; }

        public double taxaReajuste { get; set; }

        public Guitarra(int id, string tipo, string marca, double preco, string cor, int qtdDeCordas): base(id, tipo,marca, preco) {
            this.cor = cor;
            this.qtdDeCordas = qtdDeCordas;
            this.taxaReajuste = 0.5;
        }

        public override void exibirProduto() {
            base.exibirProduto();
            Console.WriteLine("Cor: {0}", cor);
            Console.WriteLine("Quantidade de cordas: {0}", qtdDeCordas);
        }
        public override double reajustarPreco() {
            preco *= 1 + (taxaReajuste / 100);
            return preco;
        }
    }
}
