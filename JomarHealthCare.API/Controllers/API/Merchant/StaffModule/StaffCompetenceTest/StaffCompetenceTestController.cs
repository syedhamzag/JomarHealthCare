namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffCompetenceTestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffCompetenceTestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffCompetenceTestDataModel>> Create([FromBody] StaffCompetenceTestDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffCompetenceTestCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffCompetenceTestDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffCompetenceTestCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffCompetenceTestCommand(id));
            return result ? Ok() : NotFound();
        }
    }

}
