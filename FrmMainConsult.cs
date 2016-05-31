using System;
using System.Windows.Forms;

namespace smssim
{
    public partial class FrmMainConsult : Form
    {
        public FrmMainConsult()
        {
            InitializeComponent();
            this.LoadGrid(null, null);
            this.FillCboFilter();
        }

        public int? Id { get; set; }

        public int?[] Lista { get; set; }

        public virtual dynamic ItensCboFilter()
        {
            return new[]
            {
                new { Text = "Código" , Value = 1},
                new { Text = "Nome" , Value = 2}
            };
        }

        public virtual void FillCboFilter()
        {
            cboFilter.DisplayMember = "Text";
            cboFilter.ValueMember = "Value";

            cboFilter.DataSource = this.ItensCboFilter();
        }

        public virtual void LoadGrid(string param, string field)
        {
            
        }

        public void GetData()
        {
            int count = dgvDados.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (count == 1)
            {
                this.Id = (int) dgvDados.Rows[dgvDados.CurrentCell.RowIndex].Cells[0].Value;
            }
            
            this.Lista = new int?[count];
            for (int i = 0; i < count; i++)
            {
                this.Lista[i] = Convert.ToInt32(dgvDados.SelectedRows[i].Cells[0].Value);
            }
            
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string param = txtParametro.Text;
            string field = cboFilter.Text;
            this.LoadGrid(param, field);
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetData();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.GetData();
        }
    }
}
