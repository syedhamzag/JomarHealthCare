using JomarHealthCare.Application.CQRS.Policy.Commands;
using JomarHealthCare.Application.CQRS.Policy.Queries;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class PolicyController : ControllerBase
{
    private readonly IMediator _mediator;
    public PolicyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllPolicyQuery());
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePolicyCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePolicyCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _mediator.Send(new DeletePolicyCommand { PolicyId = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _mediator.Send(new GetPolicyByIdQuery(id));
        return Ok(result);
    }
}
