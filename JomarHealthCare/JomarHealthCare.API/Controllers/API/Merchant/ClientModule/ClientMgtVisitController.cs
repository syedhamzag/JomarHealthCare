using JomarHealthCare.Application.CQRS.Client.Commands.Management;
using JomarHealthCare.Application.CQRS.Client.Queries.Management;
using JomarHealthCare.Application.DataModels.Management;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientMgtVisitController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientMgtVisitController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientMgtVisitDataModel>> Create([FromBody] ClientMgtVisitDataModel model)
    {
        var result = await _mediator.Send(new CreateMgtVisitCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientMgtVisitDataModel model)
    {
        var result = await _mediator.Send(new UpdateMgtVisitCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteMgtVisitCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdClientMgtVisitQuery(id));
        return Ok(result);
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientMgtVisitQuery(id));
        return Ok(result);
    }
}
