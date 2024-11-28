using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    internal class Cliente
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private int Idade { get; set; }
        private int CPF { get; set; }

        public Cliente(string Nome, int Idade, int CPF)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Idade = Idade;
            this.CPF = CPF;

        }

        public void exibirCliente()
        {
            Console.WriteLine($"Cliente: \n\t Id: {Id} \n\t Nome: {Nome} \n\t Idade: {Idade} \n\t CPF: {CPF}");
        }




    }
}
