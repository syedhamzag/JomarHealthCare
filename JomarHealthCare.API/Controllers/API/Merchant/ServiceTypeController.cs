using JomarHealthCare.Application.CQRS.AreaCodes.Commands;
using JomarHealthCare.Application.CQRS.ServiceTypes.Commands;
using JomarHealthCare.Application.CQRS.ServiceTypes.Queries;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class ServiceTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public ServiceTypeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllServiceTypeQuery());
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddServiceTypeCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateServiceTypeCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteAreaCodeCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetServiceTypeByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllServiceTypeCompanyIdQuery(id));
        return Ok(result);
    }
}
