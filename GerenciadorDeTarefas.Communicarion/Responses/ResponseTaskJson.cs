using GerenciadorDeTarefas.Communicarion.Enums;

namespace GerenciadorDeTarefas.Communicarion.Responses;
public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public DateTime DateLimit { get; set; }
    public StatusType Status { get; set; }
}
