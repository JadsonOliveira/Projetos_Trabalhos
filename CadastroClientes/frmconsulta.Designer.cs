namespace CadastroClientes
{
    partial class frmconsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgResultado = new System.Windows.Forms.DataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgResultado
            // 
            this.DgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResultado.Location = new System.Drawing.Point(-1, 19);
            this.DgResultado.Name = "DgResultado";
            this.DgResultado.Size = new System.Drawing.Size(938, 442);
            this.DgResultado.TabIndex = 0;
            this.DgResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgResultado);
            this.groupBox1.Location = new System.Drawing.Point(1, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnConsulta.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnConsulta.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.Location = new System.Drawing.Point(0, 504);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(939, 50);
            this.BtnConsulta.TabIndex = 1;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 557);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmconsulta";
            this.Text = "frmconsulta";
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnConsulta;
        public System.Windows.Forms.DataGridView DgResultado;
    }
}