using JomarHealthCare.Application.CQRS.Client.Commands.Interest;
using JomarHealthCare.Application.CQRS.Client.Queries.Interest;
using JomarHealthCare.Application.DataModels.Client.BestInterest;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientBestInterestController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientBestInterestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<BestInterestDataModel>> Create([FromBody] BestInterestDataModel model)
    {
        var result = await _mediator.Send(new CreateClientBestInterestCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] BestInterestDataModel model)
    {
        var result = await _mediator.Send(new UpdateClientBestInterestCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientBestInterestQuery(id));
        return Ok(result);
    }
}
