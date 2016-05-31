using System;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;
using Libs;

namespace smssim
{
    public partial class FrmUsuarios : smssim.FrmMain
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            LoadButtons();
            LoadGrid();
        }

        public override void LoadGrid()
        {
            UsuariosService service = new UsuariosService();
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDados.DataSource = service.Consult();

            dgvDados.Columns["Id"].Visible = true;
            dgvDados.Columns["Id"].HeaderText = "Código";
            dgvDados.Columns["nome"].Visible = true;
            dgvDados.Columns["nome"].HeaderText = "Nome do Usuário";
            dgvDados.Columns["email"].Visible = true;
            dgvDados.Columns["email"].HeaderText = "E-mail";
            dgvDados.Columns["senha"].Visible = false;
            dgvDados.Columns["status"].Visible = false;
        }

        public override bool IsValid()
        {
            string msgNome = errorProvider1.GetError(txtNome);
            string msgEmail = errorProvider1.GetError(txtEmail);
            string msgSenha = errorProvider1.GetError(txtSenha);
            string msgConfirmarSenha = errorProvider1.GetError(txtConfirmarSenha);
            if (msgNome.Trim().Length > 0 || msgEmail.Trim().Length > 0 || msgSenha.Trim().Length > 0 ||
                msgConfirmarSenha.Trim().Length > 0)
            {
                return false;
            }
            return true;
        }

        public override void Salvar()
        {
            ValidarCampos(txtNome, errorProvider1, "O campo nome é obrigatório");
            ValidarCampos(txtEmail, errorProvider1, "O campo e-mail é obrigatório");
            ValidarEmail(txtEmail, errorProvider1);
            ValidarCampos(txtSenha, errorProvider1, "O campo senha é obrigatório");
            ValidarCampos(txtConfirmarSenha, errorProvider1, "O campo confirmar senha é obrigatório");
            CompararCampos(txtSenha, txtConfirmarSenha, errorProvider1, "Os campos senha e confirmação de senha devem ser iguais");
            
            if (IsValid())
            {
                Usuarios entity = new Usuarios();
                entity.SetParams(txtNome.Text, txtEmail.Text, txtSenha.Text, ReturnStatus());
                entity.Created = DateTime.Now;

                UsuariosService service = new UsuariosService();
                service.Add(entity);

                MessageBox.Show("Dados cadastrados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.Salvar();
            }
        }

        public override void LoadRegister()
        {
            UsuariosService service = new UsuariosService();
            Usuarios entity = service.Find(Id);

            txt_Id.Text = entity.Id.ToString();
            txtNome.Text = entity.Nome;
            txtEmail.Text = entity.Email;
            txtSenha.Text = entity.Senha;
            txtConfirmarSenha.Text = entity.Senha;

            base.LoadRegister(entity.Id, entity.Status);
        }

        public override void SelectRegister(int row)
        {
            txt_Id.Text = dgvDados.Rows[row].Cells[0].Value.ToString();
            txtNome.Text = dgvDados.Rows[row].Cells[1].Value.ToString();
            txtEmail.Text = dgvDados.Rows[row].Cells[2].Value.ToString();
            txtSenha.Text = dgvDados.Rows[row].Cells[3].Value.ToString();
            txtConfirmarSenha.Text = dgvDados.Rows[row].Cells[3].Value.ToString();

            ChangeStatus((int)dgvDados.Rows[row].Cells[6].Value);
        }

        public override void PesquisarId()
        {
            base.PesquisarId();
        }

        public override void EditarButtons()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            int autorizacao = Convert.ToInt32(AppConfig.GetValue("user"));
            if (id == 1 && autorizacao != 1)
            {
                base.LoadButtons();
            }
            else
            {
                base.EditarButtons();
            }
        }

        public override void Alterar()
        {
            ValidarCampos(txtNome, errorProvider1, "O campo nome é obrigatório");
            ValidarCampos(txtEmail, errorProvider1, "O campo e-mail é obrigatório");
            ValidarEmail(txtEmail, errorProvider1);
            ValidarCampos(txtSenha, errorProvider1, "O campo senha é obrigatório");
            ValidarCampos(txtConfirmarSenha, errorProvider1, "O campo confirmar senha é obrigatório");
            CompararCampos(txtSenha, txtConfirmarSenha, errorProvider1, "Os campos senha e confirmação de senha devem ser iguais");

            if (IsValid())
            {
                int id = Convert.ToInt32(txt_Id.Text);

                Usuarios entity = new Usuarios();
                entity.SetParams(id, txtNome.Text, txtEmail.Text, txtSenha.Text, ReturnStatus());

                entity.Updated = DateTime.Now;

                UsuariosService service = new UsuariosService();
                service.Edit(entity);

                MessageBox.Show("Dados alterados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.Alterar();
            }
        }

        public override void Pesquisar()
        {
            base.Pesquisar(new FrmUsuariosConsult());
        }

        public override void Excluir()
        {
            try
            {
                int id = Convert.ToInt16(txt_Id.Text);

                UsuariosService service = new UsuariosService();
                Usuarios entity = service.Find(id);
                entity.Status = 2;
                entity.Updated = DateTime.Now;
                
                service.Edit(entity);

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
    }
}
