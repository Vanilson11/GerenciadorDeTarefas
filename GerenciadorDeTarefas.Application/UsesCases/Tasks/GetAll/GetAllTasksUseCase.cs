using GerenciadorDeTarefas.Communicarion.Responses;

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
                    Priority = Communicarion.Enums.PriorityType.Alta,
                    Status = Communicarion.Enums.StatusType.Andamento,
                },
                new ResponseShortTaskJson
                {
                    Id = 2,
                    Name = "Test2",
                    Priority = Communicarion.Enums.PriorityType.Média,
                    Status = Communicarion.Enums.StatusType.Concluido,
                }
            }
        };
    }
}
