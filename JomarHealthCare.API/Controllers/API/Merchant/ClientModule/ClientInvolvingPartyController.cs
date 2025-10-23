using JomarHealthCare.Application.CQRS.Client.Commands.InvolvingParty;
using JomarHealthCare.Application.CQRS.Client.Queries.InvolvingParty;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientInvolvingPartyController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientInvolvingPartyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddClientInvolvingPartyCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateClientInvolvingPartyCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientInvolvingPartyCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetClientInvolvingPartyByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetAllClientInvolvingPartyByClientQuery(id));
        return Ok(result);
    }
}
