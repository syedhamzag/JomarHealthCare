using JomarHealthCare.Application.CQRS.Careplan.Commands.KeyIndicator;
using JomarHealthCare.Application.CQRS.Careplan.Queries.KeyIndicator;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientKeyIndicatorController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientKeyIndicatorController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<KeyIndicatorDataModel>> Create([FromBody] KeyIndicatorDataModel model)
    {
        var result = await _mediator.Send(new CreateKeyIndicatorCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] KeyIndicatorDataModel model)
    {
        var result = await _mediator.Send(new UpdateKeyIndicatorCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientKeyIndicatorQuery(id));
        return Ok(result);
    }
}
