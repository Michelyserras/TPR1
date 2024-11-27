using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo {
    internal class CestaDeProdutos {
        public List<Produto> listaProdutos { get; set; }
        public double total { get; set; }

        public CestaDeProdutos() {
            this.listaProdutos = new List<Produto>();
            this.total = 0;
        }

        public void AdicionarProduto(Produto p) {
            listaProdutos.Add(p);
        }

        public void ExibirItens() {
            if(listaProdutos.Count > 0) {
                Console.WriteLine("Lista de Produtos: ");
                foreach (Produto p in listaProdutos) {
                    p.exibirProduto();
                    Console.WriteLine("---------------------------");
                }
                Console.WriteLine("\n Total da cesta de compras: {0:c}", CalcularTotal());
            } else {
                Console.WriteLine("A Cesta de compras está vazia!");
            }
            
        }

        public void RemoverProduto(Produto p) {
            if (!listaProdutos.Contains(p)) {
                Console.WriteLine("Esse produto não existe na lista");
                return;
            } else {
                total -= p.preco;
                listaProdutos.Remove(p);
                Console.WriteLine("O produto {0} foi removido com sucesso", p.tipo);
            }

        }
     

        public double CalcularTotal() {
            total = 0;
            foreach(Produto produto in listaProdutos) {
                    total += produto.preco;
                }
            return total;
           
        }
    }
}
