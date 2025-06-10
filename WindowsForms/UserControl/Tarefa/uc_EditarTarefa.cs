using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using WindowsForms.DTOs.Tarefa;
using WindowsForms.Interface;

namespace WindowsForms.Forms
{
    public partial class uc_EditarTarefa : DevExpress.XtraEditors.XtraUserControl
    {
        private int idTarefa = 0;

        private string statusPassado = "";

        private frmHome frmHome = null;

        private readonly ITarefaService tarefaService;

        public uc_EditarTarefa(ITarefaService _tarefaService)
        {
            tarefaService = _tarefaService;

            InitializeComponent();
        }

        private void uc_EditarTarefa_Load(object sender, EventArgs e)
        {
            txtTitulo.Focus();
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
            cmbPrioridade.Text = Tarefa.Prioridade;
            txtPrazo.Text = Tarefa.Prazo.ToString();
            txtDescricao.Text = Tarefa.Descricao;
            cmbStatus.Text = Tarefa.Status;
        }

        private async Task CancelarEdicaoTarefaAsync()
        {
            var dialogResult = MensagensAlertaSistema.MensagemAtencaoYesNo("Tem certeza que deseja cancelar a edição da tarefa?");

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

        private async Task ExibirTelaExibirTarefasAsync()
        {
            var ucExibirTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_ExibirTarefas>();
            await ucExibirTarefas.SetParametroAdicionalAsync(frmHome, statusPassado);

            frmHome.pnlTelaPrincipal.Controls.Clear();
            frmHome.pnlTelaPrincipal.Controls.Add(ucExibirTarefas);
        }

        private async void btnCancelar_Click_1(object sender, EventArgs e)
        {
            await CancelarEdicaoTarefaAsync();
        }

        private async void btnSalvarAlteracao_Click_1(object sender, EventArgs e)
        {
            if (!IsCamposPreenchidos())
            {
                return;
            }

            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                await SalvarAlteracaoAsync();
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async Task SalvarAlteracaoAsync()
        {
            TarefaAlterarDTO dadosTarefa = PreencherDadosTarefa();

            ResultadoOperacao resultadoOperacao = await tarefaService.AlterarTarefaAsync(dadosTarefa);

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
                Id = idTarefa,
                Titulo = txtTitulo.Text,
                Prioridade = cmbPrioridade.Text,
                Prazo = Convert.ToInt16(txtPrazo.Text),
                Descricao = txtDescricao.Text,
                Status = cmbStatus.Text
            };

            return dadosTarefa;
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

        private void ExibirTelaLogin()
        {
            var ucLogin = InjecaoDependencia.ServiceProvider.GetService<uc_Login>();
            ucLogin.SetParametroAdicional(frmHome);

            frmHome.pnlTelaPrincipal.Controls.Clear();
            frmHome.pnlTelaPrincipal.Controls.Add(ucLogin);
        }
    }
}