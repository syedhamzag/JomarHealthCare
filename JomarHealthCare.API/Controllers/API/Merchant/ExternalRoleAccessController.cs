using JomarHealthCare.Application.CQRS.ExternalUser.Commands;
using JomarHealthCare.Application.CQRS.ExternalUser.Queries;
using JomarHealthCare.Application.DataModels.ExternalUser;


namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class ExternalRoleAccessController : ControllerBase
{
    private readonly IMediator _mediator;
    public ExternalRoleAccessController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ExternalRoleAccessDataModel command)
    {
        var ExternalUsers = await _mediator.Send(new AddExternalRoleAccessCommand(command));
        return Ok(ExternalUsers);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ExternalRoleAccessDataModel command)
    {
        var updated = await _mediator.Send(new UpdateExternalRoleAccessCommand(command));
        return updated ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteExternalRoleAccessCommand(id));
        return result ? NoContent() : NotFound();
    }
    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetExternalRoleAccessByIdQuery(id));
        return Ok(result);
    }
    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllExternalRoleAccessByIdQuery(id));
        return Ok(result);
    }
}
