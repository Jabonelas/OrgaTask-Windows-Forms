﻿namespace WindowsForms.DTOs.Tarefa
{
    public class TarefaQtdStatusDTO
    {
        public int Pendente { get; set; }
        public int EmProgresso { get; set; }
        public int Concluido { get; set; }
        public decimal PorcentagemConcluidas { get; set; }
    }
}