using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetById
{
    public class GetTaskByIdUseCase
    {
        public ResponseTaskJson Execute(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid pet ID.");
            }
            return new ResponseTaskJson
            {
                Id = id,
                Name = "Estudar C#",
                Description = "Estudar C# para aprimorar meus conhecimentos",
                Priority = Communication.Enums.TaskPriorityEnum.Alta,
                Status = Communication.Enums.TaskStatusEnum.EmAndamento
            };
        }
    }
}
