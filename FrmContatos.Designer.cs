namespace smssim
{
    partial class FrmContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContatos));
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tbPrincipal = new System.Windows.Forms.TabControl();
            this.tbContatos = new System.Windows.Forms.TabPage();
            this.tbGruposContatos = new System.Windows.Forms.TabPage();
            this.dgGruposContatos = new System.Windows.Forms.DataGridView();
            this.btnPesquisarGrupo = new System.Windows.Forms.Button();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.gbxFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tbPrincipal.SuspendLayout();
            this.tbContatos.SuspendLayout();
            this.tbGruposContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGruposContatos)).BeginInit();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFormulario
            // 
            this.gbxFormulario.Controls.Add(this.gbxSexo);
            this.gbxFormulario.Controls.Add(this.txtTelefone);
            this.gbxFormulario.Controls.Add(this.label3);
            this.gbxFormulario.Controls.Add(this.dtpDataNascimento);
            this.gbxFormulario.Controls.Add(this.txtNome);
            this.gbxFormulario.Controls.Add(this.label2);
            this.gbxFormulario.Controls.Add(this.lblNome);
            this.gbxFormulario.Location = new System.Drawing.Point(12, 132);
            this.gbxFormulario.Size = new System.Drawing.Size(254, 164);
            // 
            // gbxStatus
            // 
            this.gbxStatus.Location = new System.Drawing.Point(12, 302);
            this.gbxStatus.Size = new System.Drawing.Size(254, 46);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 5;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(124, 81);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(112, 20);
            this.dtpDataNascimento.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(15, 81);
            this.txtTelefone.Mask = "(##) #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(91, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(375, 146);
            this.dgvDados.TabIndex = 3;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.tbContatos);
            this.tbPrincipal.Controls.Add(this.tbGruposContatos);
            this.tbPrincipal.Location = new System.Drawing.Point(276, 170);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 0;
            this.tbPrincipal.Size = new System.Drawing.Size(389, 178);
            this.tbPrincipal.TabIndex = 5;
            this.tbPrincipal.SelectedIndexChanged += new System.EventHandler(this.tbPrincipal_SelectedIndexChanged);
            // 
            // tbContatos
            // 
            this.tbContatos.Controls.Add(this.dgvDados);
            this.tbContatos.Location = new System.Drawing.Point(4, 22);
            this.tbContatos.Name = "tbContatos";
            this.tbContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbContatos.Size = new System.Drawing.Size(381, 152);
            this.tbContatos.TabIndex = 0;
            this.tbContatos.Text = "Contatos";
            this.tbContatos.UseVisualStyleBackColor = true;
            // 
            // tbGruposContatos
            // 
            this.tbGruposContatos.Controls.Add(this.dgGruposContatos);
            this.tbGruposContatos.Location = new System.Drawing.Point(4, 22);
            this.tbGruposContatos.Name = "tbGruposContatos";
            this.tbGruposContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbGruposContatos.Size = new System.Drawing.Size(381, 152);
            this.tbGruposContatos.TabIndex = 1;
            this.tbGruposContatos.Text = "Grupos do Contato";
            this.tbGruposContatos.UseVisualStyleBackColor = true;
            // 
            // dgGruposContatos
            // 
            this.dgGruposContatos.AllowUserToAddRows = false;
            this.dgGruposContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGruposContatos.Location = new System.Drawing.Point(3, 4);
            this.dgGruposContatos.MultiSelect = false;
            this.dgGruposContatos.Name = "dgGruposContatos";
            this.dgGruposContatos.ReadOnly = true;
            this.dgGruposContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGruposContatos.Size = new System.Drawing.Size(375, 145);
            this.dgGruposContatos.TabIndex = 0;
            this.dgGruposContatos.DoubleClick += new System.EventHandler(this.dgGruposContatos_DoubleClick);
            // 
            // btnPesquisarGrupo
            // 
            this.btnPesquisarGrupo.Image = global::smssim.Properties.Resources.addressbook64;
            this.btnPesquisarGrupo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarGrupo.Location = new System.Drawing.Point(276, 104);
            this.btnPesquisarGrupo.Name = "btnPesquisarGrupo";
            this.btnPesquisarGrupo.Size = new System.Drawing.Size(389, 60);
            this.btnPesquisarGrupo.TabIndex = 4;
            this.btnPesquisarGrupo.Text = "Adicionar ao Grupo";
            this.btnPesquisarGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarGrupo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarGrupo.UseVisualStyleBackColor = true;
            this.btnPesquisarGrupo.Click += new System.EventHandler(this.btnPesquisarGrupo_Click);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(13, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 11;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(110, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 12;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbMasculino);
            this.gbxSexo.Controls.Add(this.rbFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(14, 107);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(222, 48);
            this.gbxSexo.TabIndex = 13;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // FrmContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(677, 361);
            this.Controls.Add(this.tbPrincipal);
            this.Controls.Add(this.btnPesquisarGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContatos";
            this.Text = "Gerenciar Contatos";
            this.Controls.SetChildIndex(this.gbxStatus, 0);
            this.Controls.SetChildIndex(this.txt_Id, 0);
            this.Controls.SetChildIndex(this.gbxFormulario, 0);
            this.Controls.SetChildIndex(this.btnPesquisarGrupo, 0);
            this.Controls.SetChildIndex(this.tbPrincipal, 0);
            this.gbxFormulario.ResumeLayout(false);
            this.gbxFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tbPrincipal.ResumeLayout(false);
            this.tbContatos.ResumeLayout(false);
            this.tbGruposContatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGruposContatos)).EndInit();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnPesquisarGrupo;
        private System.Windows.Forms.TabControl tbPrincipal;
        private System.Windows.Forms.TabPage tbContatos;
        private System.Windows.Forms.TabPage tbGruposContatos;
        private System.Windows.Forms.DataGridView dgGruposContatos;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
    }
}
