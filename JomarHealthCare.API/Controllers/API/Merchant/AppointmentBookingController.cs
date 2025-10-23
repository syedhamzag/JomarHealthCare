using JomarHealthCare.Application.CQRS.AppointmentBookings.Commands;
using JomarHealthCare.Application.DataModels.AppointmentBookings;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/[controller]")]
[ApiController]
public class AppointmentBookingController : ControllerBase
{
    private readonly IMediator _mediator;
    public AppointmentBookingController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AppointmentBookingDataModel command)
    {
        var TaskBoards = await _mediator.Send(new CreateAppointmentBookingCommand(command));
        return Ok(TaskBoards);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] AppointmentBookingDataModel command)
    {
        var updated = await _mediator.Send(new UpdateAppointmentBookingCommand(command));
        return updated ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteAppointmentBookingCommand(id));
        return result ? NoContent() : NotFound();
    }
}
