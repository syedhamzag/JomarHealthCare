using JomarHealthCare.Application.CQRS.Careplan.Commands.HealthLiving;
using JomarHealthCare.Application.CQRS.Careplan.Queries.HealthLiving;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class HealthLivingController : ControllerBase
{
    private readonly IMediator _mediator;
    public HealthLivingController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<HealthAndLivingDataModel>> Create([FromBody] HealthAndLivingDataModel model)
    {
        var result = await _mediator.Send(new CreateHealthAndLivingCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] HealthAndLivingDataModel model)
    {
        var result = await _mediator.Send(new UpdateHealthAndLivingCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientHealtAndLivingQuery(id));
        return Ok(result);
    }
}
