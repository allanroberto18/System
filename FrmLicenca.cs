using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;
using Libs;
using Manager;

namespace smssim
{
    public partial class FrmLicenca : Form
    {
        public FrmLicenca()
        {
            InitializeComponent();

            string licenca = LicencasManager.GetLicenca();
            if (!String.IsNullOrEmpty(licenca))
            {
                txtSerial.Text = licenca;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validacao.ValidarMaskCampos(txtSerial, errorProvider1, "A Licença obrigatória");
            if (errorProvider1.GetError(txtSerial).Length == 0)
            {
                LicencasManager.Novo(txtSerial.Text);
            }
            
            MessageBox.Show("Licença Atualizada com sucesso", "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
           
            this.Close();
        }

        private void btnValidarLicenca_Click(object sender, EventArgs e)
        {

        }
    }
}
