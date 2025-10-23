using JomarHealthCare.Application.CQRS.Hobby.Commands;
using JomarHealthCare.Application.CQRS.Hobby.Queries;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class HobbyController : ControllerBase
{
    
    private readonly IMediator _mediator;
    public HobbyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllHobbyQuery());
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddHobbyCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateHobbyCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteHobbyCommand { HobbyId = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetHobbyByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllHobbyByCompanyIdQuery(id));
        return Ok(result);
    }
}
