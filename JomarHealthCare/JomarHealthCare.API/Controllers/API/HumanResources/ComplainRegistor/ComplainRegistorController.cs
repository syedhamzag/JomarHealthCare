using JomarHealthCare.Application.CQRS.HumanResourcesModule.Commands.ComplainRegister;
using JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;

namespace JomarHealthCare.API.Controllers.API.HumanResources.ComplainRegistor;

[Route("api/HumanResources/[controller]")]
[ApiController]
public class ComplainRegistorController : ControllerBase
{
    private readonly IMediator _mediator;

    public ComplainRegistorController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ComplainRegistorDataModel>> Create([FromBody] ComplainRegistorDataModel model)
    {
        var result = await _mediator.Send(new CreateComplainRegisterCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ComplainRegistorDataModel model)
    {
        var result = await _mediator.Send(new UpdateComplainRegisterCommand(model));
        return result ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteComplainRegisterCommand { Id = id });
        return result ? Ok() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdComplainRegisterQuery(id));
        return Ok(result);
    }


    [HttpGet("GetByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetByCompanyComplainRegisterQuery(id));
        return Ok(result);
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientComplainRegisterQuery(id));
        return Ok(result);
    }
}
