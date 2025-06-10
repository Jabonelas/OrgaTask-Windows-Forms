using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using WindowsForms.DTOs.Tarefa;
using WindowsForms.Interface;

namespace WindowsForms.Forms
{
    public partial class uc_CadastrarTarefa : DevExpress.XtraEditors.XtraUserControl
    {
        private frmHome frmHome = null;

        private readonly ITarefaService tarefaService;

        public uc_CadastrarTarefa(ITarefaService _tarefaService)
        {
            tarefaService = _tarefaService;

            InitializeComponent();
        }

        private void uc_CadastrarTarefa_Load(object sender, EventArgs e)
        {
            txtTitulo.Focus();
        }

        public void SetParametroAdicional(frmHome _frmHome)
        {
            frmHome = _frmHome;
        }

        private async void btnCancelar_Click_1(object sender, EventArgs e)
        {
            await CancelarCadastroTarefaAsync();
        }

        private async void btnSalvarTarefa_Click_1(object sender, EventArgs e)
        {
            if (!IsCamposPreenchidos())
            {
                return;
            }

            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                await SalvarTarefaAsync();
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async Task SalvarTarefaAsync()
        {
            TarefaAlterarDTO dadosTarefa = PreencherDadosTarefa();

            ResultadoOperacao resultadoOperacao = await tarefaService.CadastrarTarefaAsync(dadosTarefa);

            if (resultadoOperacao.Sucesso)
            {
                uc_MensagemConfirmacao mensagemConfirmacaoCantoInferiorDireito = new uc_MensagemConfirmacao(frmHome.pnlTelaPrincipal);

                await ExibirTelaExibirTarefasAsync();
            }
            else
            {
                MensagensAlertaSistema.MensagemAlertaSistema(resultadoOperacao);

                if (resultadoOperacao.Mensagem.Contains("Token"))
                {
                    ExibirTelaLogin();
                }
            }
        }

        private TarefaAlterarDTO PreencherDadosTarefa()
        {
            TarefaAlterarDTO dadosTarefa = new TarefaAlterarDTO
            {
                Titulo = txtTitulo.Text,
                Prioridade = cmbPrioridade.Text,
                Prazo = Convert.ToInt16(txtPrazo.Text),
                Descricao = txtDescricao.Text,
                Status = cmbStatus.Text
            };

            return dadosTarefa;
        }

        private void ExibirTelaLogin()
        {
            var ucLogin = InjecaoDependencia.ServiceProvider.GetService<uc_Login>();
            ucLogin.SetParametroAdicional(frmHome);

            frmHome.pnlTelaPrincipal.Controls.Clear();
            frmHome.pnlTelaPrincipal.Controls.Add(ucLogin);
        }

        private bool IsCamposPreenchidos()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text) ||
                string.IsNullOrEmpty(cmbPrioridade.Text) ||
                string.IsNullOrEmpty(txtPrazo.Text) ||
                string.IsNullOrEmpty(txtDescricao.Text) ||
                string.IsNullOrEmpty(cmbStatus.Text))
            {
                ResultadoOperacao mensagem = new ResultadoOperacao()
                {
                    TipoErro = TipoErro.Validacao,
                    Mensagem = "Alguns campos não foram preenchidos ou contêm informações inválidas"
                };

                MensagensAlertaSistema.MensagemAlertaSistema(mensagem);

                return false;
            }

            return true;
        }

        private async Task CancelarCadastroTarefaAsync()
        {
            var dialogResult = MensagensAlertaSistema.MensagemAtencaoYesNo("Tem certeza que deseja cancelar o cadastro da tarefa?");

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    TelaCarregamento.ExibirCarregamentoForm(frmHome);

                    await ExibirTelaExibirTarefasAsync();
                }
                finally
                {
                    TelaCarregamento.EsconderCarregamento();
                }
            }
        }

        private async Task ExibirTelaDashboardTarefasAsync()
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                var ucDashboardTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_DashboardTarefas>();
                await ucDashboardTarefas.SetParametroAdicionalAsync(frmHome);

                frmHome.pnlTelaPrincipal.Controls.Clear();
                frmHome.pnlTelaPrincipal.Controls.Add(ucDashboardTarefas);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async Task ExibirTelaExibirTarefasAsync()
        {
            var ucExibirTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_ExibirTarefas>();
            await ucExibirTarefas.SetParametroAdicionalAsync(frmHome, "todas");

            frmHome.pnlTelaPrincipal.Controls.Clear();
            frmHome.pnlTelaPrincipal.Controls.Add(ucExibirTarefas);
        }
    }
}