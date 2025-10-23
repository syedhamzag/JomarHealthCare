using JomarHealthCare.Application.CQRS.Client.Commands.Pet;
using JomarHealthCare.Application.CQRS.Client.Queries.Pet;
using JomarHealthCare.Application.DataModels.Pet;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientPetController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientPetController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientPetDataModel>> Create([FromBody] ClientPetDataModel model)
    {
        var result = await _mediator.Send(new CreateClientPetCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientPetDataModel model)
    {
        var result = await _mediator.Send(new UpdateClientPetCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientPetQuery(id));
        return Ok(result);
    }
}
