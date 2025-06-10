using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using WindowsForms.Interface;

namespace WindowsForms.Forms
{
    public partial class uc_CardTarefa : DevExpress.XtraEditors.XtraUserControl
    {
        public string id { get => lblIdTarefa.Text; set => lblIdTarefa.Text = value; }
        public string titulo { get => lblTitulo.Text; set => lblTitulo.Text = value; }
        public string descricao { get => lblDescricao.Text; set => lblDescricao.Text = value; }
        public string prioridade { get => lblPrioridade.Text; set => lblPrioridade.Text = value; }
        public string status { get => lblStatus.Text; set => lblStatus.Text = value; }
        public string data { get => lblDataCriacao.Text; set => lblDataCriacao.Text = value; }
        public string prazo { get => lblPrazo.Text; set => lblPrazo.Text = value; }

        public string statusPassado = "";

        public Color corlblPrioridade { get => lblPrioridade.Appearance.BackColor; set => lblPrioridade.Appearance.BackColor = value; }
        public Color corlblStatus { get => lblStatus.Appearance.BackColor; set => lblStatus.Appearance.BackColor = value; }
        public Color corpnlFundo { get => pnlFundo.BackColor; set => pnlFundo.BackColor = value; }

        private frmHome frmHome = null;

        private readonly ITarefaService tarefaService;

        public uc_CardTarefa(ITarefaService _tarefaService)
        {
            tarefaService = _tarefaService;

            InitializeComponent();
        }

        public void SetParametroAdicional(frmHome _frmHome, string _statusPassado)
        {
            frmHome = _frmHome;

            statusPassado = _statusPassado;
        }

        private async void btnVisualizarTarefa_Click(object sender, EventArgs e)
        {
            //TelaCarregamento.ExibirCarregamentoForm(frmHome);

            await ExibirTelaDetalhesTarefaAsync();
        }

        private async Task ExibirTelaDetalhesTarefaAsync()
        {
            try
            {
                var ucVisualizarTarefa = InjecaoDependencia.ServiceProvider.GetService<uc_VisualizarTarefa>();

                await ucVisualizarTarefa.SetParametroAdicionalAsync(frmHome, Convert.ToInt32(id), statusPassado);

                frmHome.pnlTelaPrincipal.Controls.Clear();
                frmHome.pnlTelaPrincipal.Controls.Add(ucVisualizarTarefa);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async void btnEditarTarefa_Click(object sender, EventArgs e)
        {
            //TelaCarregamento.ExibirCarregamentoForm(frmHome);

            await ExibirTelaEditarTarefaAsync();
        }

        private async Task ExibirTelaEditarTarefaAsync()
        {
            try
            {
                var ucEditarTarefa = InjecaoDependencia.ServiceProvider.GetService<uc_EditarTarefa>();
                await ucEditarTarefa.SetParametroAdicionalAsync(frmHome, Convert.ToInt32(id), statusPassado);

                frmHome.pnlTelaPrincipal.Controls.Clear();
                frmHome.pnlTelaPrincipal.Controls.Add(ucEditarTarefa);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async void btnExcluirTarefa_Click(object sender, EventArgs e)
        {
            await ExcluirTarefaAsync();
        }

        private async Task ExcluirTarefaAsync()
        {
            var dialogResult = MensagensAlertaSistema.MensagemAtencaoYesNo("Tem certeza que deseja excluir essa tarefa?");

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    TelaCarregamento.ExibirCarregamentoForm(frmHome);

                    ResultadoOperacao resultadoOperacao = await tarefaService.DeletarTarefaAsync(Convert.ToInt32(id));

                    if (resultadoOperacao.Sucesso)
                    {
                        uc_MensagemExclusao mensagemExclusaoCantoInferiorDireito = new uc_MensagemExclusao(frmHome.pnlTelaPrincipal);

                        await ExibirTelaExibirTarefasAsync(statusPassado);
                    }
                    else
                    {
                        MensagensAlertaSistema.MensagemAlertaSistema(resultadoOperacao);
                    }
                }
                finally
                {
                    TelaCarregamento.EsconderCarregamento();
                }
            }
        }

        private async Task ExibirTelaExibirTarefasAsync(string _status)
        {
            var ucExibirTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_ExibirTarefas>();
            await ucExibirTarefas.SetParametroAdicionalAsync(frmHome, _status);

            frmHome.pnlTelaPrincipal.Controls.Clear();
            frmHome.pnlTelaPrincipal.Controls.Add(ucExibirTarefas);
        }
    }
}