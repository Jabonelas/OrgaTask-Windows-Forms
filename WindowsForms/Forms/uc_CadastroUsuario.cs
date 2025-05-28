using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using WindowsForms.DTOs.Usuario;
using WindowsForms.Interface;

namespace WindowsForms.Forms
{
    public partial class uc_CadastroUsuario : DevExpress.XtraEditors.XtraUserControl
    {
        private frmHome frmHome = null;
        private readonly IUsuarioService usuarioService;

        public uc_CadastroUsuario(IUsuarioService _usuarioService)
        {
            usuarioService = _usuarioService;

            InitializeComponent();
        }

        public void SetParametroAdicional(frmHome _frmHome)
        {
            frmHome = _frmHome;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Cancelar();
        }

        private async void btnCadastarUsuario_Click_1(object sender, EventArgs e)
        {
            if (!IsCamposPreenchidos())
            {
                return;
            }

            if (!IsSenhasIguais())
            {
                return;
            }

            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                await CadastrarUsuarioAsync();

                await RealizarLoginAsync();
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async Task RealizarLoginAsync()
        {
            UsuarioLoginDTO dadosUsuario = new UsuarioLoginDTO
            {
                login = txtLogin.Text,
                senha = txtSenha.Text
            };

            ResultadoOperacao resultadoOperacao = await usuarioService.LoginAsync(dadosUsuario);

            if (resultadoOperacao.Sucesso)
            {
                await ExibirTelaDashboardTarefasAsync();

                return;
            }

            MensagensDoSistema.MensagemAlertaSistema(resultadoOperacao);
        }

        private async Task ExibirTelaDashboardTarefasAsync()
        {
            var ucDashboardTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_DashboardTarefas>();
            await ucDashboardTarefas.SetParametroAdicionalAsync(frmHome);

            frmHome.pnlTelaPrincipal.Controls.Clear();
            frmHome.pnlTelaPrincipal.Controls.Add(ucDashboardTarefas);

            frmHome.BarraMenuLateral.Visible = true;
            frmHome.lblImagemUsuario.Visible = true;
            frmHome.lblUsuario.Visible = true;
            frmHome.lblUsuario.Text = txtLogin.Text;
        }

        private bool IsCamposPreenchidos()
        {
            if (string.IsNullOrEmpty(txtNomeCompleto.Text) ||
                string.IsNullOrEmpty(txtLogin.Text) ||
                string.IsNullOrEmpty(txtSenha.Text) ||
                string.IsNullOrEmpty(txtConfirmaSenha.Text))
            {
                ResultadoOperacao mensagem = new ResultadoOperacao()
                {
                    TipoErro = TipoErro.Validacao,
                    Mensagem = "Alguns campos não foram preenchidos ou contêm informações inválidas"
                };

                MensagensDoSistema.MensagemAlertaSistema(mensagem);

                return false;
            }

            return true;
        }

        private bool IsSenhasIguais()
        {
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                ResultadoOperacao mensagem = new ResultadoOperacao()
                {
                    TipoErro = TipoErro.Validacao,
                    Mensagem = "As senhas digitadas não são iguais. Por favor, verifique."
                };

                MensagensDoSistema.MensagemAlertaSistema(mensagem);

                return false;
            }

            return true;
        }

        private void Cancelar()
        {
            var dialogResult = MensagensDoSistema.MensagemAtencaoYesNo("Tem certeza que deseja cancelar o cadastro de usuário?");

            if (dialogResult == DialogResult.Yes)
            {
                ExibirTelaLogin();
            }
        }

        private void ExibirTelaLogin()
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                var ucLogin = InjecaoDependencia.ServiceProvider.GetService<uc_Login>();
                ucLogin.SetParametroAdicional(frmHome);

                frmHome.pnlTelaPrincipal.Controls.Clear();
                frmHome.pnlTelaPrincipal.Controls.Add(ucLogin);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async Task CadastrarUsuarioAsync()
        {
            UsuarioCadastrarDTO dadosUsuario = PreencherDadosUsuario();

            ResultadoOperacao resultadoOperacao = await usuarioService.CadastrarUsuarioAsync(dadosUsuario);

            if (resultadoOperacao.Sucesso)
            {
                uc_MensagemConfirmacao mensagemConfirmacaoCantoInferiorDireito = new uc_MensagemConfirmacao(frmHome.pnlTelaPrincipal);

                return;
            }

            MensagensDoSistema.MensagemAlertaSistema(resultadoOperacao);
        }

        private UsuarioCadastrarDTO PreencherDadosUsuario()
        {
            UsuarioCadastrarDTO dadosUsuario = new UsuarioCadastrarDTO
            {
                Nome = txtNomeCompleto.Text,
                Login = txtLogin.Text,
                Senha = txtSenha.Text,
                ConfirmarSenha = txtConfirmaSenha.Text
            };

            return dadosUsuario;
        }
    }
}