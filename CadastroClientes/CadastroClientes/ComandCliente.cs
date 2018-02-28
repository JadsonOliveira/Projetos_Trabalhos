using System.Data.SqlClient;
using System.Text;
namespace CadastroClientes
{
    class ComandCliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Idade { get; set; }
        public string  Email { get; set; }
        public string Sexo { get; set; }


        public void Insert(string nome)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine(" INSERT INTO TB_CLIENTE")
                .AppendLine(" ([NOME]")
                .AppendLine(",[CPF]")
                .AppendLine(" ,[ENDERECO]")
                .AppendLine(",[SEXO]")
                .AppendLine(" ,[Idade]")
                .AppendLine(" ,[TELEFONE_CELULAR])")
                .AppendLine(" VALUES")
                .AppendLine("(@nome")
                .AppendLine(",@cpf")
                .AppendLine(" ,@endereco")
                .AppendLine(" ,@sexo")
                .AppendLine(" ,@idade")
                .AppendLine(" ,@telefone_celular)");


            using (SqlConnection conn = new SqlConnection("Server= jadson-eficiti; Database=DB_CAD_CLIENTE;Integrated Security = True"))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql.ToString();
                    command.Connection = conn;

                    command.Parameters.Add(new SqlParameter("@nome", this.Nome));
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }


        }
    }
}

        
           



      
   
   

   
    

    





    
        
    

