using JomarHealthCare.Application.CQRS.Careplan.Commands.Hygiene;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Hygiene;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientHygieneController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientHygieneController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<PersonalHygieneDataModel>> Create([FromBody] PersonalHygieneDataModel model)
    {
        var result = await _mediator.Send(new CreatePersonalHygieneCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] PersonalHygieneDataModel model)
    {
        var result = await _mediator.Send(new UpdatePersonalHygieneCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientPersonalHygieneQuery(id));
        return Ok(result);
    }
}
