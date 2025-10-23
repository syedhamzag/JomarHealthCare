using JomarHealthCare.Application.CQRS.Client.Commands.ClientDailyTask;
using JomarHealthCare.Application.CQRS.Client.Queries.ClientDailyTask;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientDailyTaskController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientDailyTaskController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _mediator.Send(new GetAllDailyTaskByClientIdQuery(id));
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddClientDailyTaskCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateClientDailyTaskCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientDailyTaskCommand { DailyTaskId = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetClientDailyTaskByIdQuery(id));
        return Ok(result);
    }
}
