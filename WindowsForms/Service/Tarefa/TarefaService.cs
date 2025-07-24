using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Classes;
using WindowsForms.Core;
using WindowsForms.DTOs;
using WindowsForms.DTOs.Tarefa;
using WindowsForms.Interface;

namespace WindowsForms.Service
{
    public class TarefaService : ITarefaService
    {
        private readonly HttpClient httpClient;

        public TarefaService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public class PagedResult<T>
        {
            public List<T> Items { get; set; }
            public int TotalCount { get; set; }
        }

        public async Task<ResultadoOperacao> CadastrarTarefaAsync(TarefaCadastrarDTO _dadosTarefa)
        {
            try
            {
                UserToken dadosToken = await PegarDadosToken();

                if (dadosToken == null || string.IsNullOrEmpty(dadosToken.Token))
                {
                    return ResultadoOperacao.Falha("Token de autenticação inválido", TipoErro.Autenticacao);
                }

                TarefaCadastrarDTOAPI dadosTarefa = _dadosTarefa;
                string prioridade = _dadosTarefa.Prioridade;
                string status = _dadosTarefa.Status;

                var json = JsonConvert.SerializeObject(dadosTarefa);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var endpoint = SetandoEndPoint($"api/tarefas?prioridade={prioridade}&status={status.Replace(" ", "_")}");
                //var endpoint = SetandoEndPoint("api/tarefas");

                // Criação do HttpClient com o header de autenticação
                using (var request = new HttpRequestMessage(HttpMethod.Post, endpoint))
                {
                    request.Content = content;
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", dadosToken.Token);

                    var response = await httpClient.SendAsync(request);

                    TipoErro tipoErro = SelecionarTipoErro(response);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return ResultadoOperacao.Falha("Sessão expirada. Por favor, faça login novamente.", tipoErro);
                    }

                    var responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var result = JsonConvert.DeserializeObject<UserToken>(responseContent);

                        return ResultadoOperacao.Ok();
                    }

                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                    return ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro);
                }
            }
            catch (HttpRequestException ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede);
            }
            catch (Exception ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido);
            }
        }

        public async Task<(ResultadoOperacao ResultadoOperacao, List<TarefaConsultaDTO> ListaTarefa, int TotalCount)> ObterTarefasPaginadasAsync(int _pageNumber, int _pageSize, string _status)
        {
            try
            {
                UserToken dadosToken = await PegarDadosToken();

                if (dadosToken == null || string.IsNullOrEmpty(dadosToken.Token))
                {
                    return (ResultadoOperacao.Falha("Token de autenticação inválido", TipoErro.Autenticacao), null, 0);
                }

                var endpoint = SetandoEndPoint($"api/tarefas/paginado/{_status.Replace(" ", "_")}?pageNumber={_pageNumber}&pageSize={_pageSize}");

                // Criação do HttpClient com o header de autenticação
                using (var request = new HttpRequestMessage(HttpMethod.Get, endpoint))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", dadosToken.Token);

                    var response = await httpClient.SendAsync(request);

                    TipoErro tipoErro = SelecionarTipoErro(response);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return (ResultadoOperacao.Falha("Sessão expirada. Por favor, faça login novamente.", tipoErro), null, 0);
                    }

                    var responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var result = JsonConvert.DeserializeObject<PagedResult<TarefaConsultaDTO>>(responseContent);

                        return (ResultadoOperacao.Ok(), result.Items, result.TotalCount);
                    }

                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                    return (ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro), null, 0);
                }
            }
            catch (HttpRequestException ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede), null, 0);
            }
            catch (Exception ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido), null, 0);
            }
        }

        public async Task<(ResultadoOperacao ResultadoOperacao, TarefaConsultaDTO TarefaConsultaDTO)> BuscarTarefaAsync(int _idTarefa)
        {
            try
            {
                UserToken dadosToken = await PegarDadosToken();

                if (dadosToken == null || string.IsNullOrEmpty(dadosToken.Token))
                {
                    return (ResultadoOperacao.Falha("Token de autenticação inválido", TipoErro.Autenticacao), null);
                }

                var endpoint = SetandoEndPoint($"api/tarefas/{_idTarefa}");

                // Criação do HttpClient com o header de autenticação
                using (var request = new HttpRequestMessage(HttpMethod.Get, endpoint))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", dadosToken.Token);

                    var response = await httpClient.SendAsync(request);

                    TipoErro tipoErro = SelecionarTipoErro(response);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return (ResultadoOperacao.Falha("Sessão expirada. Por favor, faça login novamente.", tipoErro), null);
                    }

                    var responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var result = JsonConvert.DeserializeObject<TarefaConsultaDTO>(responseContent);

                        return (ResultadoOperacao.Ok(), result);
                    }

                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                    return (ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro), null);
                }
            }
            catch (HttpRequestException ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede), null);
            }
            catch (Exception ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido), null);
            }
        }

        public async Task<ResultadoOperacao> AlterarTarefaAsync(TarefaAlterarDTO _dadosTarefa)
        {
            try
            {
                UserToken dadosToken = await PegarDadosToken();

                if (dadosToken == null || string.IsNullOrEmpty(dadosToken.Token))
                {
                    return (ResultadoOperacao.Falha("Token de autenticação inválido", TipoErro.Autenticacao));
                }

                TarefaAlterarDTOAPI dadosTarefa = _dadosTarefa;
                string prioridade = _dadosTarefa.Prioridade;
                string status = _dadosTarefa.Status;

                var json = JsonConvert.SerializeObject(dadosTarefa);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                //https://localhost:7091/api/tarefas?prioridade=Alta&status=Pendente
                var endpoint = SetandoEndPoint($"api/tarefas?prioridade={prioridade}&status={status.Replace(" ", "_")}");

                // Criação do HttpClient com o header de autenticação
                using (var request = new HttpRequestMessage(HttpMethod.Put, endpoint))
                {
                    request.Content = content;
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", dadosToken.Token);

                    var response = await httpClient.SendAsync(request);

                    TipoErro tipoErro = SelecionarTipoErro(response);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return ResultadoOperacao.Falha("Sessão expirada. Por favor, faça login novamente.", tipoErro);
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        return ResultadoOperacao.Ok();
                    }

                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                    return (ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro));
                }
            }
            catch (HttpRequestException ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede));
            }
            catch (Exception ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido));
            }
        }

        public async Task<ResultadoOperacao> DeletarTarefaAsync(int _idTarefa)
        {
            try
            {
                UserToken dadosToken = await PegarDadosToken();

                if (dadosToken == null || string.IsNullOrEmpty(dadosToken.Token))
                {
                    return ResultadoOperacao.Falha("Token de autenticação inválido", TipoErro.Autenticacao);
                }

                var endpoint = SetandoEndPoint($"api/tarefas/{_idTarefa}");

                // Criação do HttpClient com o header de autenticação
                using (var request = new HttpRequestMessage(HttpMethod.Delete, endpoint))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", dadosToken.Token);

                    var response = await httpClient.SendAsync(request);

                    TipoErro tipoErro = SelecionarTipoErro(response);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return ResultadoOperacao.Falha("Sessão expirada. Por favor, faça login novamente.", tipoErro);
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        return ResultadoOperacao.Ok();
                    }

                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                    return ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro);
                }
            }
            catch (HttpRequestException ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede);
            }
            catch (Exception ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido);
            }
        }

        public async Task<(ResultadoOperacao, TarefaQtdStatusDTO)> BuscarQtdStatusTarefaAsync()
        {
            try
            {
                UserToken dadosToken = await PegarDadosToken();

                if (dadosToken == null || string.IsNullOrEmpty(dadosToken.Token))
                {
                    return (ResultadoOperacao.Falha("Token de autenticação inválido", TipoErro.Autenticacao), null);
                }

                var endpoint = SetandoEndPoint($"api/tarefas/status_completo");

                // Criação do HttpClient com o header de autenticação
                using (var request = new HttpRequestMessage(HttpMethod.Get, endpoint))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", dadosToken.Token);

                    var response = await httpClient.SendAsync(request);

                    TipoErro tipoErro = SelecionarTipoErro(response);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return (ResultadoOperacao.Falha("Sessão expirada. Por favor, faça login novamente.", tipoErro), null);
                    }

                    var responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        TarefaQtdStatusDTO qtdStatusTarefas = JsonConvert.DeserializeObject<TarefaQtdStatusDTO>(responseContent);

                        return (ResultadoOperacao.Ok(), qtdStatusTarefas);
                    }

                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                    return (ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro), null);
                }
            }
            catch (HttpRequestException ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede), null);
            }
            catch (Exception ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido), null);
            }
        }

        public async Task<(ResultadoOperacao ResultadoOperacao, List<TarefaPrioridadeAltaDTO> ListaTarefaPrioridadeAltaDTO)> BuscarTarefasPrioridadeAltaAsync()
        {
            try
            {
                UserToken dadosToken = await PegarDadosToken();

                if (dadosToken == null || string.IsNullOrEmpty(dadosToken.Token))
                {
                    return (ResultadoOperacao.Falha("Token de autenticação inválido", TipoErro.Autenticacao), null);
                }

                var endpoint = SetandoEndPoint($"api/tarefas/prioridade_alta");

                // Criação do HttpClient com o header de autenticação
                using (var request = new HttpRequestMessage(HttpMethod.Get, endpoint))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", dadosToken.Token);

                    var response = await httpClient.SendAsync(request);

                    TipoErro tipoErro = SelecionarTipoErro(response);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        return (ResultadoOperacao.Falha("Sessão expirada. Por favor, faça login novamente.", tipoErro), null);
                    }

                    var responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var listaTarefasPrioridadeAlta = JsonConvert.DeserializeObject<List<TarefaPrioridadeAltaDTO>>(responseContent);

                        return (ResultadoOperacao.Ok(), listaTarefasPrioridadeAlta);
                    }

                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                    return (ResultadoOperacao.Falha(errorResponse?.message ?? "Erro desconhecido", tipoErro), null);
                }
            }
            catch (HttpRequestException ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha("Sem conexão com a internet", TipoErro.Rede), null);
            }
            catch (Exception ex)
            {
                LogErros.GravarLogErros(ex.Message);

                return (ResultadoOperacao.Falha(ex.Message, TipoErro.Desconhecido), null);
            }
        }

        #region Metodo Privado

        private async Task<UserToken> PegarDadosToken()
        {
            UserToken dadosToken = new UserToken();

            //Pegando o token que foi gerado
            dadosToken.Token = ConfigurationManager.AppSettings["authToken"];

            return dadosToken;
        }

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