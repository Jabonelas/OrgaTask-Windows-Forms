using DevExpress.XtraBars.Alerter;
using System;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class uc_MensagemConfirmacao : DevExpress.XtraEditors.XtraUserControl
    {
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer pnlTelaPrincipalFormHome;

        public uc_MensagemConfirmacao(DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer _pnlTelaPrincipalFormHome)
        {
            InitializeComponent();

            pnlTelaPrincipalFormHome = _pnlTelaPrincipalFormHome;

            timer1.Stop();
            timer1.Start();

            ExibindoMensagem();
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
                alcConfirmacao.Show(parentForm, info);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();

            this.Dispose();
        }

        private void alcConfirmacao_HtmlElementMouseClick_1(object sender, AlertHtmlElementMouseEventArgs e)
        {
            // Verifica qual elemento foi clicado pelo 'id'
            if (e.ElementId == "dialogresult-ok")
            {
                alcConfirmacao.Dispose();
            }
            else if (e.ElementId == "close")
            {
                alcConfirmacao.Dispose();
            }
        }
    }
}