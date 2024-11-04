using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1 {
    internal class Cavalo {
        String raca;
        String nome;
        String pelagem;
        int idade;
        int peso;

        public Cavalo(string raca, string nome, string pelagem, int idade, int peso) {
            this.raca = raca;
            this.nome = nome;
            this.pelagem = pelagem;
            this.idade = idade;
            this.peso = peso;
        }

        public void Relinchar() {
            MessageBox.Show("Ihihihihi...");
        }

        public void Correr() {
            MessageBox.Show("correndo...");
        }

        public void Pular() {
            MessageBox.Show("Pulando..");
        }

        public void FazerCarinho() {
            MessageBox.Show("que carinho bom...");
        }

        public void Comer() {
            MessageBox.Show("Comida boa :) ");
        }
    }
}
