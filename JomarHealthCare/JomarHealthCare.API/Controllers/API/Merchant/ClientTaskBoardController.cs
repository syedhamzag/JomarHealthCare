using JomarHealthCare.Application.CQRS.TaskBoards.Commands;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;


namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class ClientTaskBoardController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientTaskBoardController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ClientTaskBoardDataModel command)
    {
        var TaskBoards = await _mediator.Send(new CreateTaskBoardCommand(command));
        return Ok(TaskBoards);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ClientTaskBoardDataModel command)
    {
        var updated = await _mediator.Send(new UpdateTaskBoardCommand(command));
        return updated ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteTaskBoardCommand(id));
        return result ? NoContent() : NotFound();
    }
}
