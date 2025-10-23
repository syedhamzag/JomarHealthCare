namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class StaffHolidayController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffHolidayController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<StaffHolidayDataModel>> Create([FromBody] StaffHolidayDataModel model)
        {
            var result = await _mediator.Send(new CreateStaffHolidayCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StaffHolidayDataModel model)
        {
            var result = await _mediator.Send(new UpdateStaffHolidayCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStaffHolidayCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(); // OData handled elsewhere
        }
    }

}
