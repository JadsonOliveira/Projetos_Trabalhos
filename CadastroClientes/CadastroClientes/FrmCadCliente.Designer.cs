using System;

namespace CadastroClientes
{
    partial class FrmCadCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TelefoneText = new System.Windows.Forms.MaskedTextBox();
            this.CpfText = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SexoText = new System.Windows.Forms.TextBox();
            this.IdadeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomeCadText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnderecoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TelefoneText);
            this.groupBox1.Controls.Add(this.CpfText);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SexoText);
            this.groupBox1.Controls.Add(this.IdadeText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NomeCadText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EnderecoText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 386);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Clientes";
            // 
            // TelefoneText
            // 
            this.TelefoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneText.Location = new System.Drawing.Point(482, 144);
            this.TelefoneText.Mask = "(00)00000-0000    ";
            this.TelefoneText.Name = "TelefoneText";
            this.TelefoneText.Size = new System.Drawing.Size(100, 21);
            this.TelefoneText.TabIndex = 16;
            // 
            // CpfText
            // 
            this.CpfText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpfText.Location = new System.Drawing.Point(482, 86);
            this.CpfText.Mask = "000.000.000-00";
            this.CpfText.Name = "CpfText";
            this.CpfText.Size = new System.Drawing.Size(100, 21);
            this.CpfText.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(284, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Idade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sexo";
            // 
            // SexoText
            // 
            this.SexoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexoText.Location = new System.Drawing.Point(105, 196);
            this.SexoText.Name = "SexoText";
            this.SexoText.Size = new System.Drawing.Size(208, 21);
            this.SexoText.TabIndex = 11;
            // 
            // IdadeText
            // 
            this.IdadeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdadeText.Location = new System.Drawing.Point(482, 195);
            this.IdadeText.Name = "IdadeText";
            this.IdadeText.Size = new System.Drawing.Size(100, 21);
            this.IdadeText.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cpf";
            // 
            // NomeCadText
            // 
            this.NomeCadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCadText.Location = new System.Drawing.Point(105, 86);
            this.NomeCadText.Name = "NomeCadText";
            this.NomeCadText.Size = new System.Drawing.Size(208, 21);
            this.NomeCadText.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Endereço";
            // 
            // EnderecoText
            // 
            this.EnderecoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoText.Location = new System.Drawing.Point(105, 144);
            this.EnderecoText.Name = "EnderecoText";
            this.EnderecoText.Size = new System.Drawing.Size(208, 21);
            this.EnderecoText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(526, 322);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 35);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Fechar";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 431);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadCliente";
            this.Text = "FrmCadCliente";
            this.Load += new System.EventHandler(this.FrmCadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private EventHandler btnalteracao_Click;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TelefoneText;
        private System.Windows.Forms.MaskedTextBox CpfText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SexoText;
        private System.Windows.Forms.TextBox IdadeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomeCadText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnderecoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
    }
}