using JomarHealthCare.Application.CQRS.Client.Commands.HospitalExit;
using JomarHealthCare.Application.CQRS.Client.Queries.HospitalExit;
using JomarHealthCare.Application.DataModels.Client.HospitalExit;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientHospitalExitController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientHospitalExitController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<HospitalExitDataModel>> Create([FromBody] HospitalExitDataModel model)
    {
        var result = await _mediator.Send(new CreateHospitalExitCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] HospitalExitDataModel model)
    {
        var result = await _mediator.Send(new UpdateHospitalExitCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteHospitalExitCommand { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdClienHospitalExitQuery(id));
        return Ok(result);
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientHospitalExitQuery(id));
        return Ok(result);
    }
}
