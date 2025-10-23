using JomarHealthCare.Application.CQRS.Careplan.Commands.Balance;
using JomarHealthCare.Application.CQRS.Careplan.Queries.Balance;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.API.Controllers.API.Merchant.ClientModule;

[Route("api/Client/[controller]")]
[ApiController]
public class ClientBalanceController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientBalanceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<BalanceDataModel>> Create([FromBody] List<BalanceDataModel> model)
    {
        var result = await _mediator.Send(new CreateBalanceCommand(model));
        return Ok(result);
    }

    //[HttpPut]
    //public async Task<ActionResult> Update([FromBody] BalanceDataModel model)
    //{
    //    var result = await _mediator.Send(new UpdateBalanceCommand(model));
    //    return result ? Ok() : NotFound();
    //}


    //[HttpDelete("{id:int}")]
    //public async Task<IActionResult> Delete(int id)
    //{
    //    var result = await _mediator.Send(new DeleteBalanceCommand { Id = id });
    //    return result ? NoContent() : NotFound();
    //}

    //[HttpGet("{id}")]
    //public async Task<IActionResult> GetById(int id)
    //{
    //    var result = await _mediator.Send(new GetByIdBalanceQuery(id));
    //    return Ok(result);
    //}


    [HttpGet("GetByClientId/{id:Guid}")]
    public async Task<IActionResult> GetByClientId(Guid id)
    {
        var result = await _mediator.Send(new GetByClientBalanceQuery(id));
        return Ok(result);
    }
}
