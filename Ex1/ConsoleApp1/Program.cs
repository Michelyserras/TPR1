using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            Carro car1 = new Carro("Volkswagem", "0000", "Bum5225", "azul", 4);

            car1.acelerar();

        }
    }
}
