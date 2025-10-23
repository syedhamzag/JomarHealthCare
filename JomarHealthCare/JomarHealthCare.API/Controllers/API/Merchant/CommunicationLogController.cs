using JomarHealthCare.Application.CQRS.CommunicationLogs.Commands;
using JomarHealthCare.Application.DataModels.CommunicationLogs;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class CommunicationLogController : ControllerBase
{
    private readonly IMediator _mediator;
    public CommunicationLogController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CommunicationLogDataModel command)
    {
       var result = await _mediator.Send(new CreateCommunicationLogCommand(command));
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] CommunicationLogDataModel command)
    {
        var updated = await _mediator.Send(new UpdateCommunicationLogCommand(command));
        return updated ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteCommunicationLogCommand(id));
        return result ? NoContent() : NotFound();
    }
}
