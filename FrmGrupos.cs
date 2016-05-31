using System;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;

namespace smssim
{
    public partial class FrmGrupos : smssim.FrmMain
    {
        public FrmGrupos()
        {
            InitializeComponent();
            LoadButtons();
            LoadGrid();
        }

        public override void LoadGrid()
        {
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GruposService services = new GruposService();
            
            dgvDados.DataSource = services.Consult();

            dgvDados.Columns["Id"].Visible = true;
            dgvDados.Columns["Id"].HeaderText = "Código";
            dgvDados.Columns["Nome"].Visible = true;
            dgvDados.Columns["Nome"].HeaderText = "Nome do Grupo";
            dgvDados.Columns["Created"].Visible = false;
            dgvDados.Columns["Updated"].Visible = false;
            dgvDados.Columns["status"].Visible = false;
            dgvDados.Columns["GruposContatos"].Visible = false;
            dgvDados.Columns["GruposMensagens"].Visible = false;
        }

        public override bool IsValid()
        {
            string msgNome = errorProvider1.GetError(txtNome);
            if (msgNome.Trim().Length > 0)
            {
                return false;
            }
            return true;
        }

        public override void Salvar()
        {
            ValidarCampos(txtNome, errorProvider1, "O campo nome é obrigatório");
            if (!IsValid())
            {
                return;
            }
            
            Grupos entity = new Grupos();
            entity.SetParams(txtNome.Text, ReturnStatus());
            entity.Created = DateTime.Now;

            GruposService service = new GruposService();
            service.Add(entity);

            MessageBox.Show("Dados cadastrados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.Salvar();

            SelectRegister(entity);

            EditarButtons();
        }

        public void SelectRegister(Grupos entity)
        {
            txt_Id.Text = entity.Id.ToString();

            txtNome.Text = entity.Nome;

            ChangeStatus(entity.Status);
        }

        public override void LoadRegister()
        {
            GruposService service = new GruposService();
            Grupos entity = service.Find(Id);

            txtNome.Text = entity.Nome;

            base.LoadRegister(entity.Id, entity.Status);

            txt_Id.Text = entity.Id.ToString();
        }

        public override void SelectRegister(int row)
        {
            if (row < 0)
            {
                return;
            }
            txt_Id.Text = dgvDados.Rows[row].Cells[0].Value.ToString();
            txtNome.Text = dgvDados.Rows[row].Cells[1].Value.ToString();

            ChangeStatus((int)dgvDados.Rows[row].Cells[4].Value);
        }

        public override void Alterar()
        {
            ValidarCampos(txtNome, errorProvider1, "O campo nome é obrigatório");

            if (!IsValid())
            {
                return;
            }
            int id = Convert.ToInt32(txt_Id.Text);

            Grupos entity = new Grupos();
            entity.SetParams(id, txtNome.Text, ReturnStatus());
            entity.Updated = DateTime.Now;

            GruposService service = new GruposService();
            service.Edit(entity);
                
            MessageBox.Show("Dados alterados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.Alterar();
        }

        public override void Pesquisar()
        {
            base.Pesquisar(new FrmGruposConsult());
        }

        public override void Excluir()
        {
            int id = Convert.ToInt16(txt_Id.Text);

            GruposService service = new GruposService();
            Grupos entity = service.Find(id);

            entity.Updated = DateTime.Now;
            entity.Status = 2;

            service.Edit(entity);
           
            MessageBox.Show("Registro excluído com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.Excluir();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvDados.SelectedRows.Count < 0 && e.RowIndex < 0) || dgvDados.CurrentRow == null)
            {
                return;
            }
            GetDataByRow(e.RowIndex);
        }

        public override void Relatorio()
        {
            int id;
            bool teste = int.TryParse(txt_Id.Text, out id);
            if (teste)
            {
                FrmGruposContatosReport rpt = new FrmGruposContatosReport();
                rpt.Id = id;
                rpt.ShowDialog();

                return;
            }
            FrmGruposReports frm = new FrmGruposReports();
            frm.ShowDialog();
        }
    }
}
