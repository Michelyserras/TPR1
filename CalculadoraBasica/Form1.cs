using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        private void calcular(char operacao) {
            

            try {
                decimal valor1 = decimal.Parse(val1.Text.Trim());
                decimal valor2 = decimal.Parse(val2.Text.Trim());
                decimal resultado = 0;

                switch (operacao) {
                    case '+' :
                        resultado = valor1 + valor2;
                        break;
                    case '-':
                        resultado = valor1 - valor2;
                        break;
                    case '*':
                        resultado = valor1 * valor2;
                        break;
                    case '/':
                        if(valor2 == 0) {
                            labelResultado.Text = "Não é possível dividir por 0";
                            return;
                        }
                        resultado = valor1 / valor2;
                        break;
                }
                labelResultado.Text = resultado.ToString();
            } catch (FormatException) {
                labelResultado.Text = "Erro: informe apenas números";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void soma_Click_1(object sender, EventArgs e) {
            calcular('+');
        }

        private void subtrair_Click_1(object sender, EventArgs e) {
            calcular('-');
        }

        private void dividir_Click_1(object sender, EventArgs e) {
            calcular('/');
        }

        private void multiplicar_Click_1(object sender, EventArgs e) {
            calcular('*');
        }
    }
}
