using JomarHealthCare.Application.CQRS.Client.Commands.Rotering.ClientRota;
using JomarHealthCare.Application.CQRS.Client.Queries.Rotering.ClientRota;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule.Rotering;

[Route("api/[controller]")]
[ApiController]
public class ClientRotaController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientRotaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<List<ClientRotaDataModel>>> Create([FromBody] List<ClientRotaDataModel> model)
    {
        var result = await _mediator.Send(new CreateClientRotaCommand(model));
        return Ok(result);
    }

    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByIdClientRotaQuery(id));
        return Ok(result);
    }
}
