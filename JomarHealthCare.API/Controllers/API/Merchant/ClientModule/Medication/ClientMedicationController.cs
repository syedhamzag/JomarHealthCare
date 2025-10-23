using JomarHealthCare.Application.CQRS.Client.Commands.Medication;
using JomarHealthCare.Application.CQRS.Client.Queries.Medication;
using JomarHealthCare.Application.DataModels.Client.Medication;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule.Medication;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientMedicationController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientMedicationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientMedicationDataModel>> Create([FromBody] ClientMedicationDataModel model)
    {
        var result = await _mediator.Send(new CreateClientMedicationCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientMedicationDataModel model)
    {
        var result = await _mediator.Send(new UpdateClientMedicationCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetAllClientMedicationByClientQuery(id));
        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteClientMedicationCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdClientMedicationQuery(id));
        return Ok(result);
    }
}
