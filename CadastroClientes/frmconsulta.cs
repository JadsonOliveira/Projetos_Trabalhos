using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using CadastroClientes.CadastroClientes.DataSet1TableAdapters;
namespace CadastroClientes
{
    public partial class frmconsulta : Form
    {
        public frmconsulta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter Sda;
                DataSet dsA = new DataSet();
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_TEST;Integrated Security=True");
                conn.Open();

                
                String sql = "SELECT * FROM TB_CLIENTE";
                Sda = new SqlDataAdapter(sql, conn);

                

                Sda.Fill(dsA, "TB_CLIENTE");
                DgResultado.DataSource = dsA.Tables["TB_CLIENTE"];


                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
               
            }
            
        }
       
        
    }
}
