using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace WindowsForms.Classes
{
    internal class MensagensAlertaSistema
    {
        public static DialogResult MensagemAtencaoYesNo(string _mensagem)
        {
            return XtraMessageBox.Show(_mensagem, "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public static void MensagemAlertaSistema(ResultadoOperacao _resultado)
        {
            (MessageBoxIcon icone, string titulo) = SelecionarIcone(_resultado.TipoErro);

            MessageBox.Show(_resultado.Mensagem, titulo, MessageBoxButtons.OK, icone);
        }

        private static (MessageBoxIcon, string) SelecionarIcone(TipoErro _tipoErro)
        {
            MessageBoxIcon icone;
            string titulo;

            switch (_tipoErro)
            {
                case TipoErro.Autenticacao:
                    icone = MessageBoxIcon.Warning;
                    titulo = "Credenciais Inválidas";
                    break;

                case TipoErro.Validacao:
                    icone = MessageBoxIcon.Warning;
                    titulo = "Dados inválidos";
                    break;

                case TipoErro.Servidor:
                    icone = MessageBoxIcon.Error;
                    titulo = "Erro no Servidor";
                    break;

                case TipoErro.Rede:
                    icone = MessageBoxIcon.Information;
                    titulo = "Problema de Rede";
                    break;

                default:
                    icone = MessageBoxIcon.Stop;
                    titulo = "Erro Inesperado";
                    break;
            }

            return (icone, titulo);
        }
    }
}