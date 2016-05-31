namespace smssim
{
    partial class FrmMainReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainReports));
            this.rpvRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSourceRelatorio = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvRelatorio
            // 
            this.rpvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvRelatorio.Location = new System.Drawing.Point(0, 0);
            this.rpvRelatorio.Name = "rpvRelatorio";
            this.rpvRelatorio.Size = new System.Drawing.Size(584, 741);
            this.rpvRelatorio.TabIndex = 0;
            // 
            // FrmMainReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 741);
            this.Controls.Add(this.rpvRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMainReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Microsoft.Reporting.WinForms.ReportViewer rpvRelatorio;
        protected System.Windows.Forms.BindingSource bindingSourceRelatorio;
    }
}