namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffWorkTeamController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffWorkTeamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffWorkTeamDataModel>> Create([FromBody] StaffWorkTeamDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffWorkTeamCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StaffWorkTeamDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffWorkTeamCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffWorkTeamCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(); // OData handled elsewhere
        }
    }

}
