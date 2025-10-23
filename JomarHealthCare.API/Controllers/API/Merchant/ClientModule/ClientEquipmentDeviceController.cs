using JomarHealthCare.Application.CQRS.Client.Commands.EquipmentDevice;
using JomarHealthCare.Application.CQRS.Client.Queries.EquipmentDevice;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientEquipmentDeviceController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientEquipmentDeviceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddClientEquipmentDeviceCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateClientEquipmentDeviceCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientEquipmentDeviceCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetClientEquipmentDeviceByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetAllClientEquipmentDeviceByClientQuery(id));
        return Ok(result);
    }
}
