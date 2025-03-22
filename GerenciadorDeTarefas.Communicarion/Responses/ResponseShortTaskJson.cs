using GerenciadorDeTarefas.Communicarion.Enums;

namespace GerenciadorDeTarefas.Communicarion.Responses;
public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; }
}
