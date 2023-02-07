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
    public partial class Aprovacao : Form
    {
        public Aprovacao()
        {
            InitializeComponent();
        }

        private void Aprovacao_Load(object sender, EventArgs e)
        {
            Conexao.Conectar();
            dataGridView1.DataSource = ClassAprovacao.Selecionar("select * from erp.solicitação_compras");
            txtCentroCusto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCDsolicitação.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSolicitante.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtProduto.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtDataSolicitação.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            Conexao.Desconectar();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCentroCusto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCDsolicitação.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSolicitante.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtProduto.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtDataSolicitação.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
