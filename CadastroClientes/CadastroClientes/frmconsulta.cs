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
    public partial class Frmconsulta : Form
    {
        public Frmconsulta()
        {
            InitializeComponent();
        }

        private void DgResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            // Abrir conexão;

            SqlConnection conn = Connection.ObterConexao();
            




















            Connection.fecharConexao();



        }

        private void frmconsulta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Connection.fecharConexao();
            Close();
        }
    }
}
