namespace smssim
{
    partial class FrmMensagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensagens));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.tbMensagem = new System.Windows.Forms.TabControl();
            this.tbMensagens = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tbAgendamentos = new System.Windows.Forms.TabPage();
            this.groupAgenda = new System.Windows.Forms.GroupBox();
            this.btnSalvarAgendamento = new System.Windows.Forms.Button();
            this.dtpAgenda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.tbContatoGrupos = new System.Windows.Forms.TabControl();
            this.tbGrupos = new System.Windows.Forms.TabPage();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.tbPessoas = new System.Windows.Forms.TabPage();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.chkIncluirNome = new System.Windows.Forms.CheckBox();
            this.chkForcarSMS = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMsgProcessadas = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblContatosSelecionados = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountContatos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblGruposSelecionados = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountGrupos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQtdeMsgDisparos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMensagensDisparadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSelecionarPorta = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPortas = new System.Windows.Forms.ToolStripSplitButton();
            this.chkCodigoPromocional = new System.Windows.Forms.CheckBox();
            this.gbxPromocao = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.chkHomens = new System.Windows.Forms.CheckBox();
            this.chkMulheres = new System.Windows.Forms.CheckBox();
            this.btnPararEnvio = new System.Windows.Forms.Button();
            this.btnAdicionarPessoas = new System.Windows.Forms.Button();
            this.btnDisparar = new System.Windows.Forms.Button();
            this.btnAdicionarGrupos = new System.Windows.Forms.Button();
            this.gbxFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbxStatus.SuspendLayout();
            this.tbMensagem.SuspendLayout();
            this.tbMensagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tbAgendamentos.SuspendLayout();
            this.groupAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            this.tbContatoGrupos.SuspendLayout();
            this.tbGrupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.tbPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gbxPromocao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFormulario
            // 
            this.gbxFormulario.Controls.Add(this.chkMulheres);
            this.gbxFormulario.Controls.Add(this.chkHomens);
            this.gbxFormulario.Controls.Add(this.chkForcarSMS);
            this.gbxFormulario.Controls.Add(this.chkCodigoPromocional);
            this.gbxFormulario.Controls.Add(this.chkIncluirNome);
            this.gbxFormulario.Controls.Add(this.lblQuantidade);
            this.gbxFormulario.Controls.Add(this.label1);
            this.gbxFormulario.Controls.Add(this.txtMensagem);
            this.gbxFormulario.Controls.Add(this.lblMensagem);
            this.gbxFormulario.Location = new System.Drawing.Point(12, 132);
            this.gbxFormulario.Size = new System.Drawing.Size(330, 203);
            // 
            // rbInativo
            // 
            this.rbInativo.Location = new System.Drawing.Point(19, 19);
            this.rbInativo.Size = new System.Drawing.Size(64, 17);
            this.rbInativo.Text = "Enviada";
            // 
            // rbAtivo
            // 
            this.rbAtivo.Location = new System.Drawing.Point(18, 40);
            this.rbAtivo.Size = new System.Drawing.Size(113, 17);
            this.rbAtivo.Text = "Aguardando Envio";
            // 
            // gbxStatus
            // 
            this.gbxStatus.Location = new System.Drawing.Point(12, 341);
            this.gbxStatus.Size = new System.Drawing.Size(162, 73);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(15, 23);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(62, 13);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(18, 39);
            this.txtMensagem.MaxLength = 500;
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(288, 107);
            this.txtMensagem.TabIndex = 4;
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            // 
            // tbMensagem
            // 
            this.tbMensagem.Controls.Add(this.tbMensagens);
            this.tbMensagem.Controls.Add(this.tbAgendamentos);
            this.tbMensagem.Location = new System.Drawing.Point(352, 104);
            this.tbMensagem.Name = "tbMensagem";
            this.tbMensagem.SelectedIndex = 0;
            this.tbMensagem.Size = new System.Drawing.Size(420, 220);
            this.tbMensagem.TabIndex = 4;
            // 
            // tbMensagens
            // 
            this.tbMensagens.Controls.Add(this.dgvDados);
            this.tbMensagens.Location = new System.Drawing.Point(4, 22);
            this.tbMensagens.Name = "tbMensagens";
            this.tbMensagens.Padding = new System.Windows.Forms.Padding(3);
            this.tbMensagens.Size = new System.Drawing.Size(412, 194);
            this.tbMensagens.TabIndex = 3;
            this.tbMensagens.Text = "Mensagens";
            this.tbMensagens.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(406, 188);
            this.dgvDados.TabIndex = 5;
            this.dgvDados.VirtualMode = true;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            this.dgvDados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDados_CellFormatting);
            // 
            // tbAgendamentos
            // 
            this.tbAgendamentos.Controls.Add(this.groupAgenda);
            this.tbAgendamentos.Controls.Add(this.dgvAgendamento);
            this.tbAgendamentos.Location = new System.Drawing.Point(4, 22);
            this.tbAgendamentos.Name = "tbAgendamentos";
            this.tbAgendamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tbAgendamentos.Size = new System.Drawing.Size(412, 194);
            this.tbAgendamentos.TabIndex = 2;
            this.tbAgendamentos.Text = "Agendamento das Mensagens";
            this.tbAgendamentos.UseVisualStyleBackColor = true;
            // 
            // groupAgenda
            // 
            this.groupAgenda.Controls.Add(this.btnSalvarAgendamento);
            this.groupAgenda.Controls.Add(this.dtpAgenda);
            this.groupAgenda.Controls.Add(this.label2);
            this.groupAgenda.Location = new System.Drawing.Point(3, 6);
            this.groupAgenda.Name = "groupAgenda";
            this.groupAgenda.Size = new System.Drawing.Size(406, 54);
            this.groupAgenda.TabIndex = 5;
            this.groupAgenda.TabStop = false;
            this.groupAgenda.Text = "Preencher Campo:";
            // 
            // btnSalvarAgendamento
            // 
            this.btnSalvarAgendamento.Location = new System.Drawing.Point(276, 20);
            this.btnSalvarAgendamento.Name = "btnSalvarAgendamento";
            this.btnSalvarAgendamento.Size = new System.Drawing.Size(124, 22);
            this.btnSalvarAgendamento.TabIndex = 5;
            this.btnSalvarAgendamento.Text = "Agendar Mensagem";
            this.btnSalvarAgendamento.UseVisualStyleBackColor = true;
            this.btnSalvarAgendamento.Click += new System.EventHandler(this.btnSalvarAgendamento_Click);
            // 
            // dtpAgenda
            // 
            this.dtpAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAgenda.Location = new System.Drawing.Point(90, 21);
            this.dtpAgenda.Name = "dtpAgenda";
            this.dtpAgenda.Size = new System.Drawing.Size(182, 20);
            this.dtpAgenda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de Envio:";
            // 
            // dgvAgendamento
            // 
            this.dgvAgendamento.AllowUserToAddRows = false;
            this.dgvAgendamento.AllowUserToDeleteRows = false;
            this.dgvAgendamento.AllowUserToOrderColumns = true;
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Location = new System.Drawing.Point(3, 66);
            this.dgvAgendamento.Name = "dgvAgendamento";
            this.dgvAgendamento.ReadOnly = true;
            this.dgvAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgendamento.Size = new System.Drawing.Size(406, 125);
            this.dgvAgendamento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Qtde de Caractéres: ";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(196, 23);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(13, 13);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "0";
            // 
            // tbContatoGrupos
            // 
            this.tbContatoGrupos.Controls.Add(this.tbGrupos);
            this.tbContatoGrupos.Controls.Add(this.tbPessoas);
            this.tbContatoGrupos.Location = new System.Drawing.Point(352, 330);
            this.tbContatoGrupos.Name = "tbContatoGrupos";
            this.tbContatoGrupos.SelectedIndex = 0;
            this.tbContatoGrupos.Size = new System.Drawing.Size(420, 220);
            this.tbContatoGrupos.TabIndex = 10;
            // 
            // tbGrupos
            // 
            this.tbGrupos.Controls.Add(this.dgvGrupos);
            this.tbGrupos.Location = new System.Drawing.Point(4, 22);
            this.tbGrupos.Name = "tbGrupos";
            this.tbGrupos.Padding = new System.Windows.Forms.Padding(3);
            this.tbGrupos.Size = new System.Drawing.Size(412, 194);
            this.tbGrupos.TabIndex = 0;
            this.tbGrupos.Text = "Grupos Selecionados";
            this.tbGrupos.UseVisualStyleBackColor = true;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowDrop = true;
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToOrderColumns = true;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrupos.Location = new System.Drawing.Point(3, 3);
            this.dgvGrupos.MultiSelect = false;
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            this.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupos.Size = new System.Drawing.Size(406, 188);
            this.dgvGrupos.TabIndex = 0;
            this.dgvGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellDoubleClick);
            // 
            // tbPessoas
            // 
            this.tbPessoas.Controls.Add(this.dgvContatos);
            this.tbPessoas.Location = new System.Drawing.Point(4, 22);
            this.tbPessoas.Name = "tbPessoas";
            this.tbPessoas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPessoas.Size = new System.Drawing.Size(412, 194);
            this.tbPessoas.TabIndex = 1;
            this.tbPessoas.Text = "Contatos Selecionados";
            this.tbPessoas.UseVisualStyleBackColor = true;
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AllowUserToDeleteRows = false;
            this.dgvContatos.AllowUserToOrderColumns = true;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(3, 3);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.ReadOnly = true;
            this.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatos.Size = new System.Drawing.Size(406, 188);
            this.dgvContatos.TabIndex = 0;
            this.dgvContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellDoubleClick);
            // 
            // chkIncluirNome
            // 
            this.chkIncluirNome.AutoSize = true;
            this.chkIncluirNome.Checked = true;
            this.chkIncluirNome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncluirNome.Location = new System.Drawing.Point(18, 152);
            this.chkIncluirNome.Name = "chkIncluirNome";
            this.chkIncluirNome.Size = new System.Drawing.Size(85, 17);
            this.chkIncluirNome.TabIndex = 7;
            this.chkIncluirNome.Text = "Incluir Nome";
            this.chkIncluirNome.UseVisualStyleBackColor = true;
            // 
            // chkForcarSMS
            // 
            this.chkForcarSMS.AutoSize = true;
            this.chkForcarSMS.Checked = true;
            this.chkForcarSMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForcarSMS.Location = new System.Drawing.Point(222, 22);
            this.chkForcarSMS.Name = "chkForcarSMS";
            this.chkForcarSMS.Size = new System.Drawing.Size(91, 17);
            this.chkForcarSMS.TabIndex = 8;
            this.chkForcarSMS.Text = "Forçar 1 SMS";
            this.chkForcarSMS.UseVisualStyleBackColor = true;
            this.chkForcarSMS.CheckedChanged += new System.EventHandler(this.chkForcarSMS_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 435);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mensagens Processadas:";
            // 
            // lblMsgProcessadas
            // 
            this.lblMsgProcessadas.AutoSize = true;
            this.lblMsgProcessadas.Location = new System.Drawing.Point(133, 419);
            this.lblMsgProcessadas.Name = "lblMsgProcessadas";
            this.lblMsgProcessadas.Size = new System.Drawing.Size(13, 13);
            this.lblMsgProcessadas.TabIndex = 13;
            this.lblMsgProcessadas.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblContatosSelecionados,
            this.lblCountContatos,
            this.toolStripStatusLabel5,
            this.lblGruposSelecionados,
            this.lblCountGrupos,
            this.toolStripStatusLabel2,
            this.lblQtdeMsgDisparos,
            this.lblMensagensDisparadas,
            this.toolStripStatusLabel4,
            this.lblSelecionarPorta,
            this.mnuPortas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblContatosSelecionados
            // 
            this.lblContatosSelecionados.BackColor = System.Drawing.Color.Transparent;
            this.lblContatosSelecionados.Name = "lblContatosSelecionados";
            this.lblContatosSelecionados.Size = new System.Drawing.Size(133, 17);
            this.lblContatosSelecionados.Text = "Contatos Selecionados: ";
            // 
            // lblCountContatos
            // 
            this.lblCountContatos.BackColor = System.Drawing.Color.Transparent;
            this.lblCountContatos.Name = "lblCountContatos";
            this.lblCountContatos.Size = new System.Drawing.Size(13, 17);
            this.lblCountContatos.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel5.Text = " | ";
            // 
            // lblGruposSelecionados
            // 
            this.lblGruposSelecionados.BackColor = System.Drawing.Color.Transparent;
            this.lblGruposSelecionados.Name = "lblGruposSelecionados";
            this.lblGruposSelecionados.Size = new System.Drawing.Size(120, 17);
            this.lblGruposSelecionados.Text = "Grupos Selecionados:";
            // 
            // lblCountGrupos
            // 
            this.lblCountGrupos.BackColor = System.Drawing.Color.Transparent;
            this.lblCountGrupos.Name = "lblCountGrupos";
            this.lblCountGrupos.Size = new System.Drawing.Size(13, 17);
            this.lblCountGrupos.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "| ";
            // 
            // lblQtdeMsgDisparos
            // 
            this.lblQtdeMsgDisparos.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdeMsgDisparos.Name = "lblQtdeMsgDisparos";
            this.lblQtdeMsgDisparos.Size = new System.Drawing.Size(112, 17);
            this.lblQtdeMsgDisparos.Text = "Qtde de Disparadas:";
            // 
            // lblMensagensDisparadas
            // 
            this.lblMensagensDisparadas.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagensDisparadas.Name = "lblMensagensDisparadas";
            this.lblMensagensDisparadas.Size = new System.Drawing.Size(13, 17);
            this.lblMensagensDisparadas.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel4.Text = " | ";
            // 
            // lblSelecionarPorta
            // 
            this.lblSelecionarPorta.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecionarPorta.Name = "lblSelecionarPorta";
            this.lblSelecionarPorta.Size = new System.Drawing.Size(95, 17);
            this.lblSelecionarPorta.Text = "Selecionar Porta:";
            // 
            // mnuPortas
            // 
            this.mnuPortas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuPortas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPortas.Name = "mnuPortas";
            this.mnuPortas.Size = new System.Drawing.Size(116, 20);
            this.mnuPortas.Text = "[Selecionar Porta]";
            this.mnuPortas.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuPortas_DropDownItemClicked);
            // 
            // chkCodigoPromocional
            // 
            this.chkCodigoPromocional.AutoSize = true;
            this.chkCodigoPromocional.Location = new System.Drawing.Point(18, 175);
            this.chkCodigoPromocional.Name = "chkCodigoPromocional";
            this.chkCodigoPromocional.Size = new System.Drawing.Size(153, 17);
            this.chkCodigoPromocional.TabIndex = 9;
            this.chkCodigoPromocional.Text = "Enviar Código Promocional";
            this.chkCodigoPromocional.UseVisualStyleBackColor = true;
            this.chkCodigoPromocional.CheckedChanged += new System.EventHandler(this.chkCodigoPromocional_CheckedChanged);
            // 
            // gbxPromocao
            // 
            this.gbxPromocao.Controls.Add(this.label4);
            this.gbxPromocao.Controls.Add(this.dtpVencimento);
            this.gbxPromocao.Location = new System.Drawing.Point(180, 341);
            this.gbxPromocao.Name = "gbxPromocao";
            this.gbxPromocao.Size = new System.Drawing.Size(162, 73);
            this.gbxPromocao.TabIndex = 15;
            this.gbxPromocao.TabStop = false;
            this.gbxPromocao.Text = "Promoção:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vencimento:";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(21, 36);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(99, 20);
            this.dtpVencimento.TabIndex = 10;
            // 
            // chkHomens
            // 
            this.chkHomens.AutoSize = true;
            this.chkHomens.Checked = true;
            this.chkHomens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHomens.Location = new System.Drawing.Point(189, 152);
            this.chkHomens.Name = "chkHomens";
            this.chkHomens.Size = new System.Drawing.Size(65, 17);
            this.chkHomens.TabIndex = 10;
            this.chkHomens.Text = "Homens";
            this.chkHomens.UseVisualStyleBackColor = true;
            // 
            // chkMulheres
            // 
            this.chkMulheres.AutoSize = true;
            this.chkMulheres.Checked = true;
            this.chkMulheres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMulheres.Location = new System.Drawing.Point(189, 175);
            this.chkMulheres.Name = "chkMulheres";
            this.chkMulheres.Size = new System.Drawing.Size(69, 17);
            this.chkMulheres.TabIndex = 11;
            this.chkMulheres.Text = "Mulheres";
            this.chkMulheres.UseVisualStyleBackColor = true;
            // 
            // btnPararEnvio
            // 
            this.btnPararEnvio.BackColor = System.Drawing.Color.White;
            this.btnPararEnvio.Image = global::smssim.Properties.Resources.cancel48;
            this.btnPararEnvio.Location = new System.Drawing.Point(264, 464);
            this.btnPararEnvio.Name = "btnPararEnvio";
            this.btnPararEnvio.Size = new System.Drawing.Size(77, 82);
            this.btnPararEnvio.TabIndex = 16;
            this.btnPararEnvio.Text = "Parar Envio de SMS";
            this.btnPararEnvio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPararEnvio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPararEnvio.UseVisualStyleBackColor = false;
            this.btnPararEnvio.Click += new System.EventHandler(this.btnPararEnvio_Click);
            // 
            // btnAdicionarPessoas
            // 
            this.btnAdicionarPessoas.BackColor = System.Drawing.Color.White;
            this.btnAdicionarPessoas.Image = global::smssim.Properties.Resources.Add_Male_User48;
            this.btnAdicionarPessoas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarPessoas.Location = new System.Drawing.Point(96, 464);
            this.btnAdicionarPessoas.Name = "btnAdicionarPessoas";
            this.btnAdicionarPessoas.Size = new System.Drawing.Size(77, 82);
            this.btnAdicionarPessoas.TabIndex = 7;
            this.btnAdicionarPessoas.Text = "Adicionar Pessoas";
            this.btnAdicionarPessoas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarPessoas.UseVisualStyleBackColor = false;
            this.btnAdicionarPessoas.Click += new System.EventHandler(this.btnAdicionarPessoas_Click);
            // 
            // btnDisparar
            // 
            this.btnDisparar.BackColor = System.Drawing.Color.White;
            this.btnDisparar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDisparar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDisparar.Image = global::smssim.Properties.Resources.send_message;
            this.btnDisparar.Location = new System.Drawing.Point(180, 464);
            this.btnDisparar.Name = "btnDisparar";
            this.btnDisparar.Size = new System.Drawing.Size(77, 82);
            this.btnDisparar.TabIndex = 9;
            this.btnDisparar.Text = "Enviar Mensagem";
            this.btnDisparar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisparar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDisparar.UseVisualStyleBackColor = false;
            this.btnDisparar.Click += new System.EventHandler(this.btnDisparar_Click);
            // 
            // btnAdicionarGrupos
            // 
            this.btnAdicionarGrupos.BackColor = System.Drawing.Color.White;
            this.btnAdicionarGrupos.Image = global::smssim.Properties.Resources.addressbook64;
            this.btnAdicionarGrupos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarGrupos.Location = new System.Drawing.Point(12, 464);
            this.btnAdicionarGrupos.Name = "btnAdicionarGrupos";
            this.btnAdicionarGrupos.Size = new System.Drawing.Size(77, 82);
            this.btnAdicionarGrupos.TabIndex = 6;
            this.btnAdicionarGrupos.Text = "Adicionar Grupos";
            this.btnAdicionarGrupos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarGrupos.UseVisualStyleBackColor = false;
            this.btnAdicionarGrupos.Click += new System.EventHandler(this.btnAdicionarGrupos_Click);
            // 
            // FrmMensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 580);
            this.Controls.Add(this.btnPararEnvio);
            this.Controls.Add(this.gbxPromocao);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblMsgProcessadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbContatoGrupos);
            this.Controls.Add(this.btnAdicionarPessoas);
            this.Controls.Add(this.btnDisparar);
            this.Controls.Add(this.btnAdicionarGrupos);
            this.Controls.Add(this.tbMensagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMensagens";
            this.Text = "Gerenciar Mensagens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMensagens_FormClosing);
            this.Controls.SetChildIndex(this.txt_Id, 0);
            this.Controls.SetChildIndex(this.gbxFormulario, 0);
            this.Controls.SetChildIndex(this.tbMensagem, 0);
            this.Controls.SetChildIndex(this.btnAdicionarGrupos, 0);
            this.Controls.SetChildIndex(this.btnDisparar, 0);
            this.Controls.SetChildIndex(this.btnAdicionarPessoas, 0);
            this.Controls.SetChildIndex(this.tbContatoGrupos, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblMsgProcessadas, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.gbxStatus, 0);
            this.Controls.SetChildIndex(this.gbxPromocao, 0);
            this.Controls.SetChildIndex(this.btnPararEnvio, 0);
            this.gbxFormulario.ResumeLayout(false);
            this.gbxFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.tbMensagem.ResumeLayout(false);
            this.tbMensagens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tbAgendamentos.ResumeLayout(false);
            this.groupAgenda.ResumeLayout(false);
            this.groupAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            this.tbContatoGrupos.ResumeLayout(false);
            this.tbGrupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.tbPessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbxPromocao.ResumeLayout(false);
            this.gbxPromocao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TabControl tbMensagem;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TabPage tbAgendamentos;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private System.Windows.Forms.Button btnAdicionarGrupos;
        private System.Windows.Forms.Button btnAdicionarPessoas;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbMensagens;
        private System.Windows.Forms.Button btnDisparar;
        private System.Windows.Forms.TabControl tbContatoGrupos;
        private System.Windows.Forms.TabPage tbGrupos;
        private System.Windows.Forms.TabPage tbPessoas;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.CheckBox chkIncluirNome;
        private System.Windows.Forms.GroupBox groupAgenda;
        private System.Windows.Forms.Button btnSalvarAgendamento;
        private System.Windows.Forms.DateTimePicker dtpAgenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkForcarSMS;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMsgProcessadas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblQtdeMsgDisparos;
        private System.Windows.Forms.ToolStripStatusLabel lblMensagensDisparadas;
        private System.Windows.Forms.CheckBox chkCodigoPromocional;
        private System.Windows.Forms.GroupBox gbxPromocao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.CheckBox chkMulheres;
        private System.Windows.Forms.CheckBox chkHomens;
        private System.Windows.Forms.ToolStripStatusLabel lblContatosSelecionados;
        private System.Windows.Forms.ToolStripStatusLabel lblCountContatos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblGruposSelecionados;
        private System.Windows.Forms.ToolStripStatusLabel lblCountGrupos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnPararEnvio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblSelecionarPorta;
        private System.Windows.Forms.ToolStripSplitButton mnuPortas;
    }
}
