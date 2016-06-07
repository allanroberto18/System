namespace smssim
{
    partial class FrmConsultaCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCodigo));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVencimento = new System.Windows.Forms.TextBox();
            this.rbUsado = new System.Windows.Forms.RadioButton();
            this.txtCodigoPromocional = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(180, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(175, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar Código Promocional";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 26);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(162, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Location = new System.Drawing.Point(12, 54);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(554, 94);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserir Código Promocional";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVencimento);
            this.groupBox1.Controls.Add(this.rbUsado);
            this.groupBox1.Controls.Add(this.txtCodigoPromocional);
            this.groupBox1.Controls.Add(this.txtContato);
            this.groupBox1.Controls.Add(this.rbAberto);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes da Promoção:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vencimento:";
            // 
            // txtVencimento
            // 
            this.txtVencimento.BackColor = System.Drawing.SystemColors.Window;
            this.txtVencimento.Location = new System.Drawing.Point(147, 36);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.ReadOnly = true;
            this.txtVencimento.Size = new System.Drawing.Size(85, 20);
            this.txtVencimento.TabIndex = 14;
            // 
            // rbUsado
            // 
            this.rbUsado.AutoSize = true;
            this.rbUsado.Enabled = false;
            this.rbUsado.Location = new System.Drawing.Point(150, 62);
            this.rbUsado.Name = "rbUsado";
            this.rbUsado.Size = new System.Drawing.Size(56, 17);
            this.rbUsado.TabIndex = 13;
            this.rbUsado.TabStop = true;
            this.rbUsado.Text = "Usado";
            this.rbUsado.UseVisualStyleBackColor = true;
            // 
            // txtCodigoPromocional
            // 
            this.txtCodigoPromocional.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoPromocional.Location = new System.Drawing.Point(81, 36);
            this.txtCodigoPromocional.Name = "txtCodigoPromocional";
            this.txtCodigoPromocional.ReadOnly = true;
            this.txtCodigoPromocional.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoPromocional.TabIndex = 11;
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.SystemColors.Window;
            this.txtContato.Location = new System.Drawing.Point(238, 36);
            this.txtContato.Name = "txtContato";
            this.txtContato.ReadOnly = true;
            this.txtContato.Size = new System.Drawing.Size(310, 20);
            this.txtContato.TabIndex = 10;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Enabled = false;
            this.rbAberto.Location = new System.Drawing.Point(70, 62);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(74, 17);
            this.rbAberto.TabIndex = 12;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Em Aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Location = new System.Drawing.Point(15, 36);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Situação:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::smssim.Properties.Resources.Accept32;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(12, 252);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(554, 64);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Marcar código como utilizado";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmConsultaCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 328);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Código Promocional";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVencimento;
        private System.Windows.Forms.RadioButton rbUsado;
        private System.Windows.Forms.TextBox txtCodigoPromocional;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}