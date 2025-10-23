using JomarHealthCare.Application.CQRS.Careplan.Commands.Keyworker;
using JomarHealthCare.Application.CQRS.Careplan.Queries.keyworker;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientKeyworkerController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientKeyworkerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<KeyworkerDataModel>> Create([FromBody] KeyworkerDataModel model)
    {
        var result = await _mediator.Send(new CreateKeyworkerCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] KeyworkerDataModel model)
    {
        var result = await _mediator.Send(new UpdateKeyworkerCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientKeyworkerQuery(id));
        return Ok(result);
    }
}
