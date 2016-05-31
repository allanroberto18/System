namespace smssim
{
    partial class FrmContatosConsult
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFilter
            // 
            this.cboFilter.Location = new System.Drawing.Point(200, 43);
            this.cboFilter.Size = new System.Drawing.Size(165, 21);
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // txtParametro
            // 
            this.txtParametro.Size = new System.Drawing.Size(177, 20);
            this.txtParametro.Enter += new System.EventHandler(this.txtParametro_Enter);
            this.txtParametro.Leave += new System.EventHandler(this.txtParametro_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(197, 27);
            // 
            // FrmContatosConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(538, 317);
            this.Name = "FrmContatosConsult";
            this.Text = "Consultar Contatos";
            this.Load += new System.EventHandler(this.FrmContatosConsult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
