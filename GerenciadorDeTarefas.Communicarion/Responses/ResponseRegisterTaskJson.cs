using GerenciadorDeTarefas.Communicarion.Enums;

namespace GerenciadorDeTarefas.Communicarion.Responses;
public class ResponseRegisterTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public StatusType Status { get; set; }
}
