using JomarHealthCare.Application.CQRS.Careplan.Commands.Nutrition;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Nutrition;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class CareplanNutritionController : ControllerBase
{
    private readonly IMediator _mediator;
    public CareplanNutritionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CarePlanNutritionDataModel>> Create([FromBody] CarePlanNutritionDataModel model)
    {
        var result = await _mediator.Send(new CreateNutritionCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] CarePlanNutritionDataModel model)
    {
        var result = await _mediator.Send(new UpdateNutritionCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientCarePlanNutritionQuery(id));
        return Ok(result);
    }
}
