﻿namespace smssim
{
    partial class FrmGruposReports
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
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvRelatorio
            // 
            reportDataSource1.Name = "dsGrupos";
            reportDataSource1.Value = this.bindingSourceRelatorio;
            this.rpvRelatorio.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvRelatorio.LocalReport.ReportEmbeddedResource = "smssim.rptGrupos.rdlc";
            // 
            // gruposBindingSource
            // 
            //this.gruposBindingSource.DataSource = typeof(smssim.grupos);
            // 
            // FrmGruposReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 741);
            this.Name = "FrmGruposReports";
            this.Text = "Listagem de Grupos";
            this.Load += new System.EventHandler(this.FrmGruposReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource gruposBindingSource;
    }
}
