namespace WindowsForms.DTOs.Tarefa
{
    public class TarefaAlterarDTO
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Prioridade { get; set; }

        public int Prazo { get; set; }

        public string Status { get; set; }
    }

    public class TarefaAlterarDTOAPI
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Prazo { get; set; }


        public static implicit operator TarefaAlterarDTOAPI(TarefaAlterarDTO _tarefa)
        {
            return new TarefaAlterarDTOAPI()
            {
                Id = _tarefa.Id,
                Titulo = _tarefa.Titulo,
                Descricao = _tarefa.Descricao,
                Prazo = _tarefa.Prazo
            };
        }
    }
}