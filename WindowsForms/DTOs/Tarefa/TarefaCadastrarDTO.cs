﻿namespace WindowsForms.DTOs.Tarefa
{
    public class TarefaCadastrarDTO
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Prioridade { get; set; }

        public int Prazo { get; set; }

        public string Status { get; set; }
    }

    public class TarefaCadastrarDTOAPI
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }


        public int Prazo { get; set; }


        public static implicit operator TarefaCadastrarDTOAPI(TarefaCadastrarDTO _tarefa)
        {
            return new TarefaCadastrarDTOAPI()
            {
                Titulo = _tarefa.Titulo,
                Descricao = _tarefa.Descricao,
                Prazo = _tarefa.Prazo
            };
        }
    }
}