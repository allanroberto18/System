using System;
using System.Windows.Forms;
using Libs;

namespace smssim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GSMMannager gsm = new GSMMannager();
            try
            {
                label2.Text = gsm.TestConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção: " + ex.Message);
            }

            dataGridView1.DataSource = gsm.GetMessages();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string phone = textBox2.Text;

            try
            {
                GSMMannager gsm = new GSMMannager();
                gsm.EnviarMensagem(texto, phone);

                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;

                MessageBox.Show("Mensagem enviada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção: " + ex.Message);
            }
        }
    }
}
