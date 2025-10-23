using JomarHealthCare.Application.CQRS.Client.Commands.ClientHobbies;
using JomarHealthCare.Application.CQRS.Client.Queries.ClientHobbies;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientHobbyController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientHobbyController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddClientHobbiesListCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientHobbiesCommand { Id = id });
        return result ? NoContent() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetClientHobbiesByClientIdQuery(id));
        return Ok(result);
    }
}
