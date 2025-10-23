using JomarHealthCare.Application.CQRS.Client.Commands.InterestObjective;
using JomarHealthCare.Application.CQRS.Client.Queries.InterestObjective;
using JomarHealthCare.Application.DataModels.Client.InterestObjective;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientInterestObjectiveController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientInterestObjectiveController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientInterestAndObjectiveDataModel>> Create([FromBody] ClientInterestAndObjectiveDataModel model)
    {
        var result = await _mediator.Send(new CreateInterestAndObjectiveCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientInterestAndObjectiveDataModel model)
    {
        var result = await _mediator.Send(new UpdateInterestAndObjectiveCommand(model));
        return result ? Ok() : NotFound();
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetAllInterestAndObjectiveByClientQuery(id));
        return Ok(result);
    }
}
