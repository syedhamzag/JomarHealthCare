using JomarHealthCare.Application.CQRS.Client.Commands.Nutrition;
using JomarHealthCare.Application.CQRS.Client.Queries.Nutrition;
using JomarHealthCare.Application.DataModels.Client.Nutrition;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientNutritionController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientNutritionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClientNutritionDataModel>> Create([FromBody] ClientNutritionDataModel model)
    {
        var result = await _mediator.Send(new CreateClientNutritionCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ClientNutritionDataModel model)
    {
        var result = await _mediator.Send(new UpdateClientNutritionCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientIdNutritionQuery(id));
        return Ok(result);
    }
}
