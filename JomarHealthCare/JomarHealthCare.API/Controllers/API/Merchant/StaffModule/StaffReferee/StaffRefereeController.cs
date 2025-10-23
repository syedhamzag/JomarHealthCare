namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/staff/[controller]")]
[ApiController]
public class StaffRefereeController : ControllerBase
{
    private readonly IMediator _mediator;

    public StaffRefereeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<StaffRefereeDataModel>> Create([FromBody] StaffRefereeDataModel model)
    {
        var result = await _mediator.Send(new CreateStaffRefereeCommand(model));
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] StaffRefereeDataModel model)
    {
        var updated = await _mediator.Send(new UpdateStaffRefereeCommand(model));
        return updated ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var deleted = await _mediator.Send(new DeleteStaffRefereeCommand(id));
        return deleted ? Ok() : NotFound();
    }
}
