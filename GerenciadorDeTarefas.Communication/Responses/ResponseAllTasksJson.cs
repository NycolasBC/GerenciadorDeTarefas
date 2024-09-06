using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Responses
{
    public class ResponseAllTasksJson
    {
        public List<ResponseShortTasksJson> Tasks { get; set; } = [];
    }
}
