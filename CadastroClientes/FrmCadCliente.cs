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
using CadastroClientes.CadastroClientes.DataSet1TableAdapters;
using System.Data.SqlClient;

namespace CadastroClientes
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Btncadastro_Click(object sender, EventArgs e)
        {
            
            try
            {
                TB_CLIENTETableAdapter ta = new TB_CLIENTETableAdapter();
                ta.Insert(txtNome.Text, txtTelefone.Text, txtEndereco.Text, maskDataNasc.Text, txtEmail.Text);
                MessageBox.Show("Registro inserido com Sucesso");
                
               
              
                frmconsulta frm = new frmconsulta();
                frm.Show();
                SqlDataAdapter Sda;
                DataSet dsA = new DataSet();
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DB_TEST;Integrated Security=True");
                


                String sql = "SELECT * FROM TB_CLIENTE";
                Sda = new SqlDataAdapter(sql, conn);



                Sda.Fill(dsA, "TB_CLIENTE");
               
                frm.DgResultado.DataSource = dsA.Tables["TB_CLIENTE"];

                Limpar();
                conn.Close();
                

            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void Btnalterar_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnAlterar_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
        void Limpar()
        {
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            maskDataNasc.Clear();




        }
    }
}
