using System.Windows.Forms;
using Entities.Services;

namespace smssim
{
    public partial class FrmGruposConsult : smssim.FrmMainConsult
    {
        public FrmGruposConsult()
        {
            InitializeComponent();
        }

        public override void LoadGrid(string param, string field)
        {
            GruposService service = new GruposService();
            dgvDados.DataSource = service.Consult(param, field);

            dgvDados.Columns["Id"].Visible = true;
            dgvDados.Columns["Id"].HeaderText = "Código";
            dgvDados.Columns["Nome"].Visible = true;
            dgvDados.Columns["Nome"].HeaderText = "Nome do Grupo";
            dgvDados.Columns["status"].Visible = false;
            dgvDados.Columns["Created"].Visible = false;
            dgvDados.Columns["Updated"].Visible = false;
            dgvDados.Columns["status"].Visible = false;
            DataGridViewColumn gruposContatosColumn = dgvDados.Columns["GruposContatos"];
            if (gruposContatosColumn != null)
                gruposContatosColumn.Visible = false;
            DataGridViewColumn gruposMensagensColumn = dgvDados.Columns["GruposMensagens"];
            if (gruposMensagensColumn != null)
                gruposMensagensColumn.Visible = false;
        }
    }
}
