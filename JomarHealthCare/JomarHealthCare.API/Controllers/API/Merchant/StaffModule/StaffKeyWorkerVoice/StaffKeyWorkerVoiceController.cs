
namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffKeyWorkerVoiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffKeyWorkerVoiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffKeyWorkerVoiceDataModel>> Create([FromBody] StaffKeyWorkerVoiceDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffKeyWorkerVoiceCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffKeyWorkerVoiceDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffKeyWorkerVoiceCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffKeyWorkerVoiceCommand(id));
            return result ? Ok() : NotFound();
        }
    }

}
