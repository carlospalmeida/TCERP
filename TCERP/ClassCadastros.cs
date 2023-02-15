using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCERP
{
    internal class ClassCadastros
    {

        public static void InserirFuncionario(string func_nome, string func_sobrenome, string func_cargo, string func_email, string func_periodo,string func_celular)

        {
            string sql = @"insert into erp.cadastros_de_funcionarios values 
                            (@func_nome,@func_sobrenome,@func_cargo,@func_email,@func_periodo,@func_celular,@Preco_Fixo)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            cmd.Parameters.AddWithValue("func_nome", func_nome);
            cmd.Parameters.AddWithValue("func_sobrenome", func_sobrenome);
            cmd.Parameters.AddWithValue("func_cargo", func_cargo);
            cmd.Parameters.AddWithValue("func_email", func_email);
            cmd.Parameters.AddWithValue("func_periodo", func_periodo);
            cmd.Parameters.AddWithValue("func_celular", func_celular);
            

            cmd.ExecuteNonQuery();
        }

        public static void InserirProduto(string nome_produto, string tipo_produto, string unidade_produto, float quantidade_produto, float preço_produto)
        {
            string sql = @"insert into erp.cadastros_produtos values
                            (@nome_produto,@tipo_produto,@unidade_produto,@quantidade_produto,@preço_produto)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            cmd.Parameters.AddWithValue("nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("tipo_produto", tipo_produto);
            cmd.Parameters.AddWithValue("unidade_produto", unidade_produto);
            cmd.Parameters.AddWithValue("quantidade_produto", quantidade_produto);
            cmd.Parameters.AddWithValue("preço_produto", preço_produto);

            cmd.ExecuteNonQuery();

        }

        public static void InserirFornecedor(string razao_social_forn,string nome_fantasia_forn, string nome_contato_forn, string telefone_1_forn, string telefone_2_forn, string atuação_forn, string cnpj_forn, string fornecimento_forn, string end_forn, string cep_forn, string pais_forn, string uf_forn, string cidade_forn)
        {

            string sql = @"insert into erp.cadastros_fornecedor values
                            (@razao_social_forn,@nome_fantasia_forn,@nome_contato_forn,@telefone_1_forn,@telefone_2_forn,@atuação_forn,@cnpj_forn,@fornecimento_forn,@end_forn,@cep_forn,@pais_forn,@uf_forn,@cidade_forn)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            cmd.Parameters.AddWithValue("razao_social_forn", razao_social_forn);
            cmd.Parameters.AddWithValue("nome_fantasia_forn", nome_fantasia_forn);
            cmd.Parameters.AddWithValue("nome_contato_forn", nome_contato_forn);
            cmd.Parameters.AddWithValue("telefone_1_forn", telefone_1_forn);
            cmd.Parameters.AddWithValue("telefone_2_forn", telefone_2_forn);
            cmd.Parameters.AddWithValue("atuação_forn", atuação_forn);
            cmd.Parameters.AddWithValue("cnpj_forn", cnpj_forn);
            cmd.Parameters.AddWithValue("fornecimento_forn", fornecimento_forn);
            cmd.Parameters.AddWithValue("end_forn", end_forn);
            cmd.Parameters.AddWithValue("cep_forn", cep_forn);
            cmd.Parameters.AddWithValue("pais_forn", pais_forn);
            cmd.Parameters.AddWithValue("uf_forn", uf_forn);
            cmd.Parameters.AddWithValue("cidade_forn", cidade_forn);
            

            cmd.ExecuteNonQuery();


        }


    }
}
