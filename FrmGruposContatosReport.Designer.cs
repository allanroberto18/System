namespace smssim
{
    partial class FrmGruposContatosReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ContatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvRelatorio
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSourceRelatorio;
            this.rpvRelatorio.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvRelatorio.LocalReport.ReportEmbeddedResource = "smssim.rptGruposContatos.rdlc";
            // 
            // ContatosBindingSource
            // 
            this.ContatosBindingSource.DataMember = "GruposContatos";
            this.ContatosBindingSource.DataSource = typeof(Entities.Models.Contatos);
            // 
            // FrmGruposContatosReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 741);
            this.Name = "FrmGruposContatosReport";
            this.Load += new System.EventHandler(this.FrmGruposContatosReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ContatosBindingSource;
    }
}
