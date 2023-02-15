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
    public partial class cadastros : Form
    {
        public cadastros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastros_Load(object sender, EventArgs e)
        {
            //Funcionarios
            lbNomeFUNC.Visible = false;
            lbSobrenomeFunc.Visible = false;
            lbCargoFunc.Visible = false;
            lbEmailFunc.Visible = false;
            lbPeriodoFunc.Visible = false;
            lbCelularFunc.Visible = false;
            txtFUNC.Visible = false;
            txtFUNC2.Visible = false;
            txtFUNC3.Visible = false;
            txtFUNC4.Visible = false;
            txtFUNC5.Visible = false;
            txtFUNC6.Visible = false;
            btnCadastrarFuncionario.Visible = false;
            btnGerenciarFuncionario.Visible = false;


            //Fornecedores
            lbRAZ.Visible = false;
            lbNomefan.Visible = false;
            lbNomecont.Visible = false;
            lbTelForn.Visible = false;
            lbTelForn2.Visible = false;
            lbAtuacaoFor.Visible = false;
            lbCNPJFor.Visible = false;
            lbFornceFor.Visible = false;
            lbEnder.Visible = false;
            lbCEPForn.Visible = false;
            lbPaisForn.Visible = false;
            lbEstadoFor.Visible = false;
            lbCityFor.Visible = false;
            txtFornecedor1.Visible = false;
            txtFornecedor2.Visible = false;
            txtFornecedor3.Visible = false;
            txtFornecedor4.Visible = false;
            txtFornecedor5.Visible = false;
            txtFornecedor6.Visible = false;
            txtFornecedor7.Visible = false;
            txtFornecedor8.Visible = false;
            txtFornecedor9.Visible = false;
            txtFornecedor10.Visible = false;
            txtFornecedor11.Visible = false;
            txtFornecedor12.Visible = false;
            txtFornecedor13.Visible = false;
            btnCadastrarFornecedor.Visible = false;
            btnGerenciarFornecedor.Visible = false;

            //produtos
            lbNomePord.Visible = false;
            lbTipoProdu.Visible = false;
            lbUnidadeProdu.Visible = false;
            lbQauntidadeProd.Visible = false;
            lbPreço.Visible = false;
            txtProduto1.Visible = false;
            txtProduto2.Visible = false;
            txtProduto3.Visible = false;
            txtProduto4.Visible = false;
            txtProduto5.Visible = false;
            btnCadastrarProduto.Visible = false;
            btnGerenciarProduto.Visible = false;


            dataGridView1.Visible = false;
            
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                dataGridView1.Visible = true;
                dataGridView1.DataSource = Classcadastro.Selecionar("select * from erp.cadastros_de_funcionarios");
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao Banco,tente novamente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deixar visivel
            lbNomeFUNC.Visible = true;
            lbSobrenomeFunc.Visible = true;
            lbCargoFunc.Visible = true;
            lbEmailFunc.Visible = true;
            lbPeriodoFunc.Visible = true;
            lbCelularFunc.Visible = true;
            txtFUNC.Visible = true;
            txtFUNC2.Visible = true;
            txtFUNC3.Visible = true;
            txtFUNC4.Visible = true;
            txtFUNC5.Visible = true;
            txtFUNC6.Visible = true;
            btnCadastrarFuncionario.Visible = true;
            btnGerenciarFuncionario.Visible = true;

            //deixar invisivel
            lbRAZ.Visible = false;
            lbNomefan.Visible = false;
            lbNomecont.Visible = false;
            lbTelForn.Visible = false;
            lbTelForn2.Visible = false;
            lbAtuacaoFor.Visible = false;
            lbCNPJFor.Visible = false;
            lbFornceFor.Visible = false;
            lbEnder.Visible = false;
            lbCEPForn.Visible = false;
            lbPaisForn.Visible = false;
            lbEstadoFor.Visible = false;
            lbCityFor.Visible = false;
            txtFornecedor1.Visible = false;
            txtFornecedor2.Visible = false;
            txtFornecedor3.Visible = false;
            txtFornecedor4.Visible = false;
            txtFornecedor5.Visible = false;
            txtFornecedor6.Visible = false;
            txtFornecedor7.Visible = false;
            txtFornecedor8.Visible = false;
            txtFornecedor9.Visible = false;
            txtFornecedor10.Visible = false;
            txtFornecedor11.Visible = false;
            txtFornecedor12.Visible = false;
            txtFornecedor13.Visible = false;
            btnCadastrarFornecedor.Visible = false;
            btnGerenciarFornecedor.Visible = false;
            lbNomePord.Visible = false;
            lbTipoProdu.Visible = false;
            lbUnidadeProdu.Visible = false;
            lbQauntidadeProd.Visible = false;
            lbPreço.Visible = false;
            txtProduto1.Visible = false;
            txtProduto2.Visible = false;
            txtProduto3.Visible = false;
            txtProduto4.Visible = false;
            txtProduto5.Visible = false;
            btnCadastrarProduto.Visible = false;
            btnGerenciarProduto.Visible = false;
        }

        private void btnGerenciarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                dataGridView1.Visible = true;
                dataGridView1.DataSource = Classcadastro.Selecionar("select * from erp.cadastros_produtos");
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao Banco,tente novamente");
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            lbNomePord.Visible = true;
            lbTipoProdu.Visible = true;
            lbUnidadeProdu.Visible = true;
            lbQauntidadeProd.Visible = true;
            lbPreço.Visible = true;
            txtProduto1.Visible = true;
            txtProduto2.Visible = true;
            txtProduto3.Visible = true;
            txtProduto4.Visible = true;
            txtProduto5.Visible = true;
            btnCadastrarProduto.Visible = true;
            btnGerenciarProduto.Visible = true;


            //deixar invisivel

            lbNomeFUNC.Visible = false;
            lbSobrenomeFunc.Visible = false;
            lbCargoFunc.Visible = false;
            lbEmailFunc.Visible = false;
            lbPeriodoFunc.Visible = false;
            lbCelularFunc.Visible = false;
            txtFUNC.Visible = false;
            txtFUNC2.Visible = false;
            txtFUNC3.Visible = false;
            txtFUNC4.Visible = false;
            txtFUNC5.Visible = false;
            txtFUNC6.Visible = false;
            btnCadastrarFuncionario.Visible = false;
            btnGerenciarFuncionario.Visible = false;
            lbRAZ.Visible = false;
            lbNomefan.Visible = false;
            lbNomecont.Visible = false;
            lbTelForn.Visible = false;
            lbTelForn2.Visible = false;
            lbAtuacaoFor.Visible = false;
            lbCNPJFor.Visible = false;
            lbFornceFor.Visible = false;
            lbEnder.Visible = false;
            lbCEPForn.Visible = false;
            lbPaisForn.Visible = false;
            lbEstadoFor.Visible = false;
            lbCityFor.Visible = false;
            txtFornecedor1.Visible = false;
            txtFornecedor2.Visible = false;
            txtFornecedor3.Visible = false;
            txtFornecedor4.Visible = false;
            txtFornecedor5.Visible = false;
            txtFornecedor6.Visible = false;
            txtFornecedor7.Visible = false;
            txtFornecedor8.Visible = false;
            txtFornecedor9.Visible = false;
            txtFornecedor10.Visible = false;
            txtFornecedor11.Visible = false;
            txtFornecedor12.Visible = false;
            txtFornecedor13.Visible = false;
            btnCadastrarFornecedor.Visible = false;
            btnGerenciarFornecedor.Visible = false;
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {

            //deixar visivel
            lbRAZ.Visible = true;
            lbNomefan.Visible = true;
            lbNomecont.Visible = true;
            lbTelForn.Visible = true;
            lbTelForn2.Visible = true;
            lbAtuacaoFor.Visible = true;
            lbCNPJFor.Visible = true;
            lbFornceFor.Visible = true;
            lbEnder.Visible = true;
            lbCEPForn.Visible = true;
            lbPaisForn.Visible = true;
            lbEstadoFor.Visible = true;
            lbCityFor.Visible = true;
            txtFornecedor1.Visible = true;
            txtFornecedor2.Visible = true;
            txtFornecedor3.Visible = true;
            txtFornecedor4.Visible = true;
            txtFornecedor5.Visible = true;
            txtFornecedor6.Visible = true;
            txtFornecedor7.Visible = true;
            txtFornecedor8.Visible = true;
            txtFornecedor9.Visible = true;
            txtFornecedor10.Visible = true;
            txtFornecedor11.Visible = true;
            txtFornecedor12.Visible = true;
            txtFornecedor13.Visible = true;
            btnCadastrarFornecedor.Visible = true;
            btnGerenciarFornecedor.Visible = true;
            lbPreço.Visible = true;
          

            //deixar invisivel
            lbNomePord.Visible = false;
            lbTipoProdu.Visible = false;
            lbUnidadeProdu.Visible = false;
            lbQauntidadeProd.Visible = false;
            lbPreço.Visible = false;
            txtProduto1.Visible = false;
            txtProduto2.Visible = false;
            txtProduto3.Visible = false;
            txtProduto4.Visible = false;
            txtProduto5.Visible = false;
            btnCadastrarProduto.Visible = false;
            btnGerenciarProduto.Visible = false;
            lbNomeFUNC.Visible = false;
            lbSobrenomeFunc.Visible = false;
            lbCargoFunc.Visible = false;
            lbEmailFunc.Visible = false;
            lbPeriodoFunc.Visible = false;
            lbCelularFunc.Visible = false;
            txtFUNC.Visible = false;
            txtFUNC2.Visible = false;
            txtFUNC3.Visible = false;
            txtFUNC4.Visible = false;
            txtFUNC5.Visible = false;
            txtFUNC6.Visible = false;
            btnCadastrarFuncionario.Visible = false;
            btnGerenciarFuncionario.Visible = false;


        }

        private void btnGerenciarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                dataGridView1.Visible = true;
                dataGridView1.DataSource = Classcadastro.Selecionar("select * from erp.cadastros_fornecedor");
            }
            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao Banco,tente novamente");
            }
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                ClassCadastros.InserirFuncionario(txtFUNC.Text, txtFUNC2.Text, txtFUNC3.Text, txtFUNC4.Text, txtFUNC5.Text, txtFUNC6.Text);
                Conexao.Desconectar();
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch
            {
                MessageBox.Show("Insira os dados corretamente para efetuar o cadastro de seu Funcionario");
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                ClassCadastros.InserirProduto(txtProduto1.Text, txtProduto2.Text, txtProduto3.Text, float.Parse(txtProduto4.Text), float.Parse(txtProduto5.Text));
                Conexao.Desconectar();
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch
            {
                MessageBox.Show("Insira Dados validos para efetuar o Cadastro de produto");
            }

        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                ClassCadastros.InserirFornecedor(txtFornecedor1.Text, txtFornecedor2.Text, txtFornecedor3.Text, txtFornecedor4.Text, txtFornecedor5.Text, txtFornecedor6.Text, txtFornecedor7.Text, txtFornecedor8.Text, txtFornecedor9.Text, txtFornecedor10.Text, txtFornecedor11.Text, txtFornecedor12.Text, txtFornecedor13.Text);
                Conexao.Desconectar();
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch
            {
                MessageBox.Show("Insira Dados Validos para efutar cadastro de fornecedores");
            }
        }
    }
}
