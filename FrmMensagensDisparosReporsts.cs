using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Entities;
using Entities.Models;
using Entities.Services;

namespace smssim
{
    public partial class FrmMensagensDisparosReporsts : smssim.FrmMainReports
    {
        public int Id { get; set; }

        public FrmMensagensDisparosReporsts()
        {
            InitializeComponent();
        }

        public override void GetDataSource()
        {
            MensagensDisparosService service = new MensagensDisparosService();
            //bindingSourceRelatorio.DataSource = service.Consult(Convert.ToString(Id), "Mensagem");
            List<MensagensDisparosReport> relatorio;
            using (EntityContext context = new EntityContext())
            {
                relatorio = (from i in context.MensagensDisparos
                    where i.MensagemId == Id
                    select new MensagensDisparosReport()
                    {
                        Id = i.Id,
                        Contato = i.Contato.Nome,
                        Mensagem = i.Mensagem.Mensagem,
                        Envio = i.Envio
                    }).ToList();
            }

            bindingSourceRelatorio.DataSource = relatorio;

            base.GetDataSource();
        }
    }
}
