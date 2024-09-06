using GerenciadorDeTarefas.Application.Utils;
using GerenciadorDeTarefas.Communication.Requests;

namespace GerenciadorDeTarefas.Application.UseCases.Task.Register
{
    public class RegisterTaskUseCase
    {
        public void Execute(RequestTaskJson task)
        {
            var fileJson = new FileJson();

            fileJson.WriteTaskFile(task);
        }
    }
}
