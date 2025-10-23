using JomarHealthCare.Application.CQRS.Client.Commands;
using JomarHealthCare.Application.CQRS.Client.Queries;
using JomarHealthCare.Application.DataModels.Client;
using Newtonsoft.Json;


namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateClientCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateClientDataModel command)
    {
        var model = JsonConvert.DeserializeObject<ClientForUpdateDataModel>(command.data);

        var responseData = await _mediator.Send(new UpdateClientPersonalInfoCommand(model, model.ClientId));

        return Ok(new
        {
            Status = true,
            ResponseMessage = "ACTION SUCCESS",
            Data = responseData
        });
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _mediator.Send(new DeleteClientCommand { ClientId = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllClientQuery());
        return Ok(result);
    }

    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllClientCompanyIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetClientDetailByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetForUpdateByClientId/{id:Guid}")]
    public async Task<IActionResult> GetForUpdateByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetClientForUpdateByIdQuery(id));
        return Ok(result);
    }
}
