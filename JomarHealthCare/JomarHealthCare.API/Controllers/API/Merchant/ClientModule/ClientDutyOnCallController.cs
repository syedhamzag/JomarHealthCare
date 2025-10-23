using JomarHealthCare.Application.CQRS.Client.Commands.DutyOnCall;
using JomarHealthCare.Application.CQRS.Client.Queries.DutyOnCall;
using JomarHealthCare.Application.DataModels.Client.DutyOnCall;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientDutyOnCallController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientDutyOnCallController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<DutyOnCallDataModel>> Create([FromBody] DutyOnCallDataModel model)
    {
        var result = await _mediator.Send(new CreateDutyOnCallCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] DutyOnCallDataModel model)
    {
        var result = await _mediator.Send(new UpdateDutyOnCallCommand(model));
        return result ? Ok() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteDutyOnCallCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetClientDutyOnCallByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetAllDutyOnCallByClientQuery(id));
        return Ok(result);
    }
}
