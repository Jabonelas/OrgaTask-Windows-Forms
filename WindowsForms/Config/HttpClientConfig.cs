using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace WindowsForms.Core
{
    internal class HttpClientConfig
    {
        public static void AddHttpClient(IServiceCollection services)
        {
            services.AddScoped(provider =>
            {
                var client = new HttpClient
                {
#if DEBUG
                    BaseAddress = new Uri("https://localhost:7091/")
#else
                    BaseAddress = new Uri("https://blazor-api.onrender.com/")
#endif
                };

                return client;
            });
        }

    }
}
