using GerenciadorDeTarefas.Application.Utils;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Task.Get
{
    public class GetTaskUseCase
    {
        public ResponseShortTasksJson? Execute(int id)
        {
            var fileJson = new FileJson();

            return fileJson.ReadTaskFile(id);
        }
    }
}
