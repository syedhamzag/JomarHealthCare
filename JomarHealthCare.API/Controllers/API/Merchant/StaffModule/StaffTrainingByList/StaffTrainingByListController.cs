namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffTrainingByListController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffTrainingByListController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffTrainingByListDataModel>> Create([FromBody] StaffTrainingByListDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffTrainingByListCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StaffTrainingByListDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffTrainingByListCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffTrainingByListCommand(id));
            return result ? Ok() : NotFound();
        }
    }
}
