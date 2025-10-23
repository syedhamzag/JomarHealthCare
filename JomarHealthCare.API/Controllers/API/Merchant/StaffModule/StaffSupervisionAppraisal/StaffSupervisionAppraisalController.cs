using JomarHealthCare.Application.CQRS.Client.Commands;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffSupervisionAppraisalController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffSupervisionAppraisalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffSupervisionAppraisalDataModel>> Create([FromBody] StaffSupervisionAppraisalDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffSupervisionAppraisalCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffSupervisionAppraisalDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffSupervisionAppraisalCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffSupervisionAppraisalCommand(id));
            return result ? Ok() : NotFound();
        }
    }

}
