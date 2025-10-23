using JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaTasks;
using JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaType;
using JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaTasks;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule.Rotering;

[Route("api/[controller]")]
[ApiController]
public class RotaTaskController : ControllerBase
{
    private readonly IMediator _mediator;
    public RotaTaskController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<RotaTaskDataModel>> Create([FromBody] RotaTaskDataModel model)
    {
        var result = await _mediator.Send(new CreateRotaTaskCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] RotaTaskDataModel model)
    {
        var result = await _mediator.Send(new UpdateRotaTaskCommand(model));
        return result ? Ok() : NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllRotaTaskQuery());
        return Ok(result);
    }


    [HttpGet("GetAllByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetAllByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllByCompanyIdRotaTaskQuery(id));
        return Ok(result);
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdRotaTaskQuery(id));
        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteRotaTaskCommand { Id = id });
        return result ? NoContent() : NotFound();
    }
}
