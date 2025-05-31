using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Threading.Tasks;
using WindowsForms.Classes;
using WindowsForms.DTOs.Usuario;
using WindowsForms.Interface;

namespace WindowsForms.Forms
{
    public partial class uc_Login : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IUsuarioService usuarioService;

        private frmHome frmHome = null;

        public uc_Login(IUsuarioService _usuarioService)
        {
            usuarioService = _usuarioService;

            InitializeComponent();
        }

        private void uc_Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        public void SetParametroAdicional(frmHome _frmHome)
        {
            frmHome = _frmHome;
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            ExibirTelaCadastrarUsuario();
        }

        private void ExibirTelaCadastrarUsuario()
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

                var ucCadastroUsuario = InjecaoDependencia.ServiceProvider.GetService<uc_CadastroUsuario>();
                ucCadastroUsuario.SetParametroAdicional(frmHome);

                frmHome.pnlTelaPrincipal.Controls.Clear();
                frmHome.pnlTelaPrincipal.Controls.Add(ucCadastroUsuario);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async void btnEntrar_Click(object sender, System.EventArgs e)
        {
            if (!IsCamposPreenchidos())
            {
                return;
            }

            try
            {
                TelaCarregamento.ExibirCarregamentoForm(frmHome);

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
                login = txtUsuario.Text,
                senha = txtSenha.Text
            };

            ResultadoOperacao resultadoOperacao = await usuarioService.LoginAsync(dadosUsuario);

            if (resultadoOperacao.Sucesso)
            {
                await ExibirTelaDashboardTarefasAsync();
            }
            else
            {
                MensagensAlertaSistema.MensagemAlertaSistema(resultadoOperacao);
            }
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
            frmHome.lblUsuario.Text = txtUsuario.Text;
        }

        private bool IsCamposPreenchidos()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
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
    }
}