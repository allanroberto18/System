using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Libs;

namespace smssim
{
    public partial class FrmMain : Form
    {
        public int Id { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            toolTip1.SetToolTip(this.txt_Id, "Digite o código neste campo e clique no botão ao lado");
            toolTip1.SetToolTip(this.btnPesquisarId, "Digite o código neste campo e clique no botão ao lado");
        }

        public virtual void LoadButtons()
        {
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;

            gbxFormulario.Enabled = false;

            txt_Id.Enabled = true;
            btnPesquisarId.Enabled = true;
        }

        public virtual void LoadGrid()
        {
            txt_Id.Enabled = true;
        }

        public virtual void LoadRegister()
        {
            
        }

        public virtual void LoadRegister(int id, int status)
        {
            this.ChangeStatus(id);
            //this.CheckId(status);

            gbxFormulario.Enabled = true;

            this.Editar();
        }

        public virtual void SelectRegister(int row)
        {
            if (row < 0)
            {
                return;
            }
        }

        public void GetDataByRow(int row)
        {
            this.SelectRegister(row);

            EditarButtons();
        }

        public int ReturnStatus()
        {
            int value = 0;
            if (rbAtivo.Checked)
            {
                value = 1;
            }
            if (rbInativo.Checked)
            {
                value = 2;
            }
            return value;
        }

        public virtual void NovoButtons()
        {
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            
            txt_Id.Enabled = false;
            btnPesquisarId.Enabled = false;

            this.LimparText(this);

            gbxFormulario.Enabled = true;
            gbxStatus.Enabled = true;

            rbAtivo.Checked = true;
        }
        
        public virtual void EditarButtons()
        {
            btnNovo.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            
            btnPesquisar.Enabled = false;

            gbxFormulario.Enabled = true;

            txt_Id.Enabled = false;
            btnPesquisarId.Enabled = false;

            gbxStatus.Enabled = true;
        }

        public virtual void PesquisarButtons()
        {
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = false;

            gbxFormulario.Enabled = true;

            txt_Id.Enabled = false;
            btnPesquisarId.Enabled = false;
        }

        public virtual void Novo()
        {
            txt_Id.Enabled = false;
        }

        public virtual void Salvar()
        {
            txt_Id.Enabled = true;

            if (this.IsValid())
            {
                this.LimparText(this);
                this.LoadButtons();
                this.LoadGrid();
            }
        }

        public virtual void Cancelar()
        {
            txt_Id.ReadOnly = false;

            this.LimparText(this);
        }

        public virtual void Editar()
        {
            this.EditarButtons();
        }

        public virtual void Relatorio()
        {
            MessageBox.Show("Esta opção está em desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public virtual void Alterar()
        {
            this.LimparText(this);
            this.LoadButtons();
            this.LoadGrid();
        }

        public virtual void Excluir()
        {
            this.LimparText(this);
            this.LoadButtons();
            this.LoadGrid();
        }

        public virtual void Pesquisar()
        {
            this.LimparText(this);
        }

        public virtual void Pesquisar(FrmMainConsult form)
        {
            form.ShowDialog();

            if (form.Id.HasValue)
            {
                this.Id = form.Id.Value;
                LoadRegister();
            }
            else
            {
                LoadButtons();
            }
        }

        public void LimparText(Control con)
        {
            AppSystem.LimparText(this);
        }

        public virtual bool IsValid()
        {
            return false;
        }

        public void ValidarCampos(TextBox textBox, ErrorProvider erro, String mensagem)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text))
            {
                erro.SetError(textBox, "");
            }
            else
            {
                erro.SetError(textBox, mensagem);
            }
        }

        public void ValidarDatePicker(DateTimePicker textBox, ErrorProvider erro, String mensagem)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text))
            {
                erro.SetError(textBox, "");
            }
            else
            {
                erro.SetError(textBox, mensagem);
            }
        }

        public void ValidarMaskCampos(MaskedTextBox textBox, ErrorProvider erro, String mensagem)
        {
            if (textBox.MaskFull)
            {
                erro.SetError(textBox, "");
            }
            else
            {
                erro.SetError(textBox, mensagem);
            }
        }

        public void CompararCampos(TextBox textBox1, TextBox textBox2, ErrorProvider erro, String mensagem)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (textBox1.Text == textBox2.Text)
                {
                    erro.SetError(textBox1, "");
                    erro.SetError(textBox2, "");
                }
            }
            else
            {
                erro.SetError(textBox1, mensagem);
                erro.SetError(textBox2, mensagem);
            }
        }

        public void ValidarInteiro(TextBox textBox, ErrorProvider erro, String mensagem)
        {
            int teste;
            if (int.TryParse(textBox.Text, out teste))
            {
                erro.SetError(textBox, "");
            }
            else
            {
                erro.SetError(textBox, mensagem);
            }
        }

        public void ValidarEmail(TextBox textBox, ErrorProvider erro)
        {
            bool isEmail = Regex.IsMatch(textBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail == true)
            {
                erro.SetError(textBox, "");
            }
            else
            {
                erro.SetError(textBox, "E-mail inválido");
            }
        }

        public void CheckId(int? id)
        {
            if (id.GetValueOrDefault(0) == 0)
            {
                txt_Id.Text = "";
                txt_Id.ReadOnly = false;
            }
            else
            {
                txt_Id.Text = "";
                txt_Id.ReadOnly = true;
            }
        }

        public void ChangeStatus(int status)
        {
            switch (status)
            {
                case 1:
                    rbAtivo.Checked = true;
                    rbInativo.Checked = false;
                    break;
                case 2:
                    rbAtivo.Checked = false;
                    rbInativo.Checked = true;
                    break;
                default:
                    rbAtivo.Checked = true;
                    rbInativo.Checked = false;
                    break;
            }
            gbxStatus.Enabled = true;
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            this.NovoButtons();
            this.Novo();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Salvar();
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LoadButtons();
            this.Cancelar();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            
            this.Editar();
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Alterar();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.PesquisarButtons();
            this.Pesquisar();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            this.EditarButtons();
            this.Excluir();
        }
        
        protected void txt_Id_Leave(object sender, EventArgs e)
        {
            this.LoadRegister();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Relatorio();
        }

        public virtual void PesquisarId()
        {
            int id;
            bool testeId = int.TryParse(txt_Id.Text, out id);

            if (txt_Id.Text.Trim().Length > 0 && testeId)
            {
                this.Id = id;
                this.LoadRegister();
            }
            else
            {
                MessageBox.Show("O código especificado deve ser um valor numérico", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.CheckId(null);
            }
        }

        private void btnPesquisarId_Click(object sender, EventArgs e)
        {
            this.PesquisarId();
        }
    }
}
