using JomarHealthCare.Application.CQRS.Careplan.Commands.Personal;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Personal;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientPersonalController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientPersonalController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<PersonalDataModel>> Create([FromBody] PersonalDataModel model)
    {
        var result = await _mediator.Send(new CreatePersonalCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] PersonalDataModel model)
    {
        var result = await _mediator.Send(new UpdatePersonalCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientPersonalQuery(id));
        return Ok(result);
    }
}
