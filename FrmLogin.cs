using System;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;
using Libs;
using Manager;

namespace smssim
{
    public partial class FrmLogin : Form
    {
        public int Id { get; set; }
        public string Usuario { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool IsValid()
        {
            string email = errorProvider1.GetError(txtEmail);
            string senha = errorProvider1.GetError(txtSenha);
            if (email.Trim().Length > 0 && senha.Trim().Length > 0)
            {
                return false;
            }
            return true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Validacao.ValidarCampos(txtEmail, errorProvider1, "O campo E-mail é obrigatório");
            Validacao.ValidarCampos(txtSenha, errorProvider1, "O campo Senha é obrigatório");

            if (!IsValid())
            {
                return;
            }
            UsuariosService service = new UsuariosService();

            string retorno = service.ProcessarLogin(txtEmail.Text, txtSenha.Text);
            if (!String.IsNullOrEmpty(retorno))
            {
                MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Usuarios usuario = service.GetLogin(txtEmail.Text, txtSenha.Text);
            if (!String.IsNullOrEmpty(usuario.Nome))
            {
                Id = usuario.Id;
                Usuario = usuario.Nome;

                ConfiguracoesManager.ProcessarConfiguracoes(Id);

                UsuariosAcessosService acessosService = new UsuariosAcessosService();
                acessosService.Add(new UsuariosAcessos() { UsuarioId = Id, Created = DateTime.Now, Status = 1 });

                Close();
            }
        }
    }
}
