using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using WindowsForms.DTOs.Tarefa;
using WindowsForms.Interface;

namespace WindowsForms.Forms
{
    public partial class uc_DashboardTarefas : DevExpress.XtraEditors.XtraUserControl
    {
        private frmHome frmHome = null;

        private readonly ITarefaService tarefaService;

        public uc_DashboardTarefas(ITarefaService _tarefaService)
        {
            tarefaService = _tarefaService;

            InitializeComponent();
        }

        public async Task SetParametroAdicionalAsync(frmHome _frmHome)
        {
            frmHome = _frmHome;

            await BuscarQtdStatusTarefasAsync();

            await SetandoListaTarefasAsync();
        }

        private async Task BuscarQtdStatusTarefasAsync()
        {
            (ResultadoOperacao ResultadoOperacao, TarefaQtdStatusDTO TarefaQtdStatus) = await tarefaService.BuscarQtdStatusTarefaAsync();

            if (ResultadoOperacao.Sucesso)
            {
                PreencherCamposStatusTarefasQtd(TarefaQtdStatus);

                PreencherBarraTarefasConcluidas(TarefaQtdStatus);

                return;
            }

            MensagensDoSistema.MensagemAlertaSistema(ResultadoOperacao);
        }

        private void PreencherBarraTarefasConcluidas(TarefaQtdStatusDTO _TarefaQtdStatus)
        {
            lblPorcentagem.Text = $"{_TarefaQtdStatus.PorcentagemConcluidas}%";
            lblFraseCompletando.Text = $"       Você completou {_TarefaQtdStatus.PorcentagemConcluidas}% das tarefas cadastradas";

            pgbProgresso.Properties.Minimum = 0;
            pgbProgresso.Properties.Maximum = 100;
            pgbProgresso.EditValue = _TarefaQtdStatus.PorcentagemConcluidas;
            pgbProgresso.Refresh();
        }

        private void PreencherCamposStatusTarefasQtd(TarefaQtdStatusDTO _TarefaQtdStatus)
        {
            btnQtdTarefasConcluida.Text = $"\n{_TarefaQtdStatus.Concluido.ToString()}";
            btnQtdTarefasEmProgresso.Text = $"\n{_TarefaQtdStatus.EmProgresso.ToString()}";
            btnQtdTarefasPendentes.Text = $"\n{_TarefaQtdStatus.Pendente.ToString()}";
        }

        private async void btnQtdTarefasPendentes_Click(object sender, EventArgs e)
        {
            await ExibirTelaExibirTarefasAsync("Pendente");
        }

        private async void lblPendente_Click(object sender, EventArgs e)
        {
            await ExibirTelaExibirTarefasAsync("Pendente");
        }

        private async void btnQtdTarefasEmProgresso_Click(object sender, EventArgs e)
        {
            await ExibirTelaExibirTarefasAsync("Em Progresso");
        }

        private async void lblEmProgresso_Click(object sender, EventArgs e)
        {
            await ExibirTelaExibirTarefasAsync("Em Progresso");
        }

        private async void btnQtdTarefasConcluida_Click(object sender, EventArgs e)
        {
            await ExibirTelaExibirTarefasAsync("Concluído");
        }

        private async void lblConcluidas_Click(object sender, EventArgs e)
        {
            await ExibirTelaExibirTarefasAsync("Concluído");
        }

        private async Task ExibirTelaExibirTarefasAsync(string _status)
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                var ucExibirTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_ExibirTarefas>();
                await ucExibirTarefas.SetParametroAdicionalAsync(frmHome, _status);

                frmHome.pnlTelaPrincipal.Controls.Clear();
                frmHome.pnlTelaPrincipal.Controls.Add(ucExibirTarefas);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async Task SetandoListaTarefasAsync()
        {
            (ResultadoOperacao ResultadoOperacao, List<TarefaPrioridadeAltaDTO> ListaTarefaPrioridade) = await tarefaService.BuscarTarefasPrioridadeAltaAsync();

            if (ResultadoOperacao.Sucesso)
            {
                pnlListaTarefaaPrioritarias.Controls.Clear();

                string prazo = "";

                foreach (var item in ListaTarefaPrioridade)
                {
                    if (item.Prazo > 0)
                    {
                        prazo = $"       {item.Prazo} dia(s) restante(s)";
                    }
                    else
                    {
                        prazo = $"       {item.Prazo.ToString().Replace("-", "")} dia(s) de atraso";
                    }

                    var card = new uc_CardTarefaPrioridade(frmHome)
                    {
                        id = item.Id.ToString(),
                        titulo = item.Titulo,
                        dataCriacao = $"       Criado:{item.Data}",
                        prazo = prazo,
                    };

                    pnlListaTarefaaPrioritarias.Controls.Add(card);
                }

                return;
            }

            MensagensDoSistema.MensagemAlertaSistema(ResultadoOperacao);
        }
    }
}