using System;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;

namespace smssim
{
    public partial class FrmContatos : smssim.FrmMain
    {
        public FrmContatos()
        {
            InitializeComponent();
            LoadButtons();
            LoadGrid();
            btnPesquisarGrupo.Enabled = false;
        }

        public override void NovoButtons()
        {
            btnPesquisarGrupo.Enabled = false;

            base.NovoButtons();

            gbxSexo.Enabled = true;

            rbMasculino.Checked = true;
        }

        public override void EditarButtons()
        {
            btnPesquisarGrupo.Enabled = true;

            gbxSexo.Enabled = true;

            base.EditarButtons();
        }

        public override void LoadButtons()
        {
            btnPesquisarGrupo.Enabled = false;

            base.LoadButtons();
        }

        public override void PesquisarButtons()
        {
            btnPesquisarGrupo.Enabled = true;

            base.PesquisarButtons();
        }

        public override void Cancelar()
        {
            btnPesquisarGrupo.Enabled = false;
            dgGruposContatos.DataSource = null;
            base.Cancelar();
        }

        public override void LoadGrid()
        {
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            ContatosService services = new ContatosService();
            dgvDados.DataSource = services.Consult();

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

        public override bool IsValid()
        {
            string msgNome = errorProvider1.GetError(txtNome);
            string msgTelefone = errorProvider1.GetError(txtTelefone);
            string msgDataNascimento = errorProvider1.GetError(dtpDataNascimento);
            if (msgNome.Trim().Length > 0 || msgTelefone.Trim().Length > 0 || msgDataNascimento.Trim().Length > 0)
            {
                return false;
            }
            return true;
        }

        public int ReturnSexo()
        {
            if (rbMasculino.Checked)
            {
                return 1;
            }
            return 2;
        }

        public void SelectSexo(int sexo)
        {
            switch (sexo)
            {
                case 1:
                    rbMasculino.Checked = true;
                    rbFeminino.Checked = false;
                    break;
                case 2:
                    rbMasculino.Checked = false;
                    rbFeminino.Checked = true;
                    break;
                default:
                    rbMasculino.Checked = true;
                    rbFeminino.Checked = false;
                    break;
            }
        }

        public override void Salvar()
        {
            ValidarCampos(txtNome, errorProvider1, "O campo nome é obrigatório");
            ValidarMaskCampos(txtTelefone, errorProvider1, "O campo Telefone é obrigatório");

            if (!IsValid())
            {
                return;
            }
            Contatos entity = new Contatos();
            entity.SetParams(txtNome.Text, ReturnSexo(), txtTelefone.Text, Convert.ToDateTime(dtpDataNascimento.Value.ToShortDateString()), ReturnStatus());
            entity.Created = DateTime.Now;

            ContatosService services = new ContatosService();
            services.Add(entity);

            MessageBox.Show("Dados cadastrados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.Salvar();
            
            SelectRegister(entity);

            EditarButtons();
        }

        public override void LoadRegister()
        {
            ContatosService services = new ContatosService();
            Contatos entity = services.Find(Id);

            txtNome.Text = entity.Nome;
            txtTelefone.Text = entity.Telefone;
            SelectSexo(entity.Sexo);
            dtpDataNascimento.Text = entity.DataNascimento.ToString();

            LoadGridGrupoContato(Id);

            base.LoadRegister(entity.Id, entity.Status);

            txt_Id.Text = entity.Id.ToString();
        }

        public override void SelectRegister(int row)
        {
            base.SelectRegister(row);

            int id = (int)dgvDados.Rows[row].Cells[0].Value;

            ContatosService services = new ContatosService();
            Contatos entity = services.Find(id);

            this.SelectRegister(entity);
        }

        public void SelectRegister(Contatos entity)
        {
            txt_Id.Text = entity.Id.ToString();
            txtNome.Text = entity.Nome;
            SelectSexo(entity.Sexo);
            txtTelefone.Text = entity.Telefone;
            dtpDataNascimento.Text = entity.DataNascimento.ToString();

            ChangeStatus(entity.Status);

            LoadGridGrupoContato(Convert.ToInt32(txt_Id.Text));

            btnPesquisarGrupo.Enabled = true;
        }

        public override void Alterar()
        {
            ValidarCampos(txtNome, errorProvider1, "O campo nome é obrigatório");
            ValidarMaskCampos(txtTelefone, errorProvider1, "O campo Telefone é obrigatório");

            if (IsValid())
            {
                int id = Convert.ToInt32(txt_Id.Text);

                Contatos entity = new Contatos();
                entity.SetParams(id, txtNome.Text, ReturnSexo(), txtTelefone.Text, Convert.ToDateTime(dtpDataNascimento.Value.ToShortDateString()), ReturnStatus());
                entity.Updated = DateTime.Now;;

                ContatosService services = new ContatosService();
                services.Edit(entity);

                MessageBox.Show("Dados alterados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnPesquisarGrupo.Enabled = false;
                dgGruposContatos.DataSource = null;

                base.Alterar();
            }
        }

        public override void Pesquisar()
        {
            base.Pesquisar(new FrmContatosConsult());
        }

        public override void Excluir()
        {
            try
            {
                int id = Convert.ToInt32(txt_Id.Text);

                ContatosService services = new ContatosService();

                Contatos entity = services.Find(id);
                entity.Updated = DateTime.Now;
                entity.Status = 2;

                services.Edit(entity);
                
                MessageBox.Show("Registro excluído com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.Excluir();
            }
            catch
            {
                MessageBox.Show("Registro não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvDados.SelectedRows.Count < 0 && e.RowIndex < 0) || dgvDados.CurrentRow == null)
            {
                return;
            }
            GetDataByRow(e.RowIndex);
        }

        public void LoadComboBox()
        {
            //using (appSMSSIMEntities context = new appSMSSIMEntities())
            //{
                //var query = from i in context.grupos where i.status.Equals(1) select i;
                //cboGrupo.DataSource = query.ToList();
                //cboGrupo.ValueMember = "id";
                //cboGrupo.DisplayMember = "nome";
            //}
        }

        public override void Relatorio()
        {
            FrmContatosReports frm = new FrmContatosReports();
            frm.ShowDialog();
        }
        
        private void btnPesquisarGrupo_Click(object sender, EventArgs e)
        {
            int contato = Convert.ToInt32(txt_Id.Text);
            FrmGruposConsult form = new FrmGruposConsult();

            form.ShowDialog();

            GruposContatosService services = new GruposContatosService();
            if (form.Lista?.Length > 0)
            {
                foreach (int item in form.Lista)
                {
                    GruposContatos entity = new GruposContatos();
                    entity.SetParams(item, contato, 1);
                    entity.Created = DateTime.Now;

                    services.Add(entity);
                }
            }
            LoadGridGrupoContato(Convert.ToInt32(txt_Id.Text));
        }

        private void tbPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            dgGruposContatos.DataSource = null;
            if (tbPrincipal.SelectedTab == tbPrincipal.TabPages["tbGruposContatos"] && int.TryParse(txt_Id.Text, out id))
            {
                LoadGridGrupoContato(id);
            }
        }

        private void LoadGridGrupoContato(int id)
        {
            GruposContatosService services = new GruposContatosService();
            dgGruposContatos.DataSource = services.Consult(id.ToString(), "Contato");

            dgGruposContatos.Columns["GrupoId"].Visible = true;
            dgGruposContatos.Columns["GrupoId"].HeaderText = "Código do Grupo";
            dgGruposContatos.Columns["Grupo"].Visible = true;
            dgGruposContatos.Columns["Grupo"].HeaderText = "Nome do Grupo";
            dgGruposContatos.Columns["Id"].Visible = false;
            dgGruposContatos.Columns["ContatoId"].Visible = false;
            dgGruposContatos.Columns["Contato"].Visible = false;
            dgGruposContatos.Columns["Created"].Visible = false;
            dgGruposContatos.Columns["Updated"].Visible = false;
            dgGruposContatos.Columns["status"].Visible = false;

            DataGridViewColumn gruposContatosColumn = dgGruposContatos.Columns["GruposContatos"];
            if (gruposContatosColumn != null)
                gruposContatosColumn.Visible = false;
            DataGridViewColumn gruposMensagensColumn = dgGruposContatos.Columns["GruposMensagens"];
            if (gruposMensagensColumn != null)
                gruposMensagensColumn.Visible = false;
        }
        
        private void dgGruposContatos_DoubleClick(object sender, EventArgs e)
        {
            if (dgGruposContatos.SelectedRows.Count < 0 || dgGruposContatos.CurrentRow == null)
            {
                return;
            }

            int i = dgGruposContatos.CurrentRow.Index;

            int id = Convert.ToInt32(txt_Id.Text);
            int grupo = (int)dgGruposContatos.Rows[i].Cells[1].Value;

            GruposContatosService service = new GruposContatosService();
            service.Remove(grupo, id);

            CurrencyManager cm = (CurrencyManager)BindingContext[dgGruposContatos.DataSource];
            cm.EndCurrentEdit();
            cm.ResumeBinding();
            cm.SuspendBinding();

            dgGruposContatos.ClearSelection();
            dgGruposContatos.Rows[i].Visible = false;

            MessageBox.Show("O grupo " + grupo + " foi removido com sucesso");
            
        }
    }
}
