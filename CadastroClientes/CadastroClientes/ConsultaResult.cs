using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CadastroClientes.Properties
{
    class ConsultaResult 
    {
        

        public void ConsultaGrid()
        {
            SqlConnection conn = Connection.ObterConexao();

            SqlDataAdapter Sda;
            DataSet dsA = new DataSet();
            
            conn.Open();



            String sql = "SELECT * FROM TB_PRODUTOS";
            Sda = new SqlDataAdapter (sql, conn);



            


        }

       

        private void BtnConsulta_Click(object sender, EventArgs e)
        {

        }
    }








}
