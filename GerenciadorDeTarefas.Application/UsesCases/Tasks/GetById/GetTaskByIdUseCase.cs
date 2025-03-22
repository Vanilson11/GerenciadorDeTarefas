using GerenciadorDeTarefas.Communicarion.Responses;

namespace GerenciadorDeTarefas.Application.UsesCases.Tasks.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson()
        {
            Id = id,
            Name = "Estudar C#",
            Descricao = "Estudar o módulo 4 do curso de C# da Rocketseat",
            Priority = Communicarion.Enums.PriorityType.Média,
            DateLimit = new DateTime(year: 2025, month: 3, day: 30),
            Status = Communicarion.Enums.StatusType.Andamento
        };
    }
}
