using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class form1 : Form
    {
        private int noImagem = 0;
        private int totalImagens = 4;
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //imagem exibida = imagem 0;
            noImagem = (noImagem + 1) % totalImagens;

            pbImagem.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("gatoFeio{0}", noImagem));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (noImagem == 0) {
                noImagem = 0;
            }
            else
            {
                noImagem--;
            }

            pbImagem.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("gatoFeio{0}", noImagem));

        }
    }
}
