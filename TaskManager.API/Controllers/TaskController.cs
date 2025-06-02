using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Delete;
using TaskManager.Application.UseCases.Task.GetAll;
using TaskManager.Application.UseCases.Task.GetById;
using TaskManager.Application.UseCases.Task.Register;
using TaskManager.Application.UseCases.Task.Update;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]

        public IActionResult Register([FromBody] RequestTaskJson request)
        {
            //business logic to register the pet would go here
            var useCase = new RegisterTaskUseCase();
            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTaskUseCase();
            var response = useCase.Execute();

            if (response.Pets.Count == 0)
            {
                return Ok(response);
            }
            return Ok(new List<ResponseRegisterTaskJson>());
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]

        public IActionResult Get(int id)
        {
            var UseCase = new GetTaskByIdUseCase();
            var response = UseCase.Execute(id);
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
        {
            //business logic to update the pet would go here
            var useCase = new UpdateTaskUseCase();
            useCase.Execute(id, request);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]

        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTaskByUseCase();
            try
            {
                useCase.Execute(id);
            }
            catch (ArgumentException)
            {
                return NotFound(new ResponseErrorsJson { Errors = new List<string> { "Pet not found." } });
            }

            return NoContent();
        }
    }
}
