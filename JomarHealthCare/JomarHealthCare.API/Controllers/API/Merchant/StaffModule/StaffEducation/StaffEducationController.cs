namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffEducationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffEducationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<StaffEducationDataModel>> Create([FromBody] StaffEducationDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffEducationCommand(model));
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<StaffEducationDataModel>>> GetAll()
        {
            var result = await _mediator.Send(new StaffEducationQuery());
            return Ok(result);
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult> Update([FromBody] StaffEducationDataModel model)
        {
            var updated = await _mediator.Send(new UpdateStaffEducationCommand(model));
            return updated ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _mediator.Send(new DeleteStaffEducationCommand(id));
            return deleted ? Ok() : NotFound();
        }
    }
}
