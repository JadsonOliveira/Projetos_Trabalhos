using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace CadastroClientes
{
    class DataSet1
    {
    }
    namespace CadastroClientes.DataSet1TableAdapters
    {


        public partial class TB_CLIENTETableAdapter
        {
            public void Insert(string text1, string text2, string text3, string text4, string text5)
            {
                StringBuilder sql = new StringBuilder();

                sql.AppendLine(" INSERT INTO TB_CLIENTE");
                sql.AppendLine(" (NOME");
                sql.AppendLine(" ,ENDERECO");
                sql.AppendLine(" ,TELEFONE");
                sql.AppendLine(" ,DATANASC");
                sql.AppendLine(" ,EMAIL)");
                sql.AppendLine(" VALUES");
                sql.AppendLine(" (@NOME");
                sql.AppendLine(" ,@ENDERECO");
                sql.AppendLine(" ,@TELEFONE");
                sql.AppendLine(" ,@DATANASC");
                sql.AppendLine(" ,@EMAIL)");

                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_TEST;Integrated Security=True"))
                {
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText = sql.ToString();
                        command.CommandType = System.Data.CommandType.Text;

                        var par1 = new SqlParameter("@NOME", SqlDbType.VarChar);
                        par1.Value = text1;
                        command.Parameters.Add(par1);

                        var par2 = new SqlParameter("@ENDERECO", SqlDbType.VarChar);
                        par2.Value = text5;
                        command.Parameters.Add(par2);

                        var par3 = new SqlParameter("@TELEFONE", SqlDbType.VarChar);
                        par3.Value = text4;
                        command.Parameters.Add(par3);

                        var par4 = new SqlParameter("@DATANASC", SqlDbType.VarChar);
                        par4.Value = text2;
                        command.Parameters.Add(par4);

                        var par5 = new SqlParameter("@EMAIL", SqlDbType.VarChar);
                        par5.Value = text3;
                        command.Parameters.Add(par5);

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }

            private void Update(string text1, string text2, string text3, string text4, string text5)
            {

                StringBuilder sql = new StringBuilder();

                sql.AppendLine(" UPDATE TB_CLIENTE");
                sql.AppendLine(" (NOME");
                sql.AppendLine(" ,ENDERECO");
                sql.AppendLine(" ,TELEFONE");
                sql.AppendLine(" ,DATANASC");
                sql.AppendLine(" ,EMAIL)");
                sql.AppendLine(" VALUES");
                sql.AppendLine(" (@NOME");
                sql.AppendLine(" ,@ENDERECO");
                sql.AppendLine(" ,@TELEFONE");
                sql.AppendLine(" ,@DATANASC");
                sql.AppendLine(" ,@EMAIL)");

                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_TEST;Integrated Security=True"))
                {
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText = sql.ToString();
                        command.CommandType = System.Data.CommandType.Text;

                        var par1 = new SqlParameter("@NOME", SqlDbType.VarChar);
                        par1.Value = text1;
                        command.Parameters.Add(par1);

                        var par2 = new SqlParameter("@ENDERECO", SqlDbType.VarChar);
                        par2.Value = text5;
                        command.Parameters.Add(par2);

                        var par3 = new SqlParameter("@TELEFONE", SqlDbType.VarChar);
                        par3.Value = text4;
                        command.Parameters.Add(par3);

                        var par4 = new SqlParameter("@DATANASC", SqlDbType.VarChar);
                        par4.Value = text2;
                        command.Parameters.Add(par4);

                        var par5 = new SqlParameter("@EMAIL", SqlDbType.VarChar);
                        par5.Value = text3;
                        command.Parameters.Add(par5);

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }

            

            public void Consulta()
            {
                StringBuilder sql = new StringBuilder();

                sql.AppendLine(" SELECT * FROM TB_CLIENTE");
            }
        }
    }
}
