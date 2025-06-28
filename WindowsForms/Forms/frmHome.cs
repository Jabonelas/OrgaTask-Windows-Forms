using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using WindowsForms.Forms;
using WindowsForms.Interface;

namespace WindowsForms
{
    public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
     

        public frmHome()
        {


            InitializeComponent();
        }

        private void ExibirTelaLogin()
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(this);

                var ucLogin = InjecaoDependencia.ServiceProvider.GetService<uc_Login>();
                ucLogin.SetParametroAdicional(this);

                pnlTelaPrincipal.Controls.Clear();
                pnlTelaPrincipal.Controls.Add(ucLogin);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private void btnCadastrarTarefa_Click(object sender, EventArgs e)
        {
            ExibirTelaCadastrarTarefa();
        }

        private void ExibirTelaCadastrarTarefa()
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(this);

                var ucCadastrarTarefa = InjecaoDependencia.ServiceProvider.GetService<uc_CadastrarTarefa>();
                ucCadastrarTarefa.SetParametroAdicional(this);

                pnlTelaPrincipal.Controls.Clear();
                pnlTelaPrincipal.Controls.Add(ucCadastrarTarefa);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private async void btnTarefas_Click(object sender, EventArgs e)
        {
            await ExibirTelaExibirTarefasAsync();
        }

        private async Task ExibirTelaExibirTarefasAsync()
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(this);

                var ucExibirTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_ExibirTarefas>();
                await ucExibirTarefas.SetParametroAdicionalAsync(this, "todas");

                pnlTelaPrincipal.Controls.Clear();
                pnlTelaPrincipal.Controls.Add(ucExibirTarefas);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ExibirTelaDashboardTarefas();
        }

        private void ExibirTelaDashboardTarefas()
        {
            try
            {
                TelaCarregamento.ExibirCarregamentoForm(this);

                var ucExibirTarefas = InjecaoDependencia.ServiceProvider.GetService<uc_DashboardTarefas>();

                pnlTelaPrincipal.Controls.Clear();
                pnlTelaPrincipal.Controls.Add(ucExibirTarefas);
            }
            finally
            {
                TelaCarregamento.EsconderCarregamento();
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ExibirTelaLogin();
        }



        private void FinalizarAplicacao()
        {
            var dialogResult = MensagensAlertaSistema.MensagemAtencaoYesNo("Tem certeza que deseja finalizar o OrgTask?");

            if (dialogResult == DialogResult.Yes)
            {
                LimparCacheToken();

                Application.Exit();
            }
        }

        private void LimparCacheToken()
        {
            ConfigurationManager.AppSettings["authToken"] = null;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("authToken");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

  

        private void RealizarTrocaUsuario()
        {
            var dialogResult = MensagensAlertaSistema.MensagemAtencaoYesNo("Tem certeza que deseja trocar de usuário?");

            if (dialogResult == DialogResult.Yes)
            {
                BarraMenuLateral.Visible = false;
                lblImagemUsuario.Visible = false;
                lblUsuario.Visible = false;
                lblUsuario.Text = "";

                ExibirTelaLogin();
            }
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimparCacheToken();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            FinalizarAplicacao();
        }

        private void btnTrocarUsuario_Click_1(object sender, EventArgs e)
        {
            RealizarTrocaUsuario();
        }
    }
}