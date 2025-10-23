using JomarHealthCare.Application.CQRS.Careplan.Commands.OralCares;
using JomarHealthCare.Application.CQRS.Careplan.Queries.OralCares;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientOralCareController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientOralCareController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<OralCareDataModel>> Create([FromBody] OralCareDataModel model)
    {
        var result = await _mediator.Send(new CreateOralCareCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] OralCareDataModel model)
    {
        var result = await _mediator.Send(new UpdateOralCareCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientOralCareQuery(id));
        return Ok(result);
    }
}
