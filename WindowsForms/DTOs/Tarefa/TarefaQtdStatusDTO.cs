﻿using System;

namespace WindowsForms.DTOs.Tarefa
{
    public class TarefaQtdStatusDTO
    {
        public int Pendente { get; set; }
        public int EmProgresso { get; set; }
        public int Concluido { get; set; }

        public decimal PorcentagemConcluidas { get; set; }
    }

    public class TaskModel
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
    }
}