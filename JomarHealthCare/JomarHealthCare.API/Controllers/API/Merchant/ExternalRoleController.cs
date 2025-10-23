using JomarHealthCare.Application.CQRS.ExternalUser.Commands;
using JomarHealthCare.Application.CQRS.ExternalUser.Queries;
using JomarHealthCare.Application.DataModels.ExternalUser;


namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class ExternalRoleController : ControllerBase
{
    private readonly IMediator _mediator;
    public ExternalRoleController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ExternalUserDataModel command)
    {
        var ExternalUsers = await _mediator.Send(new AddExternalUserCommand(command));
        return Ok(ExternalUsers);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ExternalUserDataModel command)
    {
        var updated = await _mediator.Send(new UpdateExternalUserCommand(command));
        return updated ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteExternalUserCommand(id));
        return result ? NoContent() : NotFound();
    }
    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetExternalUserByIdQuery(id));
        return Ok(result);
    }
    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllExternalUserByIdQuery(id));
        return Ok(result);
    }
}
