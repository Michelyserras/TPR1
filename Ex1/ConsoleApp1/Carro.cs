using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1 {
    internal class Carro {
        String marca;
        String chassi;
        String numPlaca;
        String cor;
        int numPortas;

        public Carro(string marca, string chassi, string numPlaca, string cor, int numPortas) {
            this.marca = marca;
            this.chassi = chassi;
            this.numPlaca = numPlaca;
            this.cor = cor;
            this.numPortas = numPortas;
        }

        public void acelerar() {
            MessageBox.Show("Acelerando vrooommm...");
        }

        public void desacelerar() {
            MessageBox.Show("Diminuindo a velocidade...");
        }

        public void abrirVidro() {
            MessageBox.Show("Vidro aberto..");
        }

        public void desligarMotor() {
            MessageBox.Show("Desligando...");
        }

        public void ligarMotor() {
            MessageBox.Show("Motor ligado...");
        }
    }
}
