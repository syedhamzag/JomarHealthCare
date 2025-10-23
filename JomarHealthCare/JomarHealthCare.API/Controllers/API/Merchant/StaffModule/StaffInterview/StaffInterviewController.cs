namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffInterviewController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffInterviewController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffInterviewDataModel>> Create([FromBody] StaffInterviewDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffInterviewCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StaffInterviewDataModel model)
        {
            var success = await _mediator.Send(new UpdateStaffInterviewCommand(model));
            return success ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _mediator.Send(new DeleteStaffInterviewCommand(id));
            return success ? Ok() : NotFound();
        }

    }
}
