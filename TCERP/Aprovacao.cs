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
            try{
                Conexao.Conectar();
                dataGridView1.DataSource = ClassAprovacao.Selecionar("select * from erp.solicitação_compras");
                txtCD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtCentroCusto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCDsolicitação.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSolicitante.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtProduto.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtDataSolicitação.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                Conexao.Desconectar();

            }
            catch
            {
                MessageBox.Show("ERRO ao carregar o Banco");
            }
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtCentroCusto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCDsolicitação.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSolicitante.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtProduto.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtDataSolicitação.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possivel executar esta ação");
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                ClassAprovacao.InserirStatus(txtAprovacao.Text, int.Parse(txtCD.Text));
                MessageBox.Show("Status Atualizado");
                dataGridView1.DataSource = ClassAprovacao.Selecionar("select * from erp.solicitação_compras");
                Conexao.Desconectar();



                if (dataGridView1.CurrentRow.Cells[10].Value.ToString() == "Aprovado")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Green;
                    }

                }
                else if (dataGridView1.CurrentRow.Cells[10].Value.ToString() == "Reprovado")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Red;
                    }

                }
                else
                {

                    for (int i = 0; i < 11; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = DefaultBackColor;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel atualizar os status da compra,verifique se ha registro de compras");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                ClassAprovacao.RemoverS(int.Parse(txtCD.Text));
                Conexao.Desconectar();
                MessageBox.Show("Status alterado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Não foi possivel Alterar os Status,selecione uma compra para poder alterar");
            }

        }
    }
}
