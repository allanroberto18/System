using System;
using System.Linq;
using Entities.Services;

namespace smssim
{
    public partial class FrmContatosReports : smssim.FrmMainReports
    {
        public FrmContatosReports()
        {
            InitializeComponent();
        }

        public override void GetDataSource()
        {
            ContatosService services = new ContatosService();
            bindingSourceRelatorio.DataSource = services.List().OrderBy(i => i.Nome).ToList();

            base.GetDataSource();
        }
    }
}
