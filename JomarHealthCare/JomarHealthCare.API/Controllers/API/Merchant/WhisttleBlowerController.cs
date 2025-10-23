using JomarHealthCare.Application.CQRS.WhisttleBlowers.Commands;
using JomarHealthCare.Application.CQRS.WhisttleBlowers.Queries;
using JomarHealthCare.Application.DataModels.WhisttleBlowers;


namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class WhisttleBlowerController : ControllerBase
{
    private readonly IMediator _mediator;
    public WhisttleBlowerController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] WhisttleBlowerDataModel command)
    {
        var WhisttleBlowers = await _mediator.Send(new AddWhisttleBlowerCommand(command));
        return Ok(WhisttleBlowers);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] WhisttleBlowerDataModel command)
    {
        var updated = await _mediator.Send(new UpdateWhisttleBlowerCommand(command));
        return updated ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteWhisttleBlowerCommand(id));
        return result ? NoContent() : NotFound();
    }
    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetWhisttleBlowerByIdQuery(id));
        return Ok(result);
    }
    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllWhisttleBlowerByIdQuery(id));
        return Ok(result);
    }
}
