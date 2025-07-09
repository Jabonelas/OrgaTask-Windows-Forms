using DevExpress.LookAndFeel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Threading.Tasks;
using WindowsForms.Classes;

namespace WindowsForms.Forms
{
    public partial class uc_CardTarefaPrioridade : DevExpress.XtraEditors.XtraUserControl
    {
        public string id { get => lblIdTarefa.Text; set => lblIdTarefa.Text = value; }
        public string titulo { get => lblTitulo.Text; set => lblTitulo.Text = value; }
        public string dataCriacao { get => lblDataCriacao.Text; set => lblDataCriacao.Text = value; }
        public string prazo { get => lblPrazo.Text; set => lblPrazo.Text = value; }
        public string status { get => lblStatus.Text; set => lblStatus.Text = value; }
        public Color corlblStatus { get => lblStatus.Appearance.BackColor; set => lblStatus.Appearance.BackColor = value; }

        private frmHome frmHome = null;

        public uc_CardTarefaPrioridade(frmHome _frmHome)
        {
            frmHome = _frmHome;

            InitializeComponent();

            CustomizarBotaoExibirTarefa();

            MantendoAparenciaLblStatus();
        }

        private void CustomizarBotaoExibirTarefa()
        {
            btnExibirTarefa.LookAndFeel.UseDefaultLookAndFeel = false;
            btnExibirTarefa.LookAndFeel.Style = LookAndFeelStyle.Skin;
        }

        private void MantendoAparenciaLblStatus()
        {
            lblStatus.ForeColor = Color.White;
            lblStatus.AppearanceDisabled.BackColor = lblStatus.Appearance.BackColor;
            lblStatus.AppearanceDisabled.ForeColor = lblStatus.Appearance.ForeColor;
            lblStatus.AppearanceDisabled.BorderColor = lblStatus.Appearance.BorderColor;
            lblStatus.Enabled = false;

        }

        private async void btnExibirTarefa_Click(object sender, System.EventArgs e)
        {
            await ExibirTelaDetalhesTarefaAsync();
        }

        private async void lblPendente_Click(object sender, EventArgs e)
        {
            await ExibirTelaDetalhesTarefaAsync();
        }

        private async void lblPrazo_Click(object sender, EventArgs e)
        {
            await ExibirTelaDetalhesTarefaAsync();
        }

        private async void lblDataCriacao_Click(object sender, EventArgs e)
        {
            await ExibirTelaDetalhesTarefaAsync();
        }

        private async void lblTitulo_Click(object sender, EventArgs e)
        {
            await ExibirTelaDetalhesTarefaAsync();
        }

        private async Task ExibirTelaDetalhesTarefaAsync()
        {
            try
            {
                ////TelaCarregamento.ExibirCarregamentoForm(frmHome);

                //string statusPassado = "Apenas Tarefas com Prioridade Alta";

                //var ucVisualizarTarefa = InjecaoDependencia.ServiceProvider.GetService<uc_VisualizarTarefa>();

                //await ucVisualizarTarefa.SetParametroAdicionalAsync(frmHome, Convert.ToInt32(id), statusPassado);

                //frmHome.pnlTelaPrincipal.Controls.Clear();
                //frmHome.pnlTelaPrincipal.Controls.Add(ucVisualizarTarefa);


                //string statusPassado = "Apenas Tarefas com Prioridade Alta";
                string statusPassado = status;

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
    }
}