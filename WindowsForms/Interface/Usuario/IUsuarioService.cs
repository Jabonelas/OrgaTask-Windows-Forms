using System.Threading.Tasks;
using WindowsForms.Classes;
using WindowsForms.DTOs.Usuario;

namespace WindowsForms.Interface
{
    public interface IUsuarioService
    {
        Task<ResultadoOperacao> LoginAsync(UsuarioLoginDTO _dadosLogin);

        Task<ResultadoOperacao> CadastrarUsuarioAsync(UsuarioCadastrarDTO _dadosUsuario);
    }
}