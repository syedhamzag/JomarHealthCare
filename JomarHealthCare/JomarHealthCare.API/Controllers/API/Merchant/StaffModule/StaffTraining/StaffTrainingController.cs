namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffTrainingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffTrainingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffTrainingDataModel>> Create([FromBody] StaffTrainingDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffTrainingCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StaffTrainingDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffTrainingCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffTrainingCommand(id));
            return result ? Ok() : NotFound();
        }
    }
}
