using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void login_Click(object sender, EventArgs e) {
            String input = usuarioText.Text.Trim().ToLower();
            String inputSenha = senhaText.Text.Trim().ToLower();

            if (input != null && inputSenha != null) {
                if(input == "root"  && inputSenha == "admin") {
                    MessageBox.Show($"Seja bem-vindo(a) {input}!");
                } else {
                    MessageBox.Show("Usuário ou Senha incorreto!");

                }
            } 
        }
    }
}
