namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffSurveyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffSurveyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffSurveyDataModel>> Create([FromBody] StaffSurveyDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffSurveyCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffSurveyDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffSurveyCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffSurveyCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }

}
