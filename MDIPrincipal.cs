using System;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;
using Libs;
using Manager;

namespace smssim
{
    public partial class MDIPrincipal : Form
    {
        public string Usuario { get; set; }

        public MDIPrincipal()
        {
            InitializeComponent();

            Login();

            timerCron = new Timer();
            timerCron.Tick += new EventHandler(timerCron_Tick);
            timerCron.Interval = 60 * 60 * 1000;
            // timerCron.Interval = 10000;

            timerCron.Start();
        }

        public void Login()
        {
            PortaCOM.GetPorta();
            string porta = AppConfig.GetValue("porta") == "N" ? "Não foi possível conectar a Porta COM para disparos SMS" : AppConfig.GetValue("porta");

            GSMMannager gsm = new GSMMannager();
            string sim = gsm.SerialNumber();

            Sims entity = new Sims();
            entity.SetParams(sim, 1);

            SimsService service = new SimsService();
            service.Add(entity);

            MessageBox.Show(sim);

            if (lblUsuario.Text.Length == 0)
            {
                FrmLogin frm = new FrmLogin();
                frm.ShowDialog();

                if (frm.Usuario != null)
                {
                    AppConfig.UpdateSetting("user", frm.Id.ToString());

                    lblCodigo.Text = "Código: " + frm.Id.ToString();
                    lblUsuario.Text = "Usuário: " + frm.Usuario.ToString();
                    lblPorta.Text = "Porta: " + porta;

                    lblLicenca.Text = LicencasManager.GetLicenca();

                    if (frm.Id != 1)
                    {
                        int configDate = ConfiguracoesManager.CheckLicenca();

                        if (configDate < 0)
                        {
                            MessageBox.Show("A sua licença expirou", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BloquearAplicacao();
                        }
                        else
                        {
                            if (configDate <= 5)
                            {
                                MessageBox.Show("A sua licença irá expirar em " + configDate.ToString() + " dias", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    
                    frm.Close();
                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            Form frm = new FrmMensagens();
            frm.Show();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            Form frm = new FrmGrupos();
            frm.Show();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            Form frm = new FrmContatos();
            frm.Show();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            Form frm = new FrmConfiguracoes();
            frm.Show();
        }

        private void btnSeguraca_Click(object sender, EventArgs e)
        {
            Form frm = new FrmUsuarios();
            frm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "";
            this.Login();
        }

        private void InitTimer()
        {
            timerCron = new Timer();
            timerCron.Tick += new EventHandler(timerCron_Tick);
            timerCron.Interval = 60000;
            timerCron.Start();
        }

        private void timerCron_Tick(object sender, EventArgs e)
        {
            if (AppConfig.GetValue("porta") == "N")
            {
                return;    
            }

            MensagensManager.DispararMensagem();
        }

        private void btnImportarContatos_Click(object sender, EventArgs e)
        {
            FrmImportarContatos frm = new FrmImportarContatos();
            frm.Show();
        }

        private void btnLicenca_Click(object sender, EventArgs e)
        {
            FrmLicenca frm = new FrmLicenca();
            frm.Show();
        }

        private void btnCodigoPromocional_Click(object sender, EventArgs e)
        {
            FrmConsultaCodigo frm = new FrmConsultaCodigo();
            frm.Show();
        }

        public void BloquearAplicacao()
        {
            btnLogin.Enabled = true;
            btnMensagens.Enabled = false;
            btnGrupos.Enabled = false;
            btnContatos.Enabled = false;
            btnConfiguracao.Enabled = false;
            btnSeguraca.Enabled = false;
            btnCodigoPromocional.Enabled = false;
            btnImportarContatos.Enabled = false;
            btnLicenca.Enabled = false;
            btnSair.Enabled = true;
        }

        public void LiberarAplicacao()
        {
            btnLogin.Enabled = true;
            btnMensagens.Enabled = true;
            btnGrupos.Enabled = true;
            btnContatos.Enabled = true;
            btnConfiguracao.Enabled = true;
            btnSeguraca.Enabled = true;
            btnCodigoPromocional.Enabled = true;
            btnImportarContatos.Enabled = true;
            btnLicenca.Enabled = true;
            btnSair.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            GSMMannager gsm = new GSMMannager();
            string result = gsm.SerialNumber();

            MessageBox.Show(result);
        }
    }
}
