using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCERP
{
    internal class Classcadastro
    {
        

        public static void Inserir1(string nome_aluno,string sobrenome_aluno,string curso_aluno,string email_aluno,string periodo_aluno,string turma_aluno,string celular,string login_aluno,string senha_aluno)
        {
            string sql = @"insert into erp.cadastro_do_aluno values
                            (@nome_aluno,@sobrenome_aluno,@curso_aluno,@email_aluno,@periodo_aluno,@turma_aluno,@celular,@login_aluno,@senha_aluno)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("nome_aluno",       nome_aluno);
            cmd.Parameters.AddWithValue("sobrenome_aluno",    sobrenome_aluno);
            cmd.Parameters.AddWithValue("curso_aluno",      curso_aluno);
            cmd.Parameters.AddWithValue("email_aluno",      email_aluno);
            cmd.Parameters.AddWithValue("periodo_aluno",    periodo_aluno);
            cmd.Parameters.AddWithValue("turma_aluno",      turma_aluno);
            cmd.Parameters.AddWithValue("celular",          celular);
            cmd.Parameters.AddWithValue("login_aluno",      login_aluno);
            cmd.Parameters.AddWithValue("senha_aluno",      senha_aluno);



            cmd.ExecuteNonQuery();


        }

        public static void Inserir(string nome_docente,string sobrenome_docente,string cargo_docente,string login_docente,string senha_docente)

        {
            string sql = @"insert into erp.cadastro_docente values
                            (@nome_docente,@sobrenome_docente,@cargo_docente,@login_docente,@senha_docente)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("nome_docente", nome_docente);
            cmd.Parameters.AddWithValue("sobrenome_docente", sobrenome_docente);
            cmd.Parameters.AddWithValue("cargo_docente", cargo_docente);
            cmd.Parameters.AddWithValue("login_docente", login_docente);
            cmd.Parameters.AddWithValue("senha_docente", senha_docente);

            cmd.ExecuteNonQuery();


        }




        public static DataTable Selecionar(string sql)
        {


            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;


        }



    }
}
