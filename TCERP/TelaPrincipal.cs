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
            AbriFormPainel(new TelaInicial());
        }

        private void DesativarBtn()
        {
            foreach(Control antbtn in MenuPrincipal.Controls)
            {
                if(antbtn.GetType() == typeof(Button))
                {
                    antbtn.BackColor = Color.FromArgb(0,122,204);
                }

            }
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
           
        }

        private void MenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbriFormPainel(object FormFilho)
        {
            if (PainePrincipal.Controls.Count > 0)
            {
                this.PainePrincipal.Controls.RemoveAt(0);
            }
                
            Form tela = FormFilho as Form;
            tela.TopLevel = false;
            tela.Dock = DockStyle.Fill;
            this.PainePrincipal.Controls.Add(tela);
            this.PainePrincipal.Tag = tela;
            tela.Show();
        }
        private void btnGerenciamento_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AbriFormPainel(new Solicitacao());
            btnGerenciamento.BackColor = Color.Blue;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AbriFormPainel(new Aprovacao());
            
            button1.BackColor = Color.Blue;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AbriFormPainel(new cotacao());
            
            button2.BackColor = Color.Blue;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AbriFormPainel(new Analisecotacao());
            
            button3.BackColor = Color.Blue;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AbriFormPainel(new compra());
            
            button4.BackColor = Color.Blue;
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbriFormPainel(new TelaInicial());
            DesativarBtn();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AbriFormPainel(new cadastros());
            
            button5.BackColor = Color.Blue;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado! e volte sempre");
            Application.Exit();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
