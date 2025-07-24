using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsForms.Classes;
using WindowsForms.DTOs.Tarefa;

namespace WindowsForms.Interface
{
    public interface ITarefaService
    {
        Task<(ResultadoOperacao ResultadoOperacao, List<TarefaConsultaDTO> ListaTarefa, int TotalCount)> ObterTarefasPaginadasAsync(int _pageNumber, int _pageSize, string _status);

        Task<ResultadoOperacao> DeletarTarefaAsync(int _idTarefa);

        Task<ResultadoOperacao> AlterarTarefaAsync(TarefaAlterarDTO _dadosTarefa);

        Task<ResultadoOperacao> CadastrarTarefaAsync(TarefaCadastrarDTO _dadosTarefa);

        Task<(ResultadoOperacao ResultadoOperacao, TarefaConsultaDTO TarefaConsultaDTO)> BuscarTarefaAsync(int _idTarefa);

        Task<(ResultadoOperacao ResultadoOperacao, TarefaQtdStatusDTO TarefaQtdStatusDTO)> BuscarQtdStatusTarefaAsync();

        Task<(ResultadoOperacao ResultadoOperacao, List<TarefaPrioridadeAltaDTO> ListaTarefaPrioridadeAltaDTO)> BuscarTarefasPrioridadeAltaAsync();
    }
}