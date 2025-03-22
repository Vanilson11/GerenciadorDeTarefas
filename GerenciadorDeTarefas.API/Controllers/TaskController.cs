using GerenciadorDeTarefas.Application.UsesCases.Tasks.Delete;
using GerenciadorDeTarefas.Application.UsesCases.Tasks.GetAll;
using GerenciadorDeTarefas.Application.UsesCases.Tasks.GetById;
using GerenciadorDeTarefas.Application.UsesCases.Tasks.Register;
using GerenciadorDeTarefas.Application.UsesCases.Tasks.Update;
using GerenciadorDeTarefas.Communicarion.Requests;
using GerenciadorDeTarefas.Communicarion.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;

[Route("[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTasksUseCase();
        var response = useCase.Execute();

        if(response.Tasks.Any()) return Ok(response); ;

        return NotFound();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);

        if(response == null) return NotFound();

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        //response: se for true, retorna NoContent. Senão, retorna NotFound
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteTaskUseCase();
        useCase.Execute(id);

        return NoContent();
    }
}
