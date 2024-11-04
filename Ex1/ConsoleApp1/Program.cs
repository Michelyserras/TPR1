using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            Carro car1 = new Carro("Volkswagem", "0000", "Bum5225", "azul", 4);
            Moto mot1 = new Moto("Yamaha", "Fazer", "026562", "vermelha", "00000");
            car1.acelerar();
            car1.desligarMotor();
            car1.desacelerar();
            car1.abrirVidro();
            car1.ligarMotor();

            mot1.acelerar();
            mot1.desligarMotor();
            mot1.desacelerar();
            mot1.cortarDeGiro();
            mot1.ligarMotor();



        }
    }
}
