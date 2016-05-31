using System;
using System.Windows.Forms;

namespace smssim
{
    public partial class FrmMainReports : Form
    {
        public FrmMainReports()
        {
            InitializeComponent();
        }

        public virtual void GetDataSource()
        {
            rpvRelatorio.RefreshReport();
        }

        private void FrmMainReports_Load(object sender, EventArgs e)
        {
            GetDataSource();
        }
    }
}
