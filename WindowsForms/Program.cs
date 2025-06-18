using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using WindowsForms.Core;

namespace WindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Definir o tema antes de executar a aplicação
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI");

            InjecaoDependencia.Configure();
            

            // Resolva o formulário principal através do ServiceProvider
            var formHome = InjecaoDependencia.ServiceProvider.GetService<frmHome>();
            Application.Run(formHome);
        }
    }
}