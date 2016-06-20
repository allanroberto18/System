using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;
using Libs;
using Manager;

namespace smssim
{
    public partial class FrmMensagens : smssim.FrmMain
    {
        public SerialPort Porta { get; set; }
        public ICollection<ContatosMensagens> ListagemContatos { get; set; }

        public FrmMensagens()
        {
            InitializeComponent();

            LoadButtons();
            LoadGrid();
            LoadGridAgendas();

            dtpAgenda.Format = DateTimePickerFormat.Custom;
            dtpAgenda.CustomFormat = "dd/MM/yyyy H:mm:s";

            string[] ports = SerialPort.GetPortNames();
            foreach (var item in ports)
            {
                mnuPortas.DropDown.Items.Add(item);
            }

            Porta = new SerialPort();

            GetCount();
        }

        public override void NovoButtons()
        {
            btnAdicionarGrupos.Enabled = false;
            btnAdicionarPessoas.Enabled = false;
            btnDisparar.Enabled = false;
            btnPararEnvio.Enabled = false;
            base.NovoButtons();
        }

        public override void EditarButtons()
        {
            btnAdicionarGrupos.Enabled = true;
            btnAdicionarPessoas.Enabled = true;
            // btnDisparar.Enabled = false;
            btnPararEnvio.Enabled = false;

            base.EditarButtons();

            groupAgenda.Enabled = true;
        }

        public override void LoadButtons()
        {
            btnAdicionarGrupos.Enabled = false;
            btnAdicionarPessoas.Enabled = false;
            btnDisparar.Enabled = false;
            btnPararEnvio.Enabled = false;

            base.LoadButtons();
            ForcarSmsUnico();
        }

        public void ForcarSmsUnico()
        {
            string texto = txtMensagem.Text;
            if (chkForcarSMS.Checked)
            {
                int count = texto.Length - 1;
                if (count > 160)
                {
                    texto = texto.Remove(160);
                    txtMensagem.Text = texto;
                }

                txtMensagem.MaxLength = 160;
                return;
            }
            txtMensagem.MaxLength = 500;
        }

        public override void PesquisarButtons()
        {
            btnAdicionarGrupos.Enabled = true;
            btnAdicionarPessoas.Enabled = true;
            btnDisparar.Enabled = false;
            btnPararEnvio.Enabled = false;

            base.PesquisarButtons();
        }
        
        public override void Cancelar()
        {
            btnAdicionarGrupos.Enabled = false;
            btnAdicionarPessoas.Enabled = false;
            btnDisparar.Enabled = false;
            btnPararEnvio.Enabled = false;

            dgvContatos.DataSource = null;
            dgvGrupos.DataSource = null;

            LoadGrid();
            LoadGridAgendas();

            if (backgroundWorker1.IsBusy)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                backgroundWorker1.CancelAsync();
            }
            base.Cancelar();
        }

        public override void LoadGrid()
        {
            MensagensService service = new MensagensService();
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            dgvDados.DataSource = service.Consult();

            dgvDados.Columns["Id"].Visible = true;
            dgvDados.Columns["Id"].HeaderText = "Código";
            dgvDados.Columns["Mensagem"].Visible = true;
            dgvDados.Columns["Mensagem"].HeaderText = "Texto";
            dgvDados.Columns["Tipo"].Visible = true;
            dgvDados.Columns["Tipo"].HeaderText = "Nome Incluso";
            dgvDados.Columns["Sexo"].Visible = true;
            dgvDados.Columns["Sexo"].HeaderText = "Mensagem por sexo";
            dgvDados.Columns["Status"].Visible = true;
            dgvDados.Columns["Status"].HeaderText = "Situação da Mensagem";
            dgvDados.Columns["Created"].Visible = false;
            dgvDados.Columns["Updated"].Visible = false;
            dgvDados.Columns["AgendasMensagens"].Visible = false;
            dgvDados.Columns["Promocoes"].Visible = false;
            dgvDados.Columns["ContatosMensagens"].Visible = false;
            dgvDados.Columns["GruposMensagens"].Visible = false;
            dgvDados.Columns["MensagensDisparos"].Visible = false;

        }
        
        public override bool IsValid()
        {
            string msgMensagem = errorProvider1.GetError(txtMensagem);
            if (msgMensagem.Trim().Length > 0)
            {
                return false;
            }
            return true;
        }

        public override void Salvar()
        {
            ValidarCampos(txtMensagem, errorProvider1, "O campo Mensagem é obrigatório");

            if (!IsValid())
            {
                return;
            }

            MensagensService service = new MensagensService();
            Mensagens entity = new Mensagens();

            entity.SetParams(CheckTipo(), txtMensagem.Text, ReturnSexo(), 1);
            entity.Created = DateTime.Now;
            service.Add(entity);

            if (chkCodigoPromocional.Checked)
            {
                PromocoesManager.Processar(entity.Id, dtpVencimento.Value);
            }

            LoadGridGrupos(entity.Id.ToString());
            LoadGridContatos(entity.Id.ToString());
            LoadGridAgendas(entity.Id.ToString());

            MessageBox.Show("Dados cadastrados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            base.Salvar();

            SelectRegister(entity);

            EditarButtons();
        }

        public override void LoadRegister()
        {
            MensagensService service = new MensagensService();
            Mensagens entity = service.Find(Id);

            txtMensagem.Text = entity.Mensagem;

            ChangeTipo(entity.Tipo);
            switch (entity.Sexo)
            {
                case 1:
                    chkHomens.Checked = true;
                    chkMulheres.Checked = false;
                    break;
                case 2:
                    chkHomens.Checked = false;
                    chkMulheres.Checked = true;
                    break;
                default:
                    chkHomens.Checked = true;
                    chkMulheres.Checked = true;
                    break;
            }

            ChangeStatus(entity.Status);

            PrepararGrids();
            
            base.LoadRegister(entity.Id, entity.Status);

            txt_Id.Text = entity.Id.ToString();
        }

        public void PrepararGrids()
        {
            ContatosMensagensService cmService = new ContatosMensagensService();
            ICollection<ContatosMensagens> listContatosMensagens = cmService.Consult(txt_Id.Text, "Mensagem");
            int countContatosMensagens = listContatosMensagens.Count();

            GruposMensagensService gmService = new GruposMensagensService();
            ICollection<GruposMensagens> listGruposMensagens = gmService.Consult(txt_Id.Text, "Mensagem");
            int countGruposMensagens = listGruposMensagens.Count();

            AgendasMensagensService amService = new AgendasMensagensService();
            ICollection<AgendasMensagens> listAgendasMensagens = amService.Consult(txt_Id.Text, "Mensagem");

            LoadGridContatos(listContatosMensagens);
            LoadGridGrupos(listGruposMensagens);
            LoadGridAgendas(listAgendasMensagens);

            GetCount();

            if (countContatosMensagens > 0 || countGruposMensagens > 0)
            {
                btnDisparar.Enabled = true;
                btnPararEnvio.Enabled = false;
                return;
            }
            btnDisparar.Enabled = false;
            btnPararEnvio.Enabled = false;
        }

        public void SelectRegister(Mensagens entity)
        {
            txt_Id.Text = entity.Id.ToString();
                        
            ChangeTipo(entity.Tipo);

            txtMensagem.Text = entity.Mensagem;

            switch (entity.Sexo)
            {
                case 1:
                    chkHomens.Checked = true;
                    chkMulheres.Checked = false;
                    break;
                case 2:
                    chkHomens.Checked = false;
                    chkMulheres.Checked = true;
                    break;
                default:
                    chkHomens.Checked = true;
                    chkMulheres.Checked = true;
                    break;
            }

            ChangeStatus(entity.Status);

            PrepararGrids();
        }
        
        public override void SelectRegister(int row)
        {
            txt_Id.Text = dgvDados.Rows[row].Cells[0].Value.ToString();

            int tipo = (int)dgvDados.Rows[row].Cells[1].Value;
            
            ChangeTipo(tipo);
            
            txtMensagem.Text = dgvDados.Rows[row].Cells[2].Value.ToString();

            int sexo = (int)dgvDados.Rows[row].Cells[3].Value;
            switch (sexo)
            {
                case 1:
                    chkHomens.Checked = true;
                    chkMulheres.Checked = false;
                    break;
                case 2:
                    chkHomens.Checked = false;
                    chkMulheres.Checked = true;
                    break;
                default:
                    chkHomens.Checked = true;
                    chkMulheres.Checked = true;
                    break;
            }

            ChangeStatus((int)dgvDados.Rows[row].Cells[6].Value);
            
            PrepararGrids();
        }

        public void ChangeTipo(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    chkIncluirNome.Checked = true;
                    chkCodigoPromocional.Checked = false;
                    break;
                case 2:
                    chkIncluirNome.Checked = false;
                    chkCodigoPromocional.Checked = true;
                    break;
                case 3:
                    chkIncluirNome.Checked = true;
                    chkCodigoPromocional.Checked = true;
                    break;
                default:
                    chkIncluirNome.Checked = false;
                    break;
            }
        }

        public override void Alterar()
        {
            ValidarCampos(txtMensagem, errorProvider1, "O campo Mensagem é obrigatório");

            if (!IsValid())
            {
                return;
            }

            int id = Convert.ToInt32(txt_Id.Text);

            Mensagens entity = new Mensagens();
            entity.SetParams(id, CheckTipo(), txtMensagem.Text, ReturnSexo(), ReturnStatus());
            entity.Updated = DateTime.Now;

            MensagensService service = new MensagensService();
            service.Edit(entity);

            if (chkCodigoPromocional.Checked)
            {
                PromocoesManager.Processar(id, dtpVencimento.Value);
            }

            MessageBox.Show("Dados alterados com sucesso", "Informação", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadGridGrupos(txt_Id.Text);
            LoadGridContatos(txt_Id.Text);
            LoadGridAgendas(txt_Id.Text);

            //base.Alterar();
        }

        public override void Pesquisar()
        {
            base.Pesquisar(new FrmMensagensConsult());
        }

        public override void Excluir()
        {
            try
            {
                int id = Convert.ToInt16(txt_Id.Text);

                MensagensService service = new MensagensService();
                Mensagens entity = service.Find(id);

                entity.Status = 9;
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

        public int CheckTipo()
        {
            bool incluirNome = chkIncluirNome.Checked;
            bool codigoPromocional = chkCodigoPromocional.Checked;

            int value = 0;
            if (incluirNome)
            {
                value = 1;
            } 
            if (codigoPromocional)
            {
                value = 2;
            }
            if (codigoPromocional && incluirNome)
            {
                value = 3;
            }
            return value;
        }

        public int ReturnSexo()
        {
            if (chkHomens.Checked)
            {
                int genero = 1;
                if (chkMulheres.Checked)
                {
                    genero = 3;
                }
                return genero;
            }
            if (chkMulheres.Checked)
            {
                return 2;
            }
            return 3;
        }

        public void SelectSexo(int sexo)
        {
            switch (sexo)
            {
                case 1:
                    chkHomens.Checked = true;
                    chkMulheres.Checked = false;
                    break;
                case 2:
                    chkHomens.Checked = false;
                    chkMulheres.Checked = true;
                    break;
                case 3:
                    chkHomens.Checked = true;
                    chkMulheres.Checked = true;
                    break;
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvDados.SelectedRows.Count < 0 && e.RowIndex < 0) || dgvDados.CurrentRow == null)
            {
                return;
            }
            GetDataByRow(e.RowIndex);

            chkForcarSMS.Enabled = true;
        }

        public void LoadGridAgendas(string mensagemId)
        {
            AgendasMensagensService service = new AgendasMensagensService();

            LoadGridAgendas(service.Consult(mensagemId, "Mensagem"));
        }

        public void LoadGridAgendas()
        {
            AgendasMensagensService service = new AgendasMensagensService();

            LoadGridAgendas(service.Consult("status", ""));
        }

        public void LoadGridAgendas(ICollection<AgendasMensagens> list)
        {
            string labelTbAgendamentos = "Agendamento de Mensagens";
            
            int count = list.Count();
            if (count > 0)
            {
                dgvAgendamento.DataSource = list;

                tbAgendamentos.Text = labelTbAgendamentos + ": " + count + " Mensagens pendentes para envio";
                tbMensagem.SelectedTab = tbAgendamentos;

                dgvAgendamento.Columns["Id"].Visible = true;
                dgvAgendamento.Columns["Id"].HeaderText = "Código";
                dgvAgendamento.Columns["Envio"].Visible = true;
                dgvAgendamento.Columns["Envio"].HeaderText = "Data de Envio";
                dgvAgendamento.Columns["Mensagem"].Visible = true;
                dgvAgendamento.Columns["MensagemId"].Visible = false;
                dgvAgendamento.Columns["Created"].Visible = false;
                dgvAgendamento.Columns["Updated"].Visible = false;
                dgvAgendamento.Columns["Status"].Visible = false;

                return;
            }
            dgvAgendamento.DataSource = null;
            tbAgendamentos.Text = labelTbAgendamentos;
        }

        public void LoadGridGrupos(ICollection<GruposMensagens> list)
        {
            int count = list.Count();
            if (count > 0)
            {
                dgvGrupos.DataSource = list;

                dgvGrupos.Columns["GrupoId"].Visible = true;
                dgvGrupos.Columns["GrupoId"].HeaderText = "Código";
                dgvGrupos.Columns["Grupo"].Visible = true;
                dgvGrupos.Columns["Grupo"].HeaderText = "Nome do Grupo";
                dgvGrupos.Columns["Id"].Visible = false;
                dgvGrupos.Columns["MensagemId"].Visible = false;
                dgvGrupos.Columns["Mensagem"].Visible = false;
                dgvGrupos.Columns["Updated"].Visible = false;
                dgvGrupos.Columns["Created"].Visible = false;
                dgvGrupos.Columns["Status"].Visible = false;

                return;
            }
            dgvGrupos.DataSource = null;
        }

        public void LoadGridGrupos(string idMensagem)
        {
            GruposMensagensService service = new GruposMensagensService();

            LoadGridGrupos(service.Consult(idMensagem, "Mensagem"));
        }

        public void PesquisarGrupos()
        {
            FrmGruposConsult form = new FrmGruposConsult();

            form.ShowDialog();

            GruposMensagensService service = new GruposMensagensService();
            if (form.Lista == null)
            {
                return;
            }

            if (form.Lista.Length > 0)
            {
                int idMsg = Convert.ToInt32(txt_Id.Text);
                foreach (int item in form.Lista)
                {
                    GruposMensagens entity = new GruposMensagens();
                    entity.SetParams(item, idMsg, 1);
                    entity.Created = DateTime.Now;

                    service.Add(entity);
                }

            }
            LoadGridGrupos(txt_Id.Text);
            LoadGridContatos(txt_Id.Text);
            LoadGridAgendas(txt_Id.Text);

            btnDisparar.Enabled = true;

            GetCount();
        }

        public void LoadGridContatos(ICollection<ContatosMensagens> list)
        {
            int count = list.Count();
            if (count > 0)
            {
                dgvContatos.DataSource = list;
                
                dgvContatos.Columns["ContatoId"].Visible = true;
                dgvContatos.Columns["ContatoId"].HeaderText = "Código";
                dgvContatos.Columns["Contato"].Visible = true;
                dgvContatos.Columns["Contato"].HeaderText = "Nome do Contato";
                dgvContatos.Columns["Mensagem"].Visible = false;

                dgvContatos.Columns["Id"].Visible = false;
                dgvContatos.Columns["MensagemId"].Visible = false;
                dgvContatos.Columns["Created"].Visible = false;
                dgvContatos.Columns["Updated"].Visible = false;
                dgvContatos.Columns["status"].Visible = false;

                return;
            }
            dgvContatos.DataSource = null;

        }

        public void LoadGridContatos(string idMensagem)
        {
            ContatosMensagensService service = new ContatosMensagensService();

            LoadGridContatos(service.Consult(idMensagem, "Mensagem"));
        }

        public void PesquisarContatos()
        {
            FrmContatosConsult form = new FrmContatosConsult();

            form.ShowDialog();

            ContatosMensagensService service = new ContatosMensagensService();
            if (form.Lista == null)
            {
                return;
            }
            if (form.Lista.Length > 0)
            {
                foreach (int item in form.Lista)
                {
                    ContatosMensagens entity = new ContatosMensagens();
                    entity.SetParams(Convert.ToInt32(txt_Id.Text), item, 1);
                    entity.Created = DateTime.Now;
                    service.Add(entity);
                }
            }

            LoadGridGrupos(txt_Id.Text);
            LoadGridContatos(txt_Id.Text);
            LoadGridAgendas(txt_Id.Text);

            btnDisparar.Enabled = true;

            GetCount();
        }

        private void btnDisparar_Click(object sender, EventArgs e)
        {
            btnDisparar.Enabled = false;
            btnPararEnvio.Enabled = true;

            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;
            backgroundWorker1.RunWorkerAsync();
        }

        public DialogResult ReenviarMsg(int status)
        {
            DialogResult result = DialogResult.Yes;
            switch (status)
            {
                case 2:
                    result = MessageBox.Show("Essa mensagem já foi enviada, deseja envia-la novamente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                default:
                    return result;
            }
            return result;
        }

        public void ExecutarTarefa(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(i);
                lblMsgProcessadas.BeginInvoke(
                    new Action(() =>
                    {
                        lblMsgProcessadas.Text = p.ToString() + "% Concluído";
                    }
                ));
            }
        }

        private void btnAdicionarGrupos_Click(object sender, EventArgs e)
        {
            PesquisarGrupos();
        }

        private void btnAdicionarPessoas_Click(object sender, EventArgs e)
        {
            PesquisarContatos();
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {
            lblQuantidade.Text = txtMensagem.Text.Length.ToString();
        }

        private void btnSalvarAgendamento_Click(object sender, EventArgs e)
        {
            AgendasMensagensService amService = new AgendasMensagensService();
            AgendasMensagens am = new AgendasMensagens();

            am.SetParams(Convert.ToInt32(txt_Id.Text), dtpAgenda.Value, 1);
            am.Created = DateTime.Today;

            amService.Add(am);

            LoadGridAgendas();

            MessageBox.Show("Mensagem agendada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkForcarSMS_CheckedChanged(object sender, EventArgs e)
        {
            ForcarSmsUnico();
        }

        public override void Relatorio()
        {
            int id;
            bool teste = int.TryParse(txt_Id.Text, out id);
            if (teste)
            {
                FrmMensagensDisparosReporsts rptMdReporsts = new FrmMensagensDisparosReporsts();
                rptMdReporsts.Id = id;
                rptMdReporsts.ShowDialog();

                return;
            }
            FrmMensagensReports rptMReports = new FrmMensagensReports();
            rptMReports.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            MensagensService mService = new MensagensService();
            Mensagens msg = mService.Find(Convert.ToInt32(txt_Id.Text));

            DialogResult resultMsg = ReenviarMsg(msg.Status);

            if (resultMsg == DialogResult.No)
            {
                e.Cancel = true;
                backgroundWorker1.ReportProgress(0);
                return;
            }

            ContatosMensagensService cmService = new ContatosMensagensService();
            ICollection<ContatosMensagens> cmList = cmService.Consult(msg.Id.ToString(), "Pendentes");

            try
            {
                int count = cmList.Count;
                int i = 0;

                if (count == 0)
                {
                    MessageBox.Show("Não existem contatos selecionados para essa mensagem.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                foreach (ContatosMensagens item in cmList)
                {
                    MensagensManager.ProcessarContatos(msg, item);

                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }

                    i++;
                    int p = (i * 100) / count;
                    ExecutarTarefa(p);

                    backgroundWorker1.ReportProgress(p);
                }
                
                msg.Status = 2;
                mService.Edit(msg);
                
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                backgroundWorker1.ReportProgress(0);
                MessageBox.Show(ex.Message, "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListagemContatos = cmList;

            GetCount();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            lblMsgProcessadas.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblMsgProcessadas.Text = "Nenhuma mensagem enviada";

                btnDisparar.Enabled = true;
                btnPararEnvio.Enabled = false;

                backgroundWorker1.CancelAsync();

                return;
            }
            if (e.Cancelled)
            {
                lblMsgProcessadas.Text = "Nenhuma mensagem enviada";

                btnDisparar.Enabled = true;
                btnPararEnvio.Enabled = false;

                return;
            }
            ContatosMensagensService services = new ContatosMensagensService();
            ICollection<ContatosMensagens> cmList = services.Consult(txt_Id.Text, "Processados");
            lblMsgProcessadas.Text = cmList.Count() + " processadas";

            services.ReorganizarContatosMensagens(Convert.ToInt32(txt_Id.Text));

            MessageBox.Show("A mensagem foi enviada para " + cmList.Count() + " contatos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDisparar.Enabled = true;
            btnPararEnvio.Enabled = false;
        }

        private void chkCodigoPromocional_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCodigoPromocional.Checked)
            {
                chkForcarSMS.Checked = true;
                chkForcarSMS.Enabled = false;
                txtMensagem.MaxLength = 154;

                gbxPromocao.Enabled = true;

                return;
            }
            chkForcarSMS.Checked = true;
            chkForcarSMS.Enabled = true;
            txtMensagem.MaxLength = 160;

            gbxPromocao.Enabled = false;
        }

        private void dgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvGrupos.SelectedRows.Count < 0 && e.RowIndex < 0) || dgvGrupos.CurrentRow == null)
            {
                return;
            }

            int id = Convert.ToInt32(dgvGrupos.Rows[e.RowIndex].Cells[1].Value);
            int mensagem = Convert.ToInt32(txt_Id.Text);

            GruposMensagensService service = new GruposMensagensService();
            service.FindRemoveByMensagemAndGrupo(mensagem, id);

            LoadGridGrupos(txt_Id.Text);
            LoadGridContatos(txt_Id.Text);

            GetCount();
        }

        public override void Novo()
        {
            base.Novo();

            chkForcarSMS.Checked = true;
            chkIncluirNome.Checked = true;
            chkHomens.Checked = true;
            chkMulheres.Checked = true;
        }

        private void dgvDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cell = e.ColumnIndex;
            bool teste;
            switch (cell)
            {
                case 1:
                    int tipo;
                    teste = int.TryParse(e.Value.ToString(), out tipo);
                    if (teste)
                    {
                        switch (tipo)
                        {
                            case 1:
                                e.Value = "Sim";
                                break;
                            case 2:
                                e.Value = "Não";
                                break;
                            case 3:
                                e.Value = "Sim";
                                break;
                        }
                    }
                    break;
                case 3:
                    int sexo;
                    teste = int.TryParse(e.Value.ToString(), out sexo);
                    if (teste)
                    {
                        switch (sexo)
                        {
                            case 1:
                                e.Value = "Masculino";
                                break;
                            case 2:
                                e.Value = "Mulheres";
                                break;
                            case 3:
                                e.Value = "Ambos";
                                break;
                        }
                    }
                    break;
                case 6:
                    int status;
                    teste = int.TryParse(e.Value.ToString(), out status);
                    if (teste)
                    {
                        switch (status)
                        {
                            case 1:
                                e.Value = "Aguardando Envio";
                                break;
                            case 2:
                                e.Value = "Enviado";
                                break;
                        }
                    }
                    break;
            }
        }

        private void dgvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvContatos.SelectedRows.Count < 0 && e.RowIndex < 0) || dgvContatos.CurrentRow == null)
            {
                return;
            }

