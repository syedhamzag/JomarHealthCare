using JomarHealthCare.Application.CQRS.Client.Commands.ServiceWatch;
using JomarHealthCare.Application.CQRS.Client.Queries.ServiceWatch;
using JomarHealthCare.Application.DataModels.Watch;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientServiceWatchController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientServiceWatchController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientServiceWatchDataModel>> Create([FromBody] ClientServiceWatchDataModel model)
    {
        var result = await _mediator.Send(new CreateServiceWatchCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientServiceWatchDataModel model)
    {
        var result = await _mediator.Send(new UpdateServiceWatchCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteServiceWatchCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdClientServiceWatchQuery(id));
        return Ok(result);
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientServiceWatchQuery(id));
        return Ok(result);
    }
}
