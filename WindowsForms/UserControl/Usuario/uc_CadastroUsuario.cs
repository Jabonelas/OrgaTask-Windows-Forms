using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using WindowsForms.DTOs.Usuario;
using WindowsForms.Interface;
using WindowsForms.Properties;

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

            SetandoPropriedadeSenha();

        }

        private void uc_CadastroUsuario_Load(object sender, EventArgs e)
        {
            txtNomeCompleto.Focus();

            PlaceholderCampos();
        }



        private void PlaceholderCampos()
        {
            txtNomeCompleto.Properties.NullText = "Digite o nome completo...";
            txtNomeCompleto.EditValue = null;

            txtLogin.Properties.NullText = "Digite a senha...";
            txtLogin.EditValue = null;
        }

        private void SetandoPropriedadeSenha()
        {
            txtSenha.Properties.UseSystemPasswordChar = true;
            btnExibirSenha.ImageOptions.Image = Resources.olho_aberto_20;

            txtConfirmaSenha.Properties.UseSystemPasswordChar = true;
            btnExibirConfirmarSenha.ImageOptions.Image = Resources.olho_aberto_20;
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
                Login = txtLogin.Text,
                Senha = txtSenha.Text
            };

            ResultadoOperacao resultadoOperacao = await usuarioService.LoginAsync(dadosUsuario);

            if (resultadoOperacao.Sucesso)
            {
                await ExibirTelaDashboardTarefasAsync();

                return;
            }

            MensagensAlertaSistema.MensagemAlertaSistema(resultadoOperacao);
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
            if (txtNomeCompleto.EditValue == null ||
                txtLogin.EditValue == null ||
                txtSenha.EditValue == null ||
                txtConfirmaSenha.EditValue == null)
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

        private bool IsSenhasIguais()
        {
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                ResultadoOperacao mensagem = new ResultadoOperacao()
                {
                    TipoErro = TipoErro.Validacao,
                    Mensagem = "As senhas digitadas não são iguais. Por favor, verifique."
                };

                MensagensAlertaSistema.MensagemAlertaSistema(mensagem);

                return false;
            }

            return true;
        }

        private void Cancelar()
        {
            var dialogResult = MensagensAlertaSistema.MensagemAtencaoYesNo("Tem certeza que deseja cancelar o cadastro de usuário?");

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

            MensagensAlertaSistema.MensagemAlertaSistema(resultadoOperacao);
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

        private void btnExibirSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Properties.UseSystemPasswordChar)
            {
                txtSenha.Properties.UseSystemPasswordChar = false;

                btnExibirSenha.ImageOptions.Image = Resources.olho_fechado_20;
            }
            else
            {
                txtSenha.Properties.UseSystemPasswordChar = true;

                btnExibirSenha.ImageOptions.Image = Resources.olho_aberto_20;
            }
        }

        private void btnExibirConfirmarSenha_Click(object sender, EventArgs e)
        {
            if (txtConfirmaSenha.Properties.UseSystemPasswordChar)
            {
                txtConfirmaSenha.Properties.UseSystemPasswordChar = false;

                btnExibirConfirmarSenha.ImageOptions.Image = Resources.olho_fechado_20;
            }
            else
            {
                txtConfirmaSenha.Properties.UseSystemPasswordChar = true;

                btnExibirConfirmarSenha.ImageOptions.Image = Resources.olho_aberto_20;
            }
        }
    }
}