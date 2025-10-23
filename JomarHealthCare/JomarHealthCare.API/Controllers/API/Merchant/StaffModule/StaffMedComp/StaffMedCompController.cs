
namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffMedCompController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffMedCompController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffMedCompDataModel>> Create([FromBody] StaffMedCompDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffMedCompCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffMedCompDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffMedCompCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffMedCompCommand(id));
            return result ? Ok() : NotFound();
        }
    }

}
