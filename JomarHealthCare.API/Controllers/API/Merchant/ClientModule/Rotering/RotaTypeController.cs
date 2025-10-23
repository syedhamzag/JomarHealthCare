using JomarHealthCare.Application.CQRS.AreaCodes.Commands;
using JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaType;
using JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaType;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule.Rotering;

[Route("api/[controller]")]
[ApiController]
public class RotaTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public RotaTypeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientRotaTypeDataModel>> Create([FromBody] ClientRotaTypeDataModel model)
    {
        var result = await _mediator.Send(new CreateRotaTypeCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientRotaTypeDataModel model)
    {
        var result = await _mediator.Send(new UpdateRotaTypeCommand(model));
        return result ? Ok() : NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllRotaTypeQuery());
        return Ok(result);
    }


    [HttpGet("GetAllByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetAllByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllByCompanyIdRotaTypeQuery(id));
        return Ok(result);
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdRotaTypeQuery(id));
        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteRotaTypeCommand { Id = id });
        return result ? NoContent() : NotFound();
    }
}
