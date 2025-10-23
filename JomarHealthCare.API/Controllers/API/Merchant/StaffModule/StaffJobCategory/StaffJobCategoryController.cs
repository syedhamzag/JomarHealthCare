using JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;

namespace JomarHealthCare.API.Controllers.API.Merchant.StaffModule.StaffJobCategory;

[Route("api/[controller]")]
[ApiController]
public class StaffJobCategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public StaffJobCategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllJobCategoryQuery());
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AddJobCategoryCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateJobCategoryCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteJobCategoryCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetJobCategoryByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllJobCategoryCompanyIdQuery(id));
        return Ok(result);
    }
}
