using JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;

namespace JomarHealthCare.API.Controllers.API.Merchant.StaffModule.StaffJobPosition;

[Route("api/[controller]")]
[ApiController]
public class StaffJobPositionController : ControllerBase
{
    private readonly IMediator _mediator;
    public StaffJobPositionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllJobPositionQuery());
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddJobPositionCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateJobPositionCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteJobPositionCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetJobPositionByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllJobPositionCompanyIdQuery(id));
        return Ok(result);
    }
}
