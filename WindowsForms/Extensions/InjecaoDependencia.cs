using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
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

            // Configuração do HttpClient (única para todos os ambientes)
            services.AddScoped(provider =>
            {
                var client = new HttpClient();

#if DEBUG
                client.BaseAddress = new Uri("https://localhost:7091/");
#else
                //client.BaseAddress = new Uri("https://blazor-api.onrender.com");
#endif

                return client;
            });

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