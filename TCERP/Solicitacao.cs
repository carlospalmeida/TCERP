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
    public partial class Solicitacao : Form
    {
        private int erp_cd = 0;
        public Solicitacao()
        {
            InitializeComponent();
        }

        private void Solicitacao_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                dataGridView1.DataSource = ClasSolicitacao.Selecionar("select * from erp.solicitação_compras");
                Conexao.Desconectar();
            }
            catch
            {
                MessageBox.Show("Erro no Banco,o Banco não esta online reinicie o software");
            }
        }

        private void btnCadastroSolicitacao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                ClasSolicitacao.Inserir(txtdata.Text, txtCodigo.Text, txtFuncionario.Text, txtCentrodeCusto.Text, txtProduto.Text, txtPrioridade.Text, txtDataNecessidade.Text, txtUnidade.Text, txtQuantidade.Text, "", "");
                dataGridView1.DataSource = ClasSolicitacao.Selecionar("select * from erp.solicitação_compras");
                Conexao.Desconectar();
                MessageBox.Show("Solicitação cadastrada com sucesso");
            }
            catch
            {
                MessageBox.Show("ERRO,Insira Dados validos");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProduto_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dataGridView2.Visible = true;
                Conexao.Conectar();
                dataGridView2.DataSource = ClasSolicitacao.Selecionar("select * from erp.cadastros_produtos");
                txtProduto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERRO,Banco não disponivel,cadestre um produto antes");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProduto.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                if (erp_cd > 0)
                {

                    Conexao.Conectar();
                    ClasSolicitacao.Deletar(erp_cd);
                    MessageBox.Show("EXCLUIDO");
                    Conexao.Desconectar();

                }
            }
            catch
            {
                MessageBox.Show("Erro ao excluir,verifique se ja não foi excluido");
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                erp_cd = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = ClasSolicitacao.Selecionar("select * from erp.solicitação_compras");
            }
            catch
            {
                MessageBox.Show("Banco com erro ou indisponivel");
            }
             
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView2.Visible = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
