﻿using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Requests
{
    public class RequestTaskJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime MyProperty { get; set; }
        public Enums.TaskStatus Status { get; set; }
    }
}
