using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1 {
    internal class Cachorro {
        String raca;
        String nome;
        String cor;
        int idade;
        int peso;

        public Cachorro(string raca, string nome, string cor, int idade, int peso) {
            this.raca = raca;
            this.nome = nome;
            this.cor = cor;
            this.idade = idade;
            this.peso = peso;
        }

        public void Latir() {
            MessageBox.Show("Au au au au ...");
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
