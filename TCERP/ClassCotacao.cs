using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCERP
{
    internal class ClassCotacao
    {
        public static DataTable Selecionar(string sql)
        {

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public static void Inserir(int cd_centro_custo, string descrição_cot, int cd_solicitacao, int cd_fornecedor)
        {
            string sql = @"insert into erp.cotação values
                            (@cd_centro_custo,@descrição_cot,@cd_solicitacao,@cd_fornecedor)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("cd_centro_custo", cd_centro_custo);
            cmd.Parameters.AddWithValue("descrição_cot", descrição_cot);
            cmd.Parameters.AddWithValue("cd_solicitacao", cd_solicitacao);
            cmd.Parameters.AddWithValue("cd_fornecedor", cd_fornecedor);

            cmd.ExecuteNonQuery();





        }

    }
}
