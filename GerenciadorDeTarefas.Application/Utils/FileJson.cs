using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Newtonsoft.Json;

namespace GerenciadorDeTarefas.Application.Utils
{
    public class FileJson
    {
        private readonly string _fileTaskPath;

        public FileJson()
        {
            _fileTaskPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "tasks.json");
        }

        public ResponseAllTasksJson? ReadAllTaskFile()
        {
            var responseAllTasks = new ResponseAllTasksJson();

            if (!File.Exists(_fileTaskPath))
            {
                return responseAllTasks;
            }

            string json = File.ReadAllText(_fileTaskPath);

            var listTasks = JsonConvert.DeserializeObject<List<ResponseShortTasksJson>>(json);

            if (listTasks != null)
            {
                responseAllTasks.Tasks = listTasks;
            }

            return responseAllTasks;
        }

        public ResponseShortTasksJson? ReadTaskFile(int id)
        {
            if (!File.Exists(_fileTaskPath))
            {
                return new ResponseShortTasksJson();
            }

            string json = File.ReadAllText(_fileTaskPath);
            var listTasks = JsonConvert.DeserializeObject<List<ResponseShortTasksJson>>(json);

            return listTasks?.FirstOrDefault(p => p.Id == id);
        }

        public void WriteTaskFile(RequestTaskJson task)
        {

            string json = JsonConvert.SerializeObject(task);
            File.WriteAllText(_fileTaskPath, json);
        }
    }
}
