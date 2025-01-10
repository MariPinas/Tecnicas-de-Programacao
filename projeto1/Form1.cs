using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1
{
    public partial class Form1 : Form
    {

        private int nroImagem = 0;
        private int totalImagens = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //imagem0 - > imagem1 -> imagem2 - > imagem3 - > imagem0
            nroImagem=(nroImagem + 1) % totalImagens;
            pbImagem.Image = (Image) Properties.Resources.ResourceManager.GetObject(String.Format("foto{0}", nroImagem));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nroImagem = nroImagem == 0 ? totalImagens - 1 : nroImagem-1;
            pbImagem.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("foto{0}", nroImagem));
        }
    }
}
