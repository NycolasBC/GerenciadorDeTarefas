using GerenciadorDeTarefas.Application.Utils;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Task.GetAll
{
    public class GetAllTaskUseCase
    {
        public ResponseAllTasksJson? Execute()
        {
            var fileJson = new FileJson();

            return fileJson.ReadAllTaskFile();
        }
    }
}