            int id = Convert.ToInt32(dgvContatos.Rows[e.RowIndex].Cells[1].Value);
            int mensagem = Convert.ToInt32(txt_Id.Text);

            ContatosMensagensService service = new ContatosMensagensService();
            service.RemoverMensagemContatoByMensagemByContato(mensagem, id);

            LoadGridContatos(txt_Id.Text);
            
            GetCount();
        }

        public void GetCount()
        {
            MensagensDisparosService mdService = new MensagensDisparosService();
            lblMensagensDisparadas.Text = AppConfig.GetValue("disparos");

            if (!String.IsNullOrEmpty(txt_Id.Text))
            {
                int mensagem = Convert.ToInt32(txt_Id.Text);

                ContatosMensagensService cmService = new ContatosMensagensService();
                lblCountContatos.Text = cmService.ReturnCountContatos(mensagem).ToString();

                GruposMensagensService gmService = new GruposMensagensService();
                lblCountGrupos.Text = gmService.ReturnCountGrupos(mensagem).ToString();

                return;
            }
            lblCountContatos.Text = "0";
            lblCountGrupos.Text = "0";
        }

        private void btnPararEnvio_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                lblMensagensDisparadas.Text = "Envio cancelado";
            }
            btnDisparar.Enabled = true;
            btnPararEnvio.Enabled = false;
        }

        private void FrmMensagens_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void mnuPortas_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AppConfig.UpdateSetting("porta", e.ClickedItem.Text);
            mnuPortas.DropDownItems.IndexOf(e.ClickedItem);
        }
    }
}
