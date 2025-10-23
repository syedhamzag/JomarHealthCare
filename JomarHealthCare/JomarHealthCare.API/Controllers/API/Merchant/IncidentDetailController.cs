using JomarHealthCare.Application.CQRS.IncidentDetails.Commands;
using JomarHealthCare.Application.CQRS.IncidentDetails.Queries;
using JomarHealthCare.Application.DataModels.IncidentDetails;


namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class IncidentDetailController : ControllerBase
{
    private readonly IMediator _mediator;
    public IncidentDetailController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] IncidentDetailDataModel command)
    {
        var IncidentDetails = await _mediator.Send(new AddIncidentDetailCommand(command));
        return Ok(IncidentDetails);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] IncidentDetailDataModel command)
    {
        var updated = await _mediator.Send(new UpdateIncidentDetailCommand(command));
        return updated ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteIncidentDetailCommand(id));
        return result ? NoContent() : NotFound();
    }
    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetIncidentDetailByIdQuery(id));
        return Ok(result);
    }
    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllIncidentDetailByIdQuery(id));
        return Ok(result);
    }
}
