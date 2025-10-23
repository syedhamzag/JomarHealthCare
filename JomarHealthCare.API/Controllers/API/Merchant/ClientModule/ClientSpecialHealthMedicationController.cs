using JomarHealthCare.Application.CQRS.Careplan.Commands.SpecialHealthMedication;
using JomarHealthCare.Application.CQRS.Careplan.Queries.SpecialHealthMedication;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientSpecialHealthMedicationController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientSpecialHealthMedicationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<SpecialHealthAndMedicationDataModel>> Create([FromBody] SpecialHealthAndMedicationDataModel model)
    {
        var result = await _mediator.Send(new CreateSpecialHealthMedicationCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] SpecialHealthAndMedicationDataModel model)
    {
        var result = await _mediator.Send(new UpdateSpecialHealthMedicationCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientSpecialHealthMedicationQuery(id));
        return Ok(result);
    }
}
