using JomarHealthCare.Application.CQRS.Client.Commands.Rotering.Rotas;
using JomarHealthCare.Application.CQRS.Client.Queries.Rotering.Rotas;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule.Rotering;

[Route("api/[controller]")]
[ApiController]
public class RotaController : ControllerBase
{
    private readonly IMediator _mediator;
    public RotaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<RotaDataModel>> Create([FromBody] RotaDataModel model)
    {
        var result = await _mediator.Send(new CreateRotaCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] RotaDataModel model)
    {
        var result = await _mediator.Send(new UpdateRotaCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetAllByCompanyId/{id:Guid}")]
    public async Task<IActionResult> GetAllByCompanyId(Guid id)
    {
        var result = await _mediator.Send(new GetAllByCompanyRotaQuery(id));
        return Ok(result);
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetByIdRotaQuery(id));
        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteRotaCommand { Id = id });
        return result ? NoContent() : NotFound();
    }
}
