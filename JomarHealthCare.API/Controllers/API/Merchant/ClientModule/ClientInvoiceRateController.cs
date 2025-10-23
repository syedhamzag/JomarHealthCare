using JomarHealthCare.Application.CQRS.Client.Commands.InvoiceRate;
using JomarHealthCare.Application.CQRS.Client.Queries.InvoiceRate;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientInvoiceRateController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientInvoiceRateController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateClientInvoiceRateCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateClientInvoiceRateCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientInvoiceRateCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetClientInvoiceRateByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetAllClientInvoiceRateByClientQuery(id));
        return Ok(result);
    }
}
