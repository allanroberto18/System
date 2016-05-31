using Entities.Services;

namespace smssim
{
    public partial class FrmMensagensConsult : smssim.FrmMainConsult
    {
        public FrmMensagensConsult()
        {
            InitializeComponent();
            LoadGrid(null, null);
            FillCboFilter();
        }

        public override void LoadGrid(string param, string field)
        {
            MensagensService service = new MensagensService();
            dgvDados.DataSource = service.Consult(param, field);
        }

        public override dynamic ItensCboFilter()
        {
            return new[]
            {
                new { Text = "Código" , Value = 1},
                new { Text = "Mensagem" , Value = 2}
            };
        }
        
    }
}
