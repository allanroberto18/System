using System;
using System.Linq;
using Entities.Services;

namespace smssim
{
    public partial class FrmGruposReports : smssim.FrmMainReports
    {
        public FrmGruposReports()
        {
            InitializeComponent();
        }

        public override void GetDataSource()
        {
            GruposService services = new GruposService();
            bindingSourceRelatorio.DataSource = services.List().OrderBy(i => i.Nome).ToList();

            base.GetDataSource();
        }

        private void FrmGruposReports_Load(object sender, EventArgs e)
        {

        }
    }
}
