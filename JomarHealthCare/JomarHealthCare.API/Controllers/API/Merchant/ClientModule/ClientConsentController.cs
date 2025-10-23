using JomarHealthCare.Application.CQRS.Careplan.Commands.Consent;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Consent;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientConsentController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientConsentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ConsentDataModel>> Create([FromBody] ConsentDataModel model)
    {
        var result = await _mediator.Send(new CreateConsentDataCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ConsentDataModel model)
    {
        var result = await _mediator.Send(new UpdateConsentDataCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientConsentDataQuery(id));
        return Ok(result);
    }
}
