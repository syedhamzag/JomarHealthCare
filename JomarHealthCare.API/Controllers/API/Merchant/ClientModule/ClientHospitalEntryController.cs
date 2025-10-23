using JomarHealthCare.Application.CQRS.Client.Commands.HospitalEntry;
using JomarHealthCare.Application.CQRS.Client.Queries.HospitalEntry;
using JomarHealthCare.Application.DataModels.client.HospitalEntry;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientHospitalEntryController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientHospitalEntryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<HospitalEntryDataModel>> Create([FromBody] HospitalEntryDataModel model)
    {
        var result = await _mediator.Send(new CreateHospitalEnteryCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] HospitalEntryDataModel model)
    {
        var result = await _mediator.Send(new UpdateHospitalEnteryCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteHospitalEnteryCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdClienHospitalEntryQuery(id));
        return Ok(result);
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientHospitalEntryQuery(id));
        return Ok(result);
    }
}
