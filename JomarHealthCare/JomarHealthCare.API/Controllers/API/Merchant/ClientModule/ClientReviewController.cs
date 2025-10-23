using JomarHealthCare.Application.CQRS.Careplan.Commands.Reviews;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Reviews;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientReviewController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientReviewController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ReviewDataModel>> Create([FromBody] ReviewDataModel model)
    {
        var result = await _mediator.Send(new CreateReviewCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ReviewDataModel model)
    {
        var result = await _mediator.Send(new UpdateReviewCommand(model));
        return result ? Ok() : NotFound();
    }


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientReviewQuery(id));
        return Ok(result);
    }
}
