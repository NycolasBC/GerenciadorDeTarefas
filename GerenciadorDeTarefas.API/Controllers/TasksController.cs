using GerenciadorDeTarefas.Application.UseCases.Task.Delete;
using GerenciadorDeTarefas.Application.UseCases.Task.Get;
using GerenciadorDeTarefas.Application.UseCases.Task.GetAll;
using GerenciadorDeTarefas.Application.UseCases.Task.Register;
using GerenciadorDeTarefas.Application.UseCases.Task.Update;
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseShortTasksJson), StatusCodes.Status200OK)]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var useCase = new GetTaskUseCase();

            var response = useCase.Execute(id);

            if (response != null)
            {
                return Ok(response);
            }

            return NotFound();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTaskUseCase();

            var response = useCase.Execute();

            if (response != null && response.Tasks.Count != 0)
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpPost]
        public IActionResult Register([FromBody] RequestTaskJson requestTask)
        {
            var useCase = new RegisterTaskUseCase();

            useCase.Execute(requestTask);

            return Created();
        }

        [HttpPut]
        public IActionResult Update([FromBody] RequestTaskJson requestTask)
        {
            var useCase = new UpdateTaskUseCase();

            useCase.Execute(requestTask);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTaskUseCase();

            useCase.Execute(id);

            return NoContent();
        }
    }
}
