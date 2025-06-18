namespace WindowsForms.Classes
{
    public class ResultadoOperacao
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public TipoErro TipoErro { get; set; }

        // Métodos auxiliares para criar resultados
        public static ResultadoOperacao Ok() => new ResultadoOperacao { Sucesso = true };

        public static ResultadoOperacao Falha(string mensagem, TipoErro tipoErro)

            => new ResultadoOperacao { Sucesso = false, Mensagem = mensagem, TipoErro = tipoErro };
    }

    public enum TipoErro
    {
        Autenticacao,    // Credenciais inválidas
        Servidor,        // Erro 500, timeout
        Rede,            // Sem internet
        Validacao,       // Dados inválidos (ex: email mal formatado)
        Desconhecido     // Erro genérico
    }
}