using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCERP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OBG,volte sempre");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro tela = new Cadastro();
            tela.Show();
            Login tela2 = new Login();
            tela2.Visible = false;
            tela2.Show();
            tela2.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try { 
            string sql = "";
            if(comboBox1.Text == "Docente")
            {
                sql = "select * from erp.cadastro_docente where login_docente ='" + txtUser.Text+"' AND senha_docente='"+txtSenha.Text+"'";
            }
            else if(comboBox1.Text == "Aluno")
            {
                sql = "select * from erp.cadastro_do_aluno WHERE login_aluno='"+txtUser.Text+"' AND senha_aluno='"+txtSenha.Text+"'";
            }
            else
            {
                MessageBox.Show("Escolha um login valido!");
            }

                if (sql.Length > 2)
                {
                    Conexao.Conectar();
                    SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        TelaPrincipal tela = new TelaPrincipal();
                        tela.Show();
                    }
                    else
                    {
                        MessageBox.Show("lOGIN OU SENHA ERRADO!!!");
                    }

                }
                
            }
            catch
            {
                MessageBox.Show("ERRO ao logar,verifique se foi cadastrado corretamente");
            }
          
        }
    }
}
