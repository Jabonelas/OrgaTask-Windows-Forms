using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using WindowsForms.Classes;
using WindowsForms.DTOs.Tarefa;
using WindowsForms.Interface;

namespace WindowsForms.Forms
{
    public partial class uc_VisualizarTarefa : DevExpress.XtraEditors.XtraUserControl
    {
        private int idTarefa = 0;

        private string statusPassado = "";

        private frmHome frmHome = null;

        private readonly ITarefaService tarefaService;

        public uc_VisualizarTarefa(ITarefaService _tarefaService)
        {
            tarefaService = _tarefaService;

            InitializeComponent();
        }

        private void uc_VisualizarTarefa_Load(object sender, EventArgs e)
        {
            btnVoltar.Focus();
        }

        public async Task SetParametroAdicionalAsync(frmHome _frmHome, int _idTarefa, string _statusPassado)
        {
            frmHome = _frmHome;

            idTarefa = _idTarefa;

            statusPassado = _statusPassado;

            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                await BuscarTarefaAsync();
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async Task BuscarTarefaAsync()
        {
            (ResultadoOperacao ResultadoOperacao, TarefaAlterarDTO Tarefa) = await tarefaService.BuscarTarefaAsync(idTarefa);

            if (ResultadoOperacao.Mensagem != null)
            {
                MensagensAlertaSistema.MensagemAlertaSistema(ResultadoOperacao);
            }
            else
            {
                PreencherCampos(Tarefa);
            }
        }

        private void PreencherCampos(TarefaAlterarDTO Tarefa)
        {
            txtTitulo.Text = Tarefa.Titulo;
            txtPrioridade.Text = Tarefa.Prioridade;
            txtPrazo.Text = Tarefa.Prazo.ToString();
            txtDescricao.Text = Tarefa.Descricao;
            txtStatus.Text = Tarefa.Status;
        }

        private void ExibirTelaDashboardTarefas()
        {
            var ucExibirTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_DashboardTarefas>();

            frmHome.pnlTelaPrincipal.Controls.Clear();
            frmHome.pnlTelaPrincipal.Controls.Add(ucExibirTarefas);
        }

        private async Task ExibirTelaTarefasAsync()
        {
            var ucExibirTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_ExibirTarefas>();
            await ucExibirTarefas.SetParametroAdicionalAsync(frmHome, statusPassado);

            frmHome.pnlTelaPrincipal.Controls.Clear();
            frmHome.pnlTelaPrincipal.Controls.Add(ucExibirTarefas);
        }

        private async void btnVoltar_Click_1(object sender, EventArgs e)
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                if (statusPassado == "Apenas Tarefas com Prioridade Alta")
                {
                    ExibirTelaDashboardTarefas();
                }
                else
                {
                    await ExibirTelaTarefasAsync();
                }
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }
    }
}