using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using WindowsForms.Interface;
using WindowsForms.Properties;

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

        public Image imagemlblPrioridade { get => lblPrioridade.ImageOptions.Image; set => lblPrioridade.ImageOptions.Image = value; }

        public Color corlblStatus { get => lblStatus.Appearance.BackColor; set => lblStatus.Appearance.BackColor = value; }
        public Image imagemlblStatus { get => lblStatus.ImageOptions.Image; set => lblStatus.ImageOptions.Image = value; }
        public Color corpnlFundo { get => pnlFundo.BackColor; set => pnlFundo.BackColor = value; }

        private frmHome frmHome = null;

        private readonly ITarefaService tarefaService;

        public uc_CardTarefa(ITarefaService _tarefaService)
        {
            tarefaService = _tarefaService;

            InitializeComponent();

            btnVisualizarTarefa.Paint += btnVisualizarTarefa_Paint;

            btnEditarTarefa.Paint += btnEditarTarefa_Paint;

            btnExcluirTarefa.Paint += btnExcluirTarefa_Paint;


            //this.Paint += uc_CardTarefa_Paint;
            //this.Resize += (s, e) => this.Invalidate(); 


        }


        private void btnEditarTarefa_Paint(object sender, PaintEventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            int borderRadius = 8; 
           Color borderColor = Color.FromArgb(242, 157, 74);

            int borderSize = 1;

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
                int r = borderRadius;

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void btnExcluirTarefa_Paint(object sender, PaintEventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            int borderRadius = 8;
            Color borderColor = Color.FromArgb(208, 49, 68);

            int borderSize = 1;

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
                int r = borderRadius;

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }


        private void btnVisualizarTarefa_Paint(object sender, PaintEventArgs e)
        {
            

            SimpleButton btn = sender as SimpleButton;
            int borderRadius = 8;
            Color borderColor = Color.FromArgb(108, 109, 117);

            int borderSize = 1;

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
                int r = borderRadius;

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }


        private void uc_CardTarefa_Paint(object sender, PaintEventArgs e)
        {
            UserControl btn = sender as UserControl;
            int borderRadius = 8;
            Color borderColor = Color.FromArgb(108, 109, 117);

            int borderSize = 1;

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
                int r = borderRadius;

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
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