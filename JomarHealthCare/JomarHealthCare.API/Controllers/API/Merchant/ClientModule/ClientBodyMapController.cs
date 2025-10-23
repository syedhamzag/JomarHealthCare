using JomarHealthCare.Application.CQRS.Careplan.Commands.BodyMap;
using JomarHealthCare.Application.CQRS.Careplan.Queries.BodyMap;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientBodyMapController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientBodyMapController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<BodyMapDataModel>> Create([FromBody] BodyMapDataModel model)
    {
        var result = await _mediator.Send(new CreateBodyMapCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] BodyMapDataModel model)
    {
        var result = await _mediator.Send(new UpdateBodyMapCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteBodyMapCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdBodyMapQuery(id));
        return Ok(result);
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientBodyMapQuery(id));
        return Ok(result);
    }
}
