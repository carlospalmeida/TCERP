using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCERP
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnAumentar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnAumentar.Visible = true;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroAL_Click(object sender, EventArgs e)
        {

        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            lbCurso.Visible =   false;
            lbEmail.Visible =   false;
            lbLogin.Visible =   false;
            lbNome.Visible =    false;
            lbPericur.Visible = false;
            lbSenha.Visible =   false;
            lbSobreno.Visible = false;
            lbTele.Visible =    false;
            lbTurma.Visible =   false;

            txtCurso.Visible =    false;
            txtEmail.Visible =    false;
            txtLogin.Visible =    false;
            txtNome.Visible =     false;
            txtPerioCur.Visible = false;
            txtSenha.Visible =    false;
            txtSobreno.Visible =  false;
            txtTel.Visible =      false;
            txtTurma.Visible =    false;
            
            lbCargoDOC.Visible =  true;
            lbLoginDOC.Visible =  true;
            lbSenhaDOC.Visible =  true;
            lbSobrDOC.Visible =   true;
            lbNMdoc.Visible =     true;

            txtNomeDOC.Visible =  true;
            txtSobreDOC.Visible = true;
            txtLoginDOC.Visible = true;
            txtSenhDOC.Visible =  true;
            txtCargoDOC.Visible = true;

            btnCadastroDOC.Visible = true;
            btNCadastroAl.Visible = false;

        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            lbCurso.Visible =   true;
            lbEmail.Visible =   true;
            lbLogin.Visible =   true;
            lbNome.Visible =    true;
            lbPericur.Visible = true;
            lbSenha.Visible =   true;
            lbSobreno.Visible = true;
            lbTele.Visible =    true;
            lbTurma.Visible =   true;

            txtCurso.Visible =    true;
            txtEmail.Visible =    true;
            txtLogin.Visible =    true;
            txtNome.Visible =     true;
            txtPerioCur.Visible = true;
            txtSenha.Visible =    true;
            txtSobreno.Visible =  true;
            txtTel.Visible =      true;
            txtTurma.Visible =    true;

            lbCargoDOC.Visible =  false;
            lbLoginDOC.Visible =  false;
            lbSenhaDOC.Visible =  false;
            lbSobrDOC.Visible =   false;
            lbNMdoc.Visible =     false;

            txtNomeDOC.Visible =  false;
            txtSobreDOC.Visible = false;
            txtLoginDOC.Visible = false;
            txtSenhDOC.Visible =  false;
            txtCargoDOC.Visible = false;

            btnCadastroDOC.Visible = false;
            btNCadastroAl.Visible = true;                                   
        }

        private void btNCadastroG_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                Classcadastro.Inserir1(txtNome.Text, txtSobreno.Text, txtCurso.Text, txtEmail.Text, txtPerioCur.Text, txtTurma.Text, txtTel.Text, txtLogin.Text, txtSenha.Text);
                MessageBox.Show("Cadastro de Aluno realizado com sucesso!");
                Conexao.Desconectar();
                this.Hide();
                Login tela = new Login();
                tela.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possivel se cadastrar,inisira dados validos");
            }

        }

        private void btnCadastroDOC_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                Classcadastro.Inserir(txtNomeDOC.Text, txtSobreDOC.Text, txtCargoDOC.Text, txtLoginDOC.Text, txtSenhDOC.Text);
                MessageBox.Show("Docente cadastrado com sucesso!");
                Conexao.Desconectar();
                this.Hide();
                Login tela = new Login();
                tela.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possivel se cadastrar,inisira dados validos");
            }

        }
    }
}
