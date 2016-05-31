using Entities.Services;

namespace smssim
{
    public partial class FrmUsuariosConsult : smssim.FrmMainConsult
    {
        public FrmUsuariosConsult()
        {
            InitializeComponent();
            this.LoadGrid(null, null);
            this.FillCboFilter();
        }

        public override void LoadGrid(string param, string field)
        {
            UsuariosService service = new UsuariosService();
            dgvDados.DataSource = service.Consult(param, field);
        }
    }
}
