using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1 {
    internal class Moto {
        String marca;
        String modelo;
        String numPlaca;
        String cor;
        String chassi;

        public Moto(string marca, string modelo, string numPlaca, string cor, string chassi) {
            this.marca = marca;
            this.chassi = chassi;
            this.numPlaca = numPlaca;
            this.cor = cor;
            this.modelo = modelo;
        }

        public void acelerar() {
            MessageBox.Show("Acelerando vrooommm...");
        }

        public void desacelerar() {
            MessageBox.Show("Diminuindo a velocidade...");
        }

        public void cortarDeGiro() {
            MessageBox.Show("Uhuuuuuuuu");
        }

        public void desligarMotor() {
            MessageBox.Show("Desligando...");
        }

        public void ligarMotor() {
            MessageBox.Show("Motor ligado...");
        }
    }
}
