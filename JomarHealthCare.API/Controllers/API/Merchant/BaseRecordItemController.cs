using JomarHealthCare.Application.CQRS.BaseRecordItem.Commands;
using JomarHealthCare.Application.CQRS.BaseRecordItem.Queries;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class BaseRecordItemController : ControllerBase
{
    private readonly IMediator _mediator;
    public BaseRecordItemController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAllBaseRecordItemQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBaseRecordItemCommand command)
    {
        var clients = await _mediator.Send(command);
        return Ok(clients);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBaseRecordItemCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteBaseRecordItemCommand { BaseRecordItemId = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetBaseRecordItemByIdQuery(id));
        return Ok(result);
    }

    [HttpGet("GetEquipmentList/{id:int}")]
    public async Task<IActionResult> GetEquipmentList(int id)
    {
        var result = await _mediator.Send(new GetAllBaseRecordItemByBaseIdQuery(id));
        return Ok(result);
    }
}
