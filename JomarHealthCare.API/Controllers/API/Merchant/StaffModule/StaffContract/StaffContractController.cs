namespace JomarHealthCare.API.Controllers.API.Merchant
{

    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffContractController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffContractController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffContractDataModel>> Create([FromBody] StaffContractDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffContractCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffContractDataModel model)
        {
            var updated = await _mediator.Send(new UpdateStaffContractCommand(model));
            return updated ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _mediator.Send(new DeleteStaffContractCommand(id));
            return deleted ? Ok() : NotFound();
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(); // OData endpoint placeholder
        }
    }

}
