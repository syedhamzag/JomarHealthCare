using JomarHealthCare.Application.CQRS.Client.Commands;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffSpotCheckController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffSpotCheckController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffSpotCheckDataModel>> Create([FromBody] StaffSpotCheckDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffSpotCheckCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffSpotCheckDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffSpotCheckCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffSpotCheckCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(); // Handled via OData elsewhere
        }
    }

}
