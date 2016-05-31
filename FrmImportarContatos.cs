using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;
using Entities.Models;
using Manager;

namespace smssim
{
    public partial class FrmImportarContatos : Form
    {
        public FrmImportarContatos()
        {
            InitializeComponent();

            btnSalvarContatos.Enabled = false;
            btnCancelar.Enabled = false;

            string text = "Para realizar a importação de dados, a estrutura do documento deve ser configurada da seguinte forma:\n";
            text += "1) Colunas: Nome, Sexo, Telefone, Grupo, Data de Nascimento;\n";
            text += "2) O campo sexo deve conter valores M ou F para sexo masculino e feminino respectivamente;\n";
            text += "3) A tabela com as informações deve estar nomeada como Plan1;\n";
            text += "4) O documento ser salvo como arquivo a extenção Pasta de Trabalho do Excell 97/2003 (.xls);\n \n";
            text += "Obs.: Caso as recomendações acima não forem seguidas o procedimento se tornará instável e passível de erros.\n";
            
            string title = "Informação importante: Layout para importação";

            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFile = new OpenFileDialog();
            selectFile.Filter = "Excel Files(.xls)|*.xls";
            selectFile.Title = "Selecione o Arquivo";
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + selectFile.FileName +";Extended Properties=Excel 8.0;");
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Plan1$]", conexao);
                da.Fill(ds);

                dgvDadosImportados.DataSource = ds.Tables[0];
                dgvDadosImportados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;

                conexao.Close();

                lblQuantidade.Text = dgvDadosImportados.RowCount.ToString() + " aguardando processamento";

                HabilitarImportacao();
            }
        }

        private void btnSalvarContatos_Click(object sender, EventArgs e)
        {
            btnSelecionarArquivo.Enabled = false;

            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;
            backgroundWorker1.RunWorkerAsync();
        }

        public void HabilitarImportacao()
        {
            int count = dgvDadosImportados.RowCount;
            if (count > 0)
            {
                btnSelecionarArquivo.Enabled = false;
                btnFechar.Enabled = false;
                btnSalvarContatos.Enabled = true;
                btnCancelar.Enabled = true;
                
                return;
            }
            btnSelecionarArquivo.Enabled = true;
            btnFechar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvarContatos.Enabled = false;
        }

        private void ExecutandoTarefa(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(i);
                lblQuantidade.BeginInvoke(
                    new Action(() =>
                    {
                        lblQuantidade.Text = p.ToString() + "% registros processados";
                    }
                ));
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = dgvDadosImportados.RowCount;
            int i = 0;

            int countColuns = dgvDadosImportados.ColumnCount;
            if (countColuns != 5)
            {
                MessageBox.Show(
                    "A quantidade de colunas não corresponde ao necessário para importação: \"Nome\", \"Sexo\",\"Telefone\",\"Grupo\",\"Data de Nascimento\"",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow item in dgvDadosImportados.Rows)
            {
                string nome = item.Cells[0].Value.ToString();
                int sexo = ReturnSexo(item.Cells[1].Value.ToString());
                string telefone = item.Cells[2].Value.ToString();
                string nomeGrupo = item.Cells[3].Value.ToString();
                string dataNascimento = item.Cells[4].Value.ToString();

                Contatos contato = ContatosManager.ProcessarContatos(nome, sexo, telefone, dataNascimento);
                Grupos grupo = GruposManager.ProcessarGrupos(nomeGrupo);

                GruposContatosManager.ProcessarGruposContatos(contato.Id, grupo.Id);
                
                int p = (i * 100) / count;

                ExecutandoTarefa(p);

                backgroundWorker1.ReportProgress(p);

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
                i++;
            }
            backgroundWorker1.ReportProgress(100);
        }

        public int ReturnSexo(string sexo)
        {
            switch (sexo.ToUpper())
            {
                case "M":
                    return 1;
                case "F":
                    return 2;
                default:
                    return 1;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            lblQuantidade.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblQuantidade.Text = "Aconteceu um erro com o processo";
                return;
            }

            lblQuantidade.Text = dgvDadosImportados.RowCount.ToString() + " processados";

            MessageBox.Show("Operação Concluída", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvDadosImportados.DataSource = "";

            HabilitarImportacao();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }

            btnCancelar.Enabled = false;
            lblQuantidade.Text = "Processamento cancelado";

            dgvDadosImportados.DataSource = "";

            HabilitarImportacao();
        }
    }
}
