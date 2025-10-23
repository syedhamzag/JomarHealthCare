namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffShadowingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffShadowingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffShadowingDataModel>> Create([FromBody] StaffShadowingDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffShadowingCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffShadowingDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffShadowingCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffShadowingCommand(id));
            return result ? Ok() : NotFound();
        }
    }

}
