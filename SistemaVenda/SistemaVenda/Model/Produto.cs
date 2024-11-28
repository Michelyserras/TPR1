using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    internal class Produto
    {
        private int Codigo { get; set; }
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Descricao { get; set; }
        private double Preco { get; set; }

        public Produto(int codigo, string marca, string modelo, string descricao, double preco)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Descricao = descricao;
            Preco = preco;
        }

        public void exibirProduto()
        {
            Console.WriteLine($"Produto: \n\t Código: {Codigo} \n\t Marca: {Marca} \n\t Modelo: {Modelo} \n\t Descrição: {Descricao} \n\t Preço: {Preco:C}");
        }


    }
}
