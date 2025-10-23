namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffPersonalityTestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffPersonalityTestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffPersonalityTestDataModel>> Create([FromBody] StaffPersonalityTestDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffPersonalityTestCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffPersonalityTestDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffPersonalityTestCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffPersonalityTestCommand(id));
            return result ? Ok() : NotFound();
        }
    }

}
