namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffHealthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffHealthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffHealthDataModel>> Create([FromBody] StaffHealthDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffHealthCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffHealthDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffHealthCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffHealthCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(); // OData endpoint handled elsewhere
        }
    }

}
