using JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaWeekDay;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule.Rotering;

[Route("api/[controller]")]
[ApiController]
public class RotaDayOfWeekController : ControllerBase
{
    private readonly IMediator _mediator;
    public RotaDayOfWeekController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet()]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllRotaDayOfWeeKQuery());
        return Ok(result);
    }
}
