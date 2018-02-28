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

namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.MdiParent = this;
            frm.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsulta frm = new frmconsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
