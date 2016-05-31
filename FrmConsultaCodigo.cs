using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entities.Models;
using Entities.Services;
using Libs;

namespace smssim
{
    public partial class FrmConsultaCodigo : Form
    {
        public FrmConsultaCodigo()
        {
            InitializeComponent();

            LimparText(this);

            btnSalvar.Enabled = false;
            rbUsado.Checked = false;
            rbAberto.Checked = false;

            ControlesDefault();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("É necessário inserir o código para pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CodigosPromocionaisService cpService = new CodigosPromocionaisService();
            ICollection<CodigosPromocionais> cpList = cpService.List().Where(i => i.Codigo.Equals(txtCodigo.Text)).ToList();

            int count = cpList.Count;
            if (count == 0)
            {
                MessageBox.Show("Nenhuma mensagem foi encontrada com esse código", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvDados.DataSource = cpList;

            dgvDados.Columns["Id"].Visible = true;
            dgvDados.Columns["Id"].HeaderText = "Código";
            dgvDados.Columns["Id"].DisplayIndex = 0;

            dgvDados.Columns["Promocao"].Visible = true;
            dgvDados.Columns["Promocao"].HeaderText = "Validade da Promoção";
            dgvDados.Columns["Promocao"].DisplayIndex = 2;

            dgvDados.Columns["Contato"].Visible = true;
            dgvDados.Columns["Contato"].HeaderText = "Nome do Contato";
            dgvDados.Columns["Contato"].DisplayIndex = 1;
            
            dgvDados.Columns["Codigo"].Visible = true;
            dgvDados.Columns["Codigo"].HeaderText = "Código Promocional";
            dgvDados.Columns["Codigo"].DisplayIndex = 3;

            dgvDados.Columns["ContatoId"].Visible = false;
            dgvDados.Columns["PromocaoId"].Visible = false;
            dgvDados.Columns["Created"].Visible = false;
            dgvDados.Columns["Updated"].Visible = false;
            dgvDados.Columns["status"].Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            CodigosPromocionaisService service = new CodigosPromocionaisService();
            CodigosPromocionais entity = service.Find(id);

            entity.Updated = DateTime.Now;
            entity.Status = 2;

            service.Edit(entity);

            MessageBox.Show("Cupom atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AppSystem.LimparText(this);
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int) dgvDados.Rows[e.RowIndex].Cells[0].Value;

            CodigosPromocionaisService service = new CodigosPromocionaisService();
            CodigosPromocionais entity = service.Find(id);

            txtId.Text = entity.Id.ToString();
            txtCodigoPromocional.Text = entity.Codigo;
            txtContato.Text = entity.Contato.Nome;
            txtVencimento.Text = entity.Promocao.Vencimento.ToShortDateString();

            groupBox1.Enabled = true;

            if (entity.Status == 1)
            {
                rbAberto.Checked = true;
                rbUsado.Checked = false;

                btnSalvar.Enabled = true;
                return;
            }
            
            rbAberto.Checked = false;
            rbUsado.Checked = true;

            btnSalvar.Enabled = false;
        
        }

        public void LimparText(Control con)
        {
            AppSystem.LimparText(this);

            ControlesDefault();
        }

        private void ControlesDefault()
        {
            btnSalvar.Enabled = false;
            rbUsado.Checked = false;
            rbAberto.Checked = false;
        }
    }
}
