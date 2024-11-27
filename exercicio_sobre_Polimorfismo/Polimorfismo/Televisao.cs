using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo {
    internal class Televisao: Produto{

        public string resolucao { get; set; }
        public string tamanhoDaTela { get; set; }

        public double taxaReajuste { get; set; }

        public Televisao(int id, string tipo, string marca, double preco, string resolucao, string tamanhoDaTela): base(id,tipo,marca, preco) {
            this.resolucao = resolucao;
            this.tamanhoDaTela = tamanhoDaTela;
            this.taxaReajuste = 1.0;
        }

        public override void exibirProduto() {
            base.exibirProduto();
            Console.WriteLine("Resolução: {0}", resolucao);
            Console.WriteLine("Tamanho da Tela: {0}", tamanhoDaTela);
        }
        public override double reajustarPreco() {
            preco *= 1 + (taxaReajuste / 100);
            return preco;
        }
    }
}
