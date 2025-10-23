using JomarHealthCare.Application.CQRS.Careplan.Commands.MentalHealth;
using JomarHealthCare.Application.CQRS.Careplan.Queries.MentalHealth;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientMentalHealthController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientMentalHealthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<MentalHealthSupportDataModel>> Create([FromBody] MentalHealthSupportDataModel model)
    {
        var result = await _mediator.Send(new CreateMentalHealthCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] MentalHealthSupportDataModel model)
    {
        var result = await _mediator.Send(new UpdateMentalHealthCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientMentalHealthQuery(id));
        return Ok(result);
    }
}
