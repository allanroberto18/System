namespace smssim
{
    partial class FrmImportarContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportarContatos));
            this.dgvDadosImportados = new System.Windows.Forms.DataGridView();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.btnSalvarContatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosImportados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDadosImportados
            // 
            this.dgvDadosImportados.AllowUserToAddRows = false;
            this.dgvDadosImportados.AllowUserToDeleteRows = false;
            this.dgvDadosImportados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosImportados.Location = new System.Drawing.Point(12, 131);
            this.dgvDadosImportados.MultiSelect = false;
            this.dgvDadosImportados.Name = "dgvDadosImportados";
            this.dgvDadosImportados.ReadOnly = true;
            this.dgvDadosImportados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDadosImportados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosImportados.Size = new System.Drawing.Size(560, 228);
            this.dgvDadosImportados.TabIndex = 1;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Image = global::smssim.Properties.Resources.Database_Upload;
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(12, 12);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(184, 67);
            this.btnSelecionarArquivo.TabIndex = 0;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // btnSalvarContatos
            // 
            this.btnSalvarContatos.Image = global::smssim.Properties.Resources.Accept32;
            this.btnSalvarContatos.Location = new System.Drawing.Point(200, 13);
            this.btnSalvarContatos.Name = "btnSalvarContatos";
            this.btnSalvarContatos.Size = new System.Drawing.Size(184, 66);
            this.btnSalvarContatos.TabIndex = 2;
            this.btnSalvarContatos.Text = "Salvar Contatos";
            this.btnSalvarContatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvarContatos.UseVisualStyleBackColor = true;
            this.btnSalvarContatos.Click += new System.EventHandler(this.btnSalvarContatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade de Registros:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(142, 86);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(13, 13);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 102);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::smssim.Properties.Resources.Accept32;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(12, 365);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(560, 37);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::smssim.Properties.Resources.cancel;
            this.btnCancelar.Location = new System.Drawing.Point(388, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 66);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar Processamento";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmImportarContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarContatos);
            this.Controls.Add(this.dgvDadosImportados);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmImportarContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Contatos do Excell";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosImportados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.DataGridView dgvDadosImportados;
        private System.Windows.Forms.Button btnSalvarContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
    }
}