using JomarHealthCare.Application.CQRS.Careplan.Commands.Capacity;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Capacity;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientCapacityController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientCapacityController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CapacityDataModel>> Create([FromBody] CapacityDataModel model)
    {
        var result = await _mediator.Send(new CreateCapacityCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] CapacityDataModel model)
    {
        var result = await _mediator.Send(new UpdateCapacityCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientCapacityQuery(id));
        return Ok(result);
    }
}
