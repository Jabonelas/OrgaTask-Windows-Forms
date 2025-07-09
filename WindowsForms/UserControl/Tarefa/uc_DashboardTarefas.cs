using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
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

            MantendoAparenciaBtnQtdTarefasPrioritarias();
        }

        public async Task SetParametroAdicionalAsync(frmHome _frmHome)
        {
            frmHome = _frmHome;

            await BuscarQtdStatusTarefasAsync();

            await SetandoListaTarefasAsync();
        }

        private void MantendoAparenciaBtnQtdTarefasPrioritarias()
        {
            btnQtdTarefasPrioritarias.AppearanceDisabled.BackColor = btnQtdTarefasPrioritarias.Appearance.BackColor;
            btnQtdTarefasPrioritarias.AppearanceDisabled.ForeColor = btnQtdTarefasPrioritarias.Appearance.ForeColor;
            btnQtdTarefasPrioritarias.AppearanceDisabled.BorderColor = btnQtdTarefasPrioritarias.Appearance.BorderColor;
            btnQtdTarefasPrioritarias.Enabled = false;

            btnQtdTarefasPendentes.LookAndFeel.UseDefaultLookAndFeel = false;
            btnQtdTarefasPendentes.AppearanceHovered.BackColor = btnQtdTarefasPendentes.Appearance.BackColor;
            btnQtdTarefasPendentes.AppearanceHovered.ForeColor = btnQtdTarefasPendentes.Appearance.ForeColor;

            btnQtdTarefasEmProgresso.LookAndFeel.UseDefaultLookAndFeel = false;
            btnQtdTarefasEmProgresso.AppearanceHovered.BackColor = btnQtdTarefasEmProgresso.Appearance.BackColor;
            btnQtdTarefasEmProgresso.AppearanceHovered.ForeColor = btnQtdTarefasEmProgresso.Appearance.ForeColor;

            btnQtdTarefasConcluida.LookAndFeel.UseDefaultLookAndFeel = false;
            btnQtdTarefasConcluida.AppearanceHovered.BackColor = btnQtdTarefasConcluida.Appearance.BackColor;
            btnQtdTarefasConcluida.AppearanceHovered.ForeColor = btnQtdTarefasConcluida.Appearance.ForeColor;

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

            MensagensAlertaSistema.MensagemAlertaSistema(ResultadoOperacao);
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

            if (ResultadoOperacao.Sucesso && ListaTarefaPrioridade != null)
            {
                pnlListaTarefaaPrioritarias.Controls.Clear();

                btnQtdTarefasPrioritarias.Text = $"{ListaTarefaPrioridade.Count} Itens";

                string prazo = "";

                foreach (var tarefa in ListaTarefaPrioridade)
                {
                    prazo = tarefa.Prazo < 0 ? $"       Prazo: {tarefa.Prazo.ToString().Replace("-", "")} dia(s) em atraso." : prazo = $"       Prazo: {tarefa.Prazo} dia(s) restante(s).";

                    var card = new uc_CardTarefaPrioridade(frmHome)
                    {
                        id = tarefa.Id.ToString(),
                        titulo = tarefa.Titulo,
                        dataCriacao = $"       Criado: {tarefa.Data}",
                        prazo = prazo,
                        status = tarefa.Status,
                        corlblStatus = SetarCorStatus(tarefa.Status)
                    };

                    pnlListaTarefaaPrioritarias.Controls.Add(card);
                }

                return;
            }

            MensagensAlertaSistema.MensagemAlertaSistema(ResultadoOperacao);
        }


        private Color SetarCorStatus(string _status)
        {
            switch (_status)
            {
                case "Concluído":
                    return Color.FromArgb(102, 187, 106);

                case "Em Progresso":
                    return Color.FromArgb(251, 192, 45);

                case "Pendente":
                    return Color.FromArgb(211, 47, 47);
            }

            return Color.Gray;
        }
    }
}