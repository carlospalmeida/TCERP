using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCERP
{
    internal class ClasSolicitacao
    {

        public static void Inserir(string data_, string cd_solicitante, string func_solicitante, string centro_custo, string cd_produtos, string prioridade, string data_de_necessidade, string unidade, string quantidade,string status_de_solicitação,string Fornecedor_cotação)
        {

            string sql = @"insert into erp.solicitação_compras values
                            (@data_,@cd_solicitante,@func_solicitante,@centro_custo,@cd_produtos,@prioridade,@data_de_necessidade,@unidade,@quantidade,@status_de_solicitação,@Fornecedor_cotação)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("data_", data_);
            cmd.Parameters.AddWithValue("cd_solicitante",cd_solicitante);
            cmd.Parameters.AddWithValue("func_solicitante", func_solicitante);
            cmd.Parameters.AddWithValue("centro_custo", centro_custo);
            cmd.Parameters.AddWithValue("cd_produtos", cd_produtos);
            cmd.Parameters.AddWithValue("prioridade", prioridade);
            cmd.Parameters.AddWithValue("data_de_necessidade", data_de_necessidade);
            cmd.Parameters.AddWithValue("unidade", unidade);
            cmd.Parameters.AddWithValue("quantidade", quantidade);
            cmd.Parameters.AddWithValue("status_de_solicitação", status_de_solicitação);
            cmd.Parameters.AddWithValue("Fornecedor_cotação", Fornecedor_cotação);

            cmd.ExecuteNonQuery();

        }

        public static DataTable Selecionar(string sql)
        {


            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;


        }

        public static void Deletar( int erp_cd)
        {
            string sql = @"delete from erp.solicitação_compras where erp_cd=@erp_cd";
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("@erp_cd", erp_cd) ;
            cmd.ExecuteNonQuery();

        }

    }
}
