using Microsoft.Extensions.DependencyInjection;
using System;
using WindowsForms.Core;
using WindowsForms.Forms;
using WindowsForms.Interface;
using WindowsForms.Service;

namespace WindowsForms
{
    internal class InjecaoDependencia
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Configure()
        {
            var services = new ServiceCollection();

            HttpClientConfig.AddHttpClient(services);

            //Service
            services.AddScoped<ITarefaService, TarefaService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            //Forms
            services.AddScoped<frmHome>();
            services.AddScoped<uc_Login>();
            services.AddScoped<uc_CadastroUsuario>();
            services.AddScoped<uc_DashboardTarefas>();
            services.AddScoped<uc_CadastrarTarefa>();
            services.AddScoped<uc_ExibirTarefas>();
            services.AddScoped<uc_CardTarefa>();
            services.AddScoped<uc_VisualizarTarefa>();
            services.AddScoped<uc_EditarTarefa>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}