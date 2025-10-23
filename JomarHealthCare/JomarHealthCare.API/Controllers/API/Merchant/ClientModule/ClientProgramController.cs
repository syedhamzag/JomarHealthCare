using JomarHealthCare.Application.CQRS.Client.Commands.Program;
using JomarHealthCare.Application.CQRS.Client.Queries.Program;
using JomarHealthCare.Application.DataModels.Client.Program;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientProgramController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientProgramController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientProgramDataModel>> Create([FromBody] ClientProgramDataModel model)
    {
        var result = await _mediator.Send(new CreateClientProgramCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientProgramDataModel model)
    {
        var result = await _mediator.Send(new UpdateClientProgramCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientProgramCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdClientProgramQuery(id));
        return Ok(result);
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientProgramQuery(id));
        return Ok(result);
    }
}
