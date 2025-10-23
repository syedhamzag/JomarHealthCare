
namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffOneToOneController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffOneToOneController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffOneToOneDataModel>> Create([FromBody] StaffOneToOneDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffOneToOneCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffOneToOneDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffOneToOneCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffOneToOneCommand(id));
            return result ? Ok() : NotFound();
        }
    }

}
