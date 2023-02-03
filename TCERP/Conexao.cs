using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TCERP
{
    internal class Conexao
    {
        public static SqlConnection conn;
        private static string conexao = "" +
            "Data Source = SJC0562941W10-1;" +
            "Initial Catalog = erp_compras;" +
            "User ID = sa;" +
            "Password = Senac123";

        public static void Conectar()
        {
            conn = new SqlConnection(conexao);
            conn.Open();
        }

        public static void Desconectar()
        {
            conn.Close();
        }

    }
}
