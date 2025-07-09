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

        private void PlaceholderCampos()
        {
            txtTitulo.Properties.NullText = "Digite o título...";
            txtTitulo.EditValue = null;

            cmbPrioridade.Properties.NullText = "Selecione a prioridade...";
            cmbPrioridade.EditValue = null;

            txtPrazo.Properties.NullText = "Informe um prazo...";
            txtPrazo.EditValue = null;

            txtDescricao.Properties.NullText = "Digite a descrição da tarefa...";
            txtDescricao.EditValue = null;

            cmbStatus.Properties.NullText = "Selecione o status...";
            cmbStatus.EditValue = null;
        }

        public void SetParametroAdicional(frmHome _frmHome)
        {
            frmHome = _frmHome;

            PlaceholderCampos();
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
            TarefaCadastrarDTO dadosTarefa = PreencherDadosTarefa();

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

        private TarefaCadastrarDTO PreencherDadosTarefa()
        {
            TarefaCadastrarDTO dadosTarefa = new TarefaCadastrarDTO()
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
            if (txtTitulo.EditValue == null ||
                cmbPrioridade.EditValue == null ||
                txtPrazo.EditValue == null ||
                txtDescricao.EditValue == null ||
                cmbStatus.EditValue == null)
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

        private void txtPrazo_Leave(object sender, EventArgs e)
        {
            if (txtPrazo.Text == " _")
            {
                txtPrazo.Text = 0.ToString();
            }
        }
    }
}