using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCERP
{
    internal class ClassAprovacao
    {

        public static DataTable Selecionar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;

        }

        public static void InserirStatus(string status_de_solicitação, int ID)
        {
            string sql = @"update erp.solicitação_compras set status_de_solicitação = @status_de_solicitação where erp_cd = @erp_cd";
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            cmd.Parameters.AddWithValue("status_de_solicitação",status_de_solicitação);
            cmd.Parameters.AddWithValue("erp_cd", ID);

            cmd.ExecuteNonQuery();



        }

        public static void RemoverS(int ID)
        {
            string sql = @"update erp.solicitação_compras set status_de_solicitação = '' where erp_cd = @erp_cd";
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            cmd.Parameters.AddWithValue("erp_cd",ID);

            cmd.ExecuteNonQuery();
        }

    }
}
