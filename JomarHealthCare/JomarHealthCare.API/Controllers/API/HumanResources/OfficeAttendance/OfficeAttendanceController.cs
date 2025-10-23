using JomarHealthCare.Application.DataModels.HumanResourcesModule;
using JomarHealthCare.Application.Validators.HumanResourcesModule;

namespace JomarHealthCare.API.Controllers.API.HumanResources.ComplainRegistor
{
    [Route("api/HumanResources/[controller]")]
    [ApiController]
    public class OfficeAttendanceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OfficeAttendanceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<OfficeAttendanceDataModel>> Create([FromBody] OfficeAttendanceDataModel model)
        {
            var result = await _mediator.Send(new CreateOfficeAttendanceCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] OfficeAttendanceDataModel model)
        {
            var result = await _mediator.Send(new UpdateOfficeAttendanceCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteOfficeAttendanceCommand(id));
            return result ? Ok() : NotFound();
        }
    }
}
