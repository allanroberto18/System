using System;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;
using Libs;

namespace smssim
{
    public partial class FrmConfiguracoes : smssim.FrmMain
    {
        public FrmConfiguracoes()
        {
            InitializeComponent();

            LoadButtons();
            LoadGrid();
        }

        public override void Novo()
        {
            ConfiguracoesService services = new ConfiguracoesService();
            int count = services.Consult().Count;
            if (count > 0)
            {
                base.Cancelar();

                LoadButtons();

                return;
            }
            base.Novo();
        }

        public override void LoadGrid()
        {
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            ConfiguracoesService services = new ConfiguracoesService();
            dgvDados.DataSource = services.Consult();

            dgvDados.Columns["Id"].Visible = true;
            dgvDados.Columns["Id"].HeaderText = "Código";
            dgvDados.Columns["Inicio"].Visible = true;
            dgvDados.Columns["Inicio"].HeaderText = "Data Inicial";
            dgvDados.Columns["Fim"].Visible = true;
            dgvDados.Columns["Fim"].HeaderText = "Data Final";

            dgvDados.Columns["Created"].Visible = false;
            dgvDados.Columns["Updated"].Visible = false;
            dgvDados.Columns["Status"].Visible = false;
        }

        public override bool IsValid()
        {
            string msgDataInicial = errorProvider1.GetError(dtpInicial);
            string msgDataFinal = errorProvider1.GetError(dtpFinal);
            if (msgDataInicial.Trim().Length > 0 || msgDataFinal.Trim().Length > 0)
            {
                return false;
            }
            return true;
        }

        public override void Salvar()
        {
            ValidarDatePicker(dtpInicial, errorProvider1, "O campo Data Inicial é obrigatório");
            ValidarDatePicker(dtpInicial, errorProvider1, "O campo Data Final é obrigatório");

            string idUsuario = AppConfig.GetValue("user");
            if (idUsuario != "1")
            {
                MessageBox.Show("Você não tem permissão para adicionar configurações de sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsValid())
            {
                ConfiguracoesService services = new ConfiguracoesService();

                Configuracoes entity = new Configuracoes();
                entity.SetParams(dtpInicial.Value, dtpFinal.Value, ReturnStatus());
                entity.Created = DateTime.Now;

                services.Add(entity);

                if (entity.Id > 0)
                {
                    MessageBox.Show("Dados cadastrados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    base.Salvar();
                }
            }
        }

        public override void LoadRegister()
        {
            ConfiguracoesService services = new ConfiguracoesService();
            Configuracoes entity = services.Find(Id);

            dtpInicial.Value = entity.Inicio;
            dtpFinal.Value = entity.Fim;

            base.LoadRegister(entity.Id, entity.Status);

            txt_Id.Text = entity.Id.ToString();
        }

        public override void SelectRegister(int row)
        {
            txt_Id.Text = dgvDados.Rows[row].Cells[0].Value.ToString();
            dtpInicial.Text = dgvDados.Rows[row].Cells[1].Value.ToString();
            dtpFinal.Text = dgvDados.Rows[row].Cells[2].Value.ToString();

            ChangeStatus((int)dgvDados.Rows[row].Cells[5].Value);
        }

        public override void Alterar()
        {
            ValidarDatePicker(dtpInicial, errorProvider1, "O campo data inicial é obrigatório");
            ValidarDatePicker(dtpFinal, errorProvider1, "O campo data final é obrigatório");

            string idUsuario = AppConfig.GetValue("user");
            if (idUsuario != "1")
            {
                MessageBox.Show("Você não tem permissão para adicionar configurações de sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IsValid())
            {
                int id = Convert.ToInt32(txt_Id.Text);

                Configuracoes entity = new Configuracoes();
                entity.SetParams(id, dtpInicial.Value, dtpFinal.Value, ReturnStatus());
                entity.Updated = DateTime.Now;
                
                ConfiguracoesService services = new ConfiguracoesService();
                services.Edit(entity);

                MessageBox.Show("Dados alterados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.Alterar();
            }
        }

        public override void Excluir()
        {
            MessageBox.Show("Esta opção está indisponível", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            base.Cancelar();

            LoadButtons();
        }

        public override void Pesquisar()
        {
            MessageBox.Show("Esta opção está indisponível", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            base.Cancelar();

            LoadButtons();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvDados.SelectedRows.Count < 0 && e.RowIndex < 0) || dgvDados.CurrentRow == null)
            {
                return;
            }
            GetDataByRow(e.RowIndex);
        }
    }
}
