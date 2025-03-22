using GerenciadorDeTarefas.Communication.Enums;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UsesCases.Tasks.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Test",
                    Priority = PriorityType.Alta,
                    Status = StatusType.Andamento,
                },
                new ResponseShortTaskJson
                {
                    Id = 2,
                    Name = "Test2",
                    Priority = PriorityType.Média,
                    Status = StatusType.Concluido,
                }
            }
        };
    }
}
