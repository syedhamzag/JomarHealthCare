using JomarHealthCare.Application.CQRS.Careplan.Commands.Congnitive;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Congnitive;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientCongnitiveController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientCongnitiveController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CongnitiveDataModel>> Create([FromBody] CongnitiveDataModel model)
    {
        var result = await _mediator.Send(new CreateCongnitiveCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] CongnitiveDataModel model)
    {
        var result = await _mediator.Send(new UpdateCongnitiveCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientCongnitiveQuery(id));
        return Ok(result);
    }
}
