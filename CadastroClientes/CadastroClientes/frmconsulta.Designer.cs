namespace CadastroClientes
{
    partial class Frmconsulta
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
            this.CpfText = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NomeCadText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgResultado
            // 
            this.DgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResultado.Location = new System.Drawing.Point(0, 41);
            this.DgResultado.Name = "DgResultado";
            this.DgResultado.Size = new System.Drawing.Size(793, 510);
            this.DgResultado.TabIndex = 0;
            this.DgResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgResultado_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.BtnNovo);
            this.groupBox1.Controls.Add(this.CpfText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NomeCadText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnConsulta);
            this.groupBox1.Controls.Add(this.DgResultado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 557);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Clientes";
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.Gold;
            this.BtnConsulta.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnConsulta.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.Location = new System.Drawing.Point(799, 124);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(282, 44);
            this.BtnConsulta.TabIndex = 1;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // CpfText
            // 
            this.CpfText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpfText.Location = new System.Drawing.Point(873, 84);
            this.CpfText.Mask = "000.000.000-00";
            this.CpfText.Name = "CpfText";
            this.CpfText.Size = new System.Drawing.Size(100, 21);
            this.CpfText.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(821, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cpf";
            // 
            // NomeCadText
            // 
            this.NomeCadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCadText.Location = new System.Drawing.Point(873, 41);
            this.NomeCadText.Name = "NomeCadText";
            this.NomeCadText.Size = new System.Drawing.Size(208, 21);
            this.NomeCadText.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(799, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(799, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 44);
            this.button3.TabIndex = 20;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.DarkGray;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold);
            this.Button1.Location = new System.Drawing.Point(799, 508);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(282, 43);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "Sair";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold);
            this.BtnNovo.Location = new System.Drawing.Point(799, 185);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(282, 44);
            this.BtnNovo.TabIndex = 19;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(799, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(282, 44);
            this.button4.TabIndex = 21;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 635);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmconsulta";
            this.Text = "frmconsulta";
            this.Load += new System.EventHandler(this.frmconsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgResultado;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.MaskedTextBox CpfText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomeCadText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button BtnNovo;
    }
}