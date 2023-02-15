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
    public partial class cotacao : Form
    {
        public cotacao()
        {
            InitializeComponent();
        }

        private void cotacao_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                dataGridView1.DataSource = ClassCotacao.Selecionar("select * from erp.solicitação_compras");
            }
            catch
            {
                MessageBox.Show("Erro ao carregar o Banco,segue as instruções corretamente e verifique se ha cotação");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Conexao.Conectar();
                txtCD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCentro.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCDCentro.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ação incorreta");
            }
        }

        private void txtFornecedor_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtFornecedor_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dataGridView1.Visible = false;
                Conexao.Conectar();
                dataGridView2.Visible = true;
                dataGridView2.DataSource = ClassCotacao.Selecionar("Select * from erp.cadastros_fornecedor");
            }
            catch
            {
                MessageBox.Show("Erro,Banco não disponivel verefique se há cadastro de fornecedor");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtFornecedor.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtCDForncededor.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Erro,ação incorreta");
            }
        }

        private void txtCD_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                Conexao.Conectar();
                dataGridView1.DataSource = ClassCotacao.Selecionar("Select * from erp.solicitação_compras");
            }
            catch
            {
                MessageBox.Show("Ação incorreta,verifique se ha solicitações cadastradas");
            }
        }

        private void btnInserirCotação_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                ClassCotacao.Inserir(int.Parse(txtCDCentro.Text), txtDescricao.Text, int.Parse(txtCD.Text), int.Parse(txtCDForncededor.Text));
            }
            catch
            {
                MessageBox.Show("Insira os dados corretamente");
            }
        }       
    }
}
