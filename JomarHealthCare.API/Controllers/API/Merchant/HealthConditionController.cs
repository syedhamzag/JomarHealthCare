using JomarHealthCare.Application.CQRS.HealthCondition.Commands;
using JomarHealthCare.Application.CQRS.HealthCondition.Queries;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class HealthConditionController : ControllerBase
{
    private readonly IMediator _mediator;
    public HealthConditionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllHealthConditionQuery());
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddHealthConditionCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateHealthConditionCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteHealthConditionCommand { HCId = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetHealthConditionByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllHealthConditionByCompanyIdIdQuery(id));
        return Ok(result);
    }
}
