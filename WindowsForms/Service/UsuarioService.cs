using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Classes;
using WindowsForms.DTOs;
using WindowsForms.DTOs.Usuario;
using WindowsForms.Interface;
using static System.Net.WebRequestMethods;

namespace WindowsForms.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient httpClient;

        public UsuarioService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<ResultadoOperacao> LoginAsync(UsuarioLoginDTO _dadosLogin)
        {
            try
            {
                var json = JsonConvert.SerializeObject(_dadosLogin);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var endpoint = SetandoEndPoint("api/usuarios/login");

                var response = await httpClient.PostAsync(endpoint, content);

                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<UserToken>(responseContent);

                    // Armazena token (usando ConfigurationManager)
                    ConfigurationManager.AppSettings["authToken"] = result.Token;
                    ConfigurationManager.AppSettings["usuario"] = _dadosLogin.login;

                    return ResultadoOperacao.Ok();
                }

                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                TipoErro tipoErro = SelecionarTipoErro(response);

                return ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro);
            }
            catch (HttpRequestException ex)
            {
                return ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede);
            }
            catch (Exception ex)
            {
                return ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido);
            }
        }

        public async Task<ResultadoOperacao> CadastrarUsuarioAsync(UsuarioCadastrarDTO _dadosUsuario)
        {
            try
            {
                var json = JsonConvert.SerializeObject(_dadosUsuario);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var endpoint = SetandoEndPoint("api/usuarios");

                var response = await httpClient.PostAsync(endpoint, content);

                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    //var result = JsonConvert.DeserializeObject<UserToken>(responseContent);

                    return ResultadoOperacao.Ok();
                }

                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                TipoErro tipoErro = SelecionarTipoErro(response);

                return ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro);
            }
            catch (HttpRequestException ex)
            {
                return ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede);
            }
            catch (Exception ex)
            {
                return ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido);
            }
        }

        #region Metodo Privado

        private string SetandoEndPoint(string _endpont)
        {
#if DEBUG

            return $"{_endpont}";

#else
            return $"https://blazor-api.onrender.com/{_endpont}";

#endif
        }

        private TipoErro SelecionarTipoErro(HttpResponseMessage _response)
        {
            TipoErro tipoErro;

            switch (_response.StatusCode)
            {
                case HttpStatusCode.Unauthorized:

                    tipoErro = TipoErro.Autenticacao;
                    break;

                case HttpStatusCode.InternalServerError:

                    tipoErro = TipoErro.Servidor;
                    break;

                case HttpStatusCode.RequestTimeout:

                    tipoErro = TipoErro.Rede;
                    break;

                default:

                    tipoErro = TipoErro.Desconhecido;
                    break;
            }

            return tipoErro;
        }

        #endregion Metodo Privado
    }
}