using JomarHealthCare.Application.CQRS.Client.Commands.Voice;
using JomarHealthCare.Application.CQRS.Client.Queries.Voice;
using JomarHealthCare.Application.DataModels.Voice;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientVoiceController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientVoiceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientVoiceDataModel>> Create([FromBody] ClientVoiceDataModel model)
    {
        var result = await _mediator.Send(new CreateClientVoiceCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientVoiceDataModel model)
    {
        var result = await _mediator.Send(new UpdateClientVoiceCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientVoiceCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdClientVoiceQuery(id));
        return Ok(result);
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientVoiceQuery(id));
        return Ok(result);
    }
}
