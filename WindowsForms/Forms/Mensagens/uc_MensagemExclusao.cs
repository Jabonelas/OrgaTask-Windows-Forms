using DevExpress.XtraBars.Alerter;
using System;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class uc_MensagemExclusao : DevExpress.XtraEditors.XtraUserControl
    {
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer pnlTelaPrincipalFormHome;

        public uc_MensagemExclusao(DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer _pnlTelaPrincipalFormHome)
        {
            InitializeComponent();

            pnlTelaPrincipalFormHome = _pnlTelaPrincipalFormHome;

            timer1.Stop();
            timer1.Start();

            ExibindoMensagem();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            this.Dispose();
        }

        private void alcExclusao_HtmlElementMouseClick(object sender, DevExpress.XtraBars.Alerter.AlertHtmlElementMouseEventArgs e)
        {
            // Verifica qual elemento foi clicado pelo 'id'
            if (e.ElementId == "dialogresult-ok")
            {
                alcExclusao.Dispose();
            }
            else if (e.ElementId == "close")
            {
                alcExclusao.Dispose();
            }
        }

        private void ExibindoMensagem()
        {
            // Obtém o FluentDesignForm ao qual o FluentDesignFormContainer pertence
            Form parentForm = pnlTelaPrincipalFormHome.FindForm();

            // Verifica se o parentForm não é nulo
            if (parentForm != null)
            {
                // Cria a mensagem e exibe o AlertControl
                AlertInfo info = new AlertInfo("", "");
                alcExclusao.Show(parentForm, info);
            }
        }
    }
}