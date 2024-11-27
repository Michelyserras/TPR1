using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo {
    internal abstract class Produto {
        public int id { get; set; }
        public string tipo { get; set; }
        public string marca { get; set; }
        public double preco { get; set; }


        public Produto(int id, string tipo, string marca,double preco) {
            this.id = id;
            this.tipo = tipo;
            this.marca = marca;
            this.preco = preco;
        }
        public abstract double reajustarPreco();

        public virtual void exibirProduto() {
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Tipo: {0}", tipo);
            Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("Valor: {0:c}", preco);
        }
    }
}
