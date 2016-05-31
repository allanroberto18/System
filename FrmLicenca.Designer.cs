namespace smssim
{
    partial class FrmLicenca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicenca));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnValidarLicenca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::smssim.Properties.Resources.keys48;
            this.btnSalvar.Location = new System.Drawing.Point(19, 58);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 70);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnValidarLicenca
            // 
            this.btnValidarLicenca.Image = global::smssim.Properties.Resources.Calendar48;
            this.btnValidarLicenca.Location = new System.Drawing.Point(94, 58);
            this.btnValidarLicenca.Name = "btnValidarLicenca";
            this.btnValidarLicenca.Size = new System.Drawing.Size(69, 70);
            this.btnValidarLicenca.TabIndex = 1;
            this.btnValidarLicenca.Text = "Validar";
            this.btnValidarLicenca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnValidarLicenca.UseVisualStyleBackColor = true;
            this.btnValidarLicenca.Click += new System.EventHandler(this.btnValidarLicenca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Licença:";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(19, 32);
            this.txtSerial.Mask = "#####-#####-#####-#####";
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(144, 20);
            this.txtSerial.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 140);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidarLicenca);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLicenca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Licença";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnValidarLicenca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtSerial;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}