using JomarHealthCare.Application.CQRS.Careplan.Commands.Centred;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Centred;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientPersonCentredController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientPersonCentredController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<PersonCentredModelData>> Create([FromBody] List<PersonCentredModelData> model)
    {
        var result = await _mediator.Send(new CreatePersonCentredCommand(model));
        return Ok();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientPersonCentredQuery(id));
        return Ok(result);
    }
}
