using JomarHealthCare.Application.CQRS.Careplan.Commands.HistoryFall;
using JomarHealthCare.Application.CQRS.Careplan.Queries.HistoryFall;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientHistoryOfFallController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientHistoryOfFallController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<HistoryOfFallDataModel>> Create([FromBody] HistoryOfFallDataModel model)
    {
        var result = await _mediator.Send(new CreateHistoryOfFallCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] HistoryOfFallDataModel model)
    {
        var result = await _mediator.Send(new UpdateHistoryOfFallCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientHistoryOfFallQuery(id));
        return Ok(result);
    }
}
