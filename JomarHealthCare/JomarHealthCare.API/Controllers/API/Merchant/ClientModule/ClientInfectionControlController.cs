using JomarHealthCare.Application.CQRS.Client.Commands.Infection;
using JomarHealthCare.Application.CQRS.Client.Queries.Infection;
using JomarHealthCare.Application.DataModels.Client.Infection;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientInfectionControlController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientInfectionControlController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientInfectionControlDataModel>> Create([FromBody] ClientInfectionControlDataModel model)
    {
        var result = await _mediator.Send(new CreateInfectionControlCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientInfectionControlDataModel model)
    {
        var result = await _mediator.Send(new UpdateInfectionControlCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientInfectionControlQuery(id));
        return Ok(result);
    }
}
