using System;
using System.Linq;
using Entities.Services;

namespace smssim
{
    public partial class FrmMensagensReports : smssim.FrmMainReports
    {

        public FrmMensagensReports()
        {
            InitializeComponent();
        }

        public override void GetDataSource()
        {
            MensagensService service = new MensagensService();
            //bindingSourceRelatorio.DataSource = service.Consult();
            bindingSourceRelatorio.DataSource = service.List().OrderByDescending(i=>i.Id).ToList();

            base.GetDataSource();
        }

        private void FrmMensagensReports_Load(object sender, EventArgs e)
        {

        }
    }
}
