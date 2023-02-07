using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TCERP
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MenuPrincipal.Width == 250)
            {
                MenuPrincipal.Width = 60;
            }
            else
            {
                MenuPrincipal.Width = 250;
            }
        }

        private void PainePrincipal_Paint(object sender, PaintEventArgs e)
        {
            AbriFormPainel(new TelaInicial());
        }

        private void MenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbriFormPainel(object FormFilho)
        {
            if (PainePrincipal.Controls.Count > 0)
                this.PainePrincipal.Controls.RemoveAt(0);
            Form tela = FormFilho as Form;
            tela.TopLevel = false;
            tela.Dock = DockStyle.Fill;
            this.PainePrincipal.Controls.Add(tela);
            this.PainePrincipal.Tag = tela;
            tela.Show();
        }
        private void btnGerenciamento_Click(object sender, EventArgs e)
        {
            AbriFormPainel(new Solicitacao());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbriFormPainel(new Aprovacao());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbriFormPainel(new cotacao());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbriFormPainel(new Analisecotacao());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbriFormPainel(new compra());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbriFormPainel(new TelaInicial());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbriFormPainel(new cadastros());
        }
    }
}
