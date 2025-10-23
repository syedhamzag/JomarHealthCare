namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffAdlObsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffAdlObsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffAdlObsDataModel>> Create([FromBody] StaffAdlObsDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffAdlObsCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffAdlObsDataModel model)
        {
            var updated = await _mediator.Send(new UpdateStaffAdlObsCommand(model));
            return updated ? Ok() : NotFound();
        }

        [HttpDelete("{observationID}")]
        public async Task<ActionResult> Delete(int observationID)
        {
            var deleted = await _mediator.Send(new DeleteStaffAdlObsCommand(observationID));
            return deleted ? Ok() : NotFound();
        }
    }

}
