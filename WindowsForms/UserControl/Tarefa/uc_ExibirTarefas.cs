using DevExpress.Utils;
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

        private string tarefas = "";

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
        }

        public async Task SetParametroAdicionalAsync(frmHome _frmHome, string _tarefas)
        {
            frmHome = _frmHome;

            tarefas = _tarefas;

            SetandoTitulo();

            await SetandoListaTarefasAsync();
        }

        private void SetandoTitulo()
        {
            switch (tarefas)
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
            (ResultadoOperacao ResultadoOperacao, List<TarefaConsultaDTO> ListaTarefa, int TotalCount) = await tarefaService.ObterTarefasPaginadasAsync(numeroPagina, qtdItensPagina, tarefas);

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

            foreach (var item in _listaTarefas)
            {
                var card = ActivatorUtilities.CreateInstance<uc_CardTarefa>(InjecaoDependencia.ServiceProvider);

                card.SetParametroAdicional(frmHome, tarefas);

                card.id = item.Id.ToString();
                card.titulo = item.Titulo;
                card.descricao = item.Descricao;
                card.corlblPrioridade = SetarCorPrioridade(item.Prioridade);
                card.imagemlblPrioridade = SetarImagemPrioridade(item.Prioridade);
                card.prioridade = item.Prioridade;
                card.corlblStatus = SetarCorStatus(item.Status);
                card.imagemlblStatus = SetarImagemStatus(item.Status);
                card.status = item.Status;
                card.data = $"       Criado:{(item.Data)}";
                card.prazo = $"       Prazo estipulado: {item.Prazo} dia(s)";

                pnlListaTarefas.Controls.Add(card);
            }
        }

        private Color SetarCorPrioridade(string _prioridade)
        {
            switch (_prioridade)
            {
                case "Baixa":
                    return Color.FromArgb(40, 167, 69);

                case "Média":
                    return Color.FromArgb(253, 126, 20);

                case "Alta":
                    return Color.FromArgb(209, 36, 52);
            }

            return Color.Gray;
        }


        private Color SetarCorStatus(string _status)
        {
            switch (_status)
            {
                case "Concluído":
                    return Color.FromArgb(40, 167, 69);

                case "Em Progresso":
                    return Color.FromArgb(9, 140, 204);

                case "Pendente":
                    return Color.FromArgb(108, 117, 125);
            }

            return Color.Gray;
        }


        private Image SetarImagemPrioridade(string _prioridade)
        {
            switch (_prioridade)
            {
                case "Baixa":
                    return Resources.seta_para_baixo;

                case "Média":
                    return Resources.reclamar;

                case "Alta":
                    return Resources.aviso__1_;
            }

            return null;
        }


        private Image SetarImagemStatus(string _status)
        {
            switch (_status)
            {
                case "Concluído":
                    return Resources.verificado;

                case "Em Progresso":
                    return Resources.ponto_de_interrogacao;

                case "Pendente":
                    return Resources.relogio;
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