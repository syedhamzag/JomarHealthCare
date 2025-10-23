namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class ClassOfStaffController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClassOfStaffController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ClassOfStaffDataModel>> Create([FromBody] ClassOfStaffDataModel model)
        {
            var result = await _mediator.Send(new CreateClassOfStaffCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ClassOfStaffDataModel model)
        {
            var result = await _mediator.Send(new UpdateClassOfStaffCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteClassOfStaffCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(); // OData endpoint
        }
    }

}
