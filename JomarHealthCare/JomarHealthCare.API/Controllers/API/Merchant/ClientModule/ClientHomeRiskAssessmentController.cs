using JomarHealthCare.Application.CQRS.Client.Commands.RiskAssessment;
using JomarHealthCare.Application.CQRS.Client.Queries.ClientHobbies;
using JomarHealthCare.Application.CQRS.Client.Queries.RiskAssessment;
using JomarHealthCare.Application.DataModels.Client.RiskAssessment;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientHomeRiskAssessmentController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientHomeRiskAssessmentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<HomeRiskAssessmentDataModel>> Create([FromBody] HomeRiskAssessmentDataModel model)
    {
        var result = await _mediator.Send(new CreateRiskAssessmentCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] HomeRiskAssessmentDataModel model)
    {
        var result = await _mediator.Send(new UpdateRiskAssessmentCommand(model));
        return result ? Ok() : NotFound();
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetAllHomeRiskAssessmentByClientQuery(id));
        return Ok(result);
    }
}
