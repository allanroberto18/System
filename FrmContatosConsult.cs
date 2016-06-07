using System;
using Entities.Services;

namespace smssim
{
    public partial class FrmContatosConsult : smssim.FrmMainConsult
    {
        public FrmContatosConsult()
        {
            InitializeComponent();
            LoadGrid(null, null);
            FillCboFilter();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = (int)cboFilter.SelectedValue;
            switch (value)
            {
                case 3:
                    txtParametro.Mask = "(##) #####-####";
                    break;
                case 4:
                    txtParametro.Mask = "##/##/####";
                    break;
                default:
                    txtParametro.Mask = null;
                    break;
            }
        }

        public override dynamic ItensCboFilter()
        {
            return new[]
            {
                new { Text = "Código" , Value = 1},
                new { Text = "Nome" , Value = 2},
                new { Text = "Telefone" , Value = 3},
                new { Text = "Data de Nascimento" , Value = 4}
            }; 
        }

        public override void LoadGrid(string param, string field)
        {
            ContatosService services = new ContatosService();

            dgvDados.DataSource = services.Consult(param, field, 3);

            dgvDados.Columns["Id"].Visible = true;
            dgvDados.Columns["Id"].HeaderText = "Código";
            dgvDados.Columns["Nome"].Visible = true;
            dgvDados.Columns["Nome"].HeaderText = "Nome do Contato";
            dgvDados.Columns["Telefone"].Visible = true;
            dgvDados.Columns["Telefone"].HeaderText = "Celular/Whatsapp";

            dgvDados.Columns["Sexo"].Visible = false;
            dgvDados.Columns["DataNascimento"].Visible = false;
            dgvDados.Columns["Status"].Visible = false;
            dgvDados.Columns["Created"].Visible = false;
            dgvDados.Columns["Updated"].Visible = false;
            dgvDados.Columns["status"].Visible = false;
            dgvDados.Columns["CodigosPromocionais"].Visible = false;
            dgvDados.Columns["ContatosMensagens"].Visible = false;
            dgvDados.Columns["GruposContatos"].Visible = false;
            dgvDados.Columns["MensagensDisparos"].Visible = false;
        }

        private void txtParametro_Leave(object sender, EventArgs e)
        {
            int filter = (int) cboFilter.SelectedValue;
            if (filter == 3)
            {
                txtParametro.Mask = "(##) #####-####";
            }
            
        }

        private void txtParametro_Enter(object sender, EventArgs e)
        {
            int value = (int)cboFilter.SelectedValue;
            switch (value)
            {
                case 3:
                    txtParametro.Mask = "(##) #####-####";
                    break;
                case 4:
                    txtParametro.Mask = "##/##/####";
                    break;
                default:
                    txtParametro.Mask = null;
                    break;
            }
        }

        private void FrmContatosConsult_Load(object sender, EventArgs e)
        {

        }
    }
}
