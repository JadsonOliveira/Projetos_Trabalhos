using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                String Stringcon = @"Data Source=DESKTOP-AOPO69T;Initial Catalog=DB_CONTROLE_COMPRAS;Integrated Security=True";
                SqlConnection conn = new SqlConnection(Stringcon);
                conn.Open();

                String SQL;
                               
              //  SQL = "Insert Into TB_CLIENTE(Nome,DataNasc,Telefone,Email,Endereco)Values ";
               // SQL += "('" + Nome.Text + "','" + DataNasc.Text + "', '" + Telefone.Text + "','" + Email.Text + "', '" + Endereco.Text + "')";

                //SqlCommand cmd = new SqlCommand(SQL, conn);
                //cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso");

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

        private void button2_Click(object sender, EventArgs e)
        {
            //cliente.Idade = Convert.ToInt32(IdadeText);

            ComandCliente cliente = new ComandCliente();
            cliente.Nome = NomeCadText.Text;
            cliente.Telefone = TelefoneText.Text;
            cliente.Sexo = SexoText.Text;

            cliente.Insert(cliente.Nome);


            //// a conexão foi efetuada com sucesso?
            //if (conn == null)
            //{
            //    MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            //}
            //else
            //{
            //    MessageBox.Show("A conexão foi obtida com sucesso.");

            //}



            //// não precisamos mais da conexão? vamos fechá-la
            //Connection.fecharConexao();
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
