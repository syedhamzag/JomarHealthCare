using JomarHealthCare.Application.CQRS.Careplan.Commands.PhysicalAbility;
using JomarHealthCare.Application.CQRS.Careplan.Queries.PhysicalAbility;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientPhysicalAbilityController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientPhysicalAbilityController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<PhysicalAbilityDataModel>> Create([FromBody] List<PhysicalAbilityDataModel> model)
    {
        var result = await _mediator.Send(new CreatePhysicalAbilityCommand(model));
        return Ok(result);
    }

    //[HttpPut]
    //public async Task<ActionResult> Update([FromBody] PhysicalAbilityDataModel model)
    //{
    //    var result = await _mediator.Send(new UpdatePhysicalAbilityCommand(model));
    //    return result ? Ok() : NotFound();
    //}


    //[HttpDelete("{id:int}")]
    //public async Task<IActionResult> Delete(int id)
    //{
    //    var result = await _mediator.Send(new DeletePhysicalAbilityCommand { Id = id });
    //    return result ? NoContent() : NotFound();
    //}

    //[HttpGet("{id}")]
    //public async Task<IActionResult> GetById(int id)
    //{
    //    var result = await _mediator.Send(new GetByIdPhysicalAbilityQuery(id));
    //    return Ok(result);
    //}


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientPhysicalAbilityQuery(id));
        return Ok(result);
    }
}
