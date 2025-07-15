using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using WindowsForms.Classes;
using WindowsForms.DTOs.Tarefa;
using WindowsForms.Interface;
using WindowsForms.Properties;

namespace WindowsForms.Forms
{
    public partial class uc_ExibirTarefas : DevExpress.XtraEditors.XtraUserControl
    {
        private int qtdTotalTarefas = 0;
        private int numeroPagina = 1;
        private int qtdItensPagina = 6;

        private string statusTarefa = "";

        private frmHome frmHome = null;

        private readonly ITarefaService tarefaService;

        public uc_ExibirTarefas(ITarefaService _tarefaService)
        {
            tarefaService = _tarefaService;

            InitializeComponent();
        }

        private void uc_ExibirTarefas_Load(object sender, EventArgs e)
        {
            btnProximo.Focus();

            DesabilitarPassagemPagina();
        }

        private void DesabilitarPassagemPagina()
        {
            if (qtdTotalTarefas <= 6)
            {
                btnAnteriro.Enabled = false;
                btnProximo.Enabled = false;
            }
        }

        public async Task SetParametroAdicionalAsync(frmHome _frmHome, string _statusTarefa)
        {
            frmHome = _frmHome;

            statusTarefa = _statusTarefa;

            SetandoTitulo();

            await SetandoListaTarefasAsync();
        }

        private void SetandoTitulo()
        {
            switch (statusTarefa)
            {
                case "todas":
                    lblTitulo.Text = "Todas as Minhas Tarefas";
                    break;

                case "Pendente":
                    lblTitulo.Text = "Todas as Minhas Tarefas Pendentes";
                    break;

                case "Em Progresso":
                    lblTitulo.Text = "Todas as Minhas Tarefas Em Progresso";
                    break;

                case "Concluído":
                    lblTitulo.Text = "Todas as Minhas Tarefas Concluídas";
                    break;
            }
        }

        private async Task SetandoListaTarefasAsync()
        {
            (ResultadoOperacao ResultadoOperacao, List<TarefaConsultaDTO> ListaTarefa, int TotalCount) = await tarefaService.ObterTarefasPaginadasAsync(numeroPagina, qtdItensPagina, statusTarefa);

            if (ResultadoOperacao.Sucesso == false)
            {
                MensagensAlertaSistema.MensagemAlertaSistema(ResultadoOperacao);

                return;
            }

            qtdTotalTarefas = TotalCount;

            SetandoItensExibicaoTela(ListaTarefa);
        }

        private void SetandoItensExibicaoTela(List<TarefaConsultaDTO> _listaTarefa)
        {
            if (qtdTotalTarefas != 0)
            {
                lblNenhumaTarefa.Visible = false;
                btnCriarTarefa.Visible = false;

                PreenhcerCardsTarefas(_listaTarefa);
            }
            else
            {
                pnlListaTarefas.Controls.Clear();

                lblNenhumaTarefa.Visible = true;
                btnCriarTarefa.Visible = true;
            }
        }

        private void PreenhcerCardsTarefas(List<TarefaConsultaDTO> _listaTarefas)
        {
            pnlListaTarefas.Controls.Clear();

            string prazo = "";

            foreach (var tarefa in _listaTarefas)
            {
                var card = ActivatorUtilities.CreateInstance<uc_CardTarefa>(InjecaoDependencia.ServiceProvider);

                prazo = tarefa.Prazo < 0 ? $"       Prazo:\n       {tarefa.Prazo.ToString().Replace("-", "")} dia(s) em atraso." : prazo = $"       Prazo:\n       {tarefa.Prazo} dia(s) restante(s).";

                card.SetParametroAdicional(frmHome, statusTarefa);

                card.id = tarefa.Id.ToString();
                card.titulo = tarefa.Titulo;
                card.descricao = tarefa.Descricao;
                card.corlblPrioridade = SetarCorPrioridade(tarefa.Prioridade);
                card.imagemlblPrioridade = SetarIconePrioridade(tarefa.Prioridade);
                card.prioridade = $"Prioridade: {tarefa.Prioridade}";
                card.corlblStatus = SetarCorStatus(tarefa.Status);
                card.imagemlblStatus = SetarIconeStatus(tarefa.Status);
                card.status = $"Status: {tarefa.Status}";
                card.data = $"       Criado:\n       {tarefa.DataCriacao}";
                card.prazo = prazo;

                pnlListaTarefas.Controls.Add(card);
            }
        }

        private Color SetarCorPrioridade(string _prioridade)
        {
            switch (_prioridade)
            {
                case "Baixa":
                    return Color.FromArgb(67, 160, 71);

                case "Média":
                    return Color.FromArgb(251, 140, 0);

                case "Alta":
                    return Color.FromArgb(229, 57, 53);
            }

            return Color.Gray;
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



        private Image SetarIconePrioridade(string _prioridade)
        {
            switch (_prioridade)
            {
                case "Baixa":
                    return Resources.prioridade_baixa;

                case "Média":
                    return Resources.prioridade_media;

                case "Alta":
                    return Resources.prioridade_alta;
            }

            return null;
        }


        private Image SetarIconeStatus(string _status)
        {
            switch (_status)
            {
                case "Concluído":
                    return Resources.status_concluido;

                case "Em Progresso":
                    return Resources.status_em_progresso;

                case "Pendente":
                    return Resources.status_pendente;
            }

            return null;
        }


        private async void btnAnteriro_Click(object sender, EventArgs e)
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                await PaginaAnteriorAsync();
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async Task PaginaAnteriorAsync()
        {
            if (numeroPagina != 1)
            {
                pnlListaTarefas.Controls.Clear();

                --numeroPagina;

                await SetandoListaTarefasAsync();

                lblNumeroPagina.Text = numeroPagina.ToString();
            }
        }

        private async void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                await ProximaPaginaAsync();
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }

            TelaCarregamento.EsconderCarregamento();
        }

        private async Task ProximaPaginaAsync()
        {
            decimal qdtItensPagina = 9m;

            decimal qtdPaginas = qtdTotalTarefas / qdtItensPagina;

            if (qtdPaginas >= numeroPagina)
            {
                pnlListaTarefas.Controls.Clear();

                ++numeroPagina;

                await SetandoListaTarefasAsync();

                lblNumeroPagina.Text = numeroPagina.ToString();
            }
        }

        private void bntCriarTarefa_Click(object sender, EventArgs e)
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                ExibirTelaCadastraNovaTarefa();
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private void ExibirTelaCadastraNovaTarefa()
        {
            try
            {
                var ucCadastrarTarefa = InjecaoDependencia.ServiceProvider.GetService<uc_CadastrarTarefa>();
                ucCadastrarTarefa.SetParametroAdicional(frmHome);

                frmHome.pnlTelaPrincipal.Controls.Clear();
                frmHome.pnlTelaPrincipal.Controls.Add(ucCadastrarTarefa);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private void btnNovaTarefa_Click(object sender, EventArgs e)
        {
            TelaCarregamento.ExibirCarregamentoForm(frmHome);

            ExibirTelaCadastraNovaTarefa();
        }
    }
}