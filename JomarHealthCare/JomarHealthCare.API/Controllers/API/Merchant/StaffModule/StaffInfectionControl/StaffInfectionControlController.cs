namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffInfectionControlController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffInfectionControlController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffInfectionControlDataModel>> Create([FromBody] StaffInfectionControlDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffInfectionControlCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StaffInfectionControlDataModel model)
        {
            var success = await _mediator.Send(new UpdateStaffInfectionControlCommand(model));
            return success ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _mediator.Send(new DeleteStaffInfectionControlCommand(id));
            return success ? Ok() : NotFound();
        }

    }
}
