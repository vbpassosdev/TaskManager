using TaskManager.Communication.Enums;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAll
{
    public class GetAllTaskUseCase
    {
        public ResponseAllTaskJson Execute()
        {
            // Here you would typically fetch the data from a database or another source.
            // For now, we will return an empty response for demonstration purposes.
            return new ResponseAllTaskJson
            {
                Pets = new List<ResponseShortTaskJson>
                {
                    new ResponseShortTaskJson
                    {
                        Id = 1,
                        Name = "Buddy",
                        Priority = TaskPriorityEnum.Alta,
                        Status = TaskStatusEnum.Aguardando,
                    },
                }
            };
        }
    }
}
