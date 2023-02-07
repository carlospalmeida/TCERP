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
            Conexao.Conectar();
            dataGridView1.DataSource = ClasSolicitacao.Selecionar("select * from erp.solicitação_compras");
            Conexao.Desconectar();
        }

        private void btnCadastroSolicitacao_Click(object sender, EventArgs e)
        {
            Conexao.Conectar();
            ClasSolicitacao.Inserir(txtdata.Text, txtCodigo.Text, txtFuncionario.Text, txtCentrodeCusto.Text, txtProduto.Text, txtPrioridade.Text, txtDataNecessidade.Text, txtUnidade.Text, txtQuantidade.Text);
            dataGridView1.DataSource = ClasSolicitacao.Selecionar("select * from erp.solicitação_compras");
            Conexao.Desconectar();        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProduto_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView2.Visible = true;
            Conexao.Conectar();
            dataGridView2.DataSource = ClasSolicitacao.Selecionar("select * from erp.cadastros_produtos");
            txtProduto.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProduto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            erp_cd = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dataGridView1.DataSource = ClasSolicitacao.Selecionar("select * from erp.solicitação_compras");
        }
    }
}
