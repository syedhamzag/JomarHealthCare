namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffEmergencyContactController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffEmergencyContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffEmergencyContactDataModel>> Create([FromBody] StaffEmergencyContactDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffEmergencyContactCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffEmergencyContactDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffEmergencyContactCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffEmergencyContactCommand(id));
            return result ? Ok() : NotFound();
        }
    }

}
