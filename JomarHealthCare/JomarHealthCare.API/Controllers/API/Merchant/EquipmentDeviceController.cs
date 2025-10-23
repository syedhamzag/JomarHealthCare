using JomarHealthCare.Application.CQRS.EquipmentDevice.Commands;
using JomarHealthCare.Application.CQRS.EquipmentDevice.Queries;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class EquipmentDeviceController : ControllerBase
{
    private readonly IMediator _mediator;
    public EquipmentDeviceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddEquipmentDeviceDataCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateEquipmentDeviceDataCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteEquipmentDeviceDataCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetEquipmentDeviceByIdQuery(id));
        return Ok(result);
    }
}
