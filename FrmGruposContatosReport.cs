using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities;
using Entities.Models;
using Entities.Services;

namespace smssim
{
    public partial class FrmGruposContatosReport : smssim.FrmMainReports
    {
        public int Id { get; set; }

        public FrmGruposContatosReport()
        {
            InitializeComponent();
        }

        public override void GetDataSource()
        {
            GruposContatosService service = new GruposContatosService();
            //bindingSourceRelatorio.DataSource = service.Consult(Convert.ToString(Id), "Mensagem");
            List<GruposContatosReport> relatorio;
            using (EntityContext context = new EntityContext())
            {
                relatorio = (from i in context.GruposContatos
                             where i.GrupoId == Id
                             select new GruposContatosReport()
                             {
                                 Id = i.Id,
                                 Contato = i.Contato.Nome,
                                 Sexo = i.Contato.Sexo.ToString(),
                                 Telefone = i.Contato.Telefone,
                                 Grupo = i.Grupo.Nome,
                                 DataNascimento = i.Contato.DataNascimento.Value,
                             }).ToList();
            }

            bindingSourceRelatorio.DataSource = relatorio;

            base.GetDataSource();
        }

        private void FrmGruposContatosReport_Load(object sender, EventArgs e)
        {

        }
    }
}
