using System.Threading.Tasks;
using System;
using WindowsForms.Classes;
using Microsoft.Extensions.DependencyInjection;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.LookAndFeel;

namespace WindowsForms.Forms
{
    public partial class uc_CardTarefaPrioridade : DevExpress.XtraEditors.XtraUserControl
    {
        public string id { get => lblIdTarefa.Text; set => lblIdTarefa.Text = value; }
        public string titulo { get => lblTitulo.Text; set => lblTitulo.Text = value; }
        public string dataCriacao { get => lblDataCriacao.Text; set => lblDataCriacao.Text = value; }
        public string prazo { get => lblPrazo.Text; set => lblPrazo.Text = value; }

        private frmHome frmHome = null;

        public uc_CardTarefaPrioridade(frmHome _frmHome)
        {
            frmHome = _frmHome;

            InitializeComponent();

            CustomizarBotaoExibirTarefa();
        }

        private void CustomizarBotaoExibirTarefa()
        {
            btnExibirTarefa.LookAndFeel.UseDefaultLookAndFeel = false;
            btnExibirTarefa.LookAndFeel.Style = LookAndFeelStyle.Skin;
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
                //TelaCarregamento.ExibirCarregamentoForm(frmHome);

                string statusPassado = "Apenas Tarefas com Prioridade Alta";

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
    }
}