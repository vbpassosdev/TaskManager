using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseRegisterTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseRegisterTaskJson
            {
                Id = 7,
                Name = request.Name,
                Description = request.Description,
            };
        }

    }
}
