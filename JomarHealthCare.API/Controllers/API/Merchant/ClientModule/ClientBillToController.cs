using JomarHealthCare.Application.CQRS.Client.Commands.BillTo;
using JomarHealthCare.Application.CQRS.Client.Queries.BillTo;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientBillToController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientBillToController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateClientBillToCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateClientBillToCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientBillToCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetClientBillToByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetAllClientBillToByClientQuery(id));
        return Ok(result);
    }
}
