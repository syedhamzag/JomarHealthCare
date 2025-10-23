namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/staff/[controller]")]
    [ApiController]
    public class OneToOneOfficerToActController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OneToOneOfficerToActController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<OneToOneOfficerToActDataModel>> Create([FromBody] OneToOneOfficerToActDataModel model)
        {
            var result = await _mediator.Send(new CreateOneToOneOfficerToActCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] OneToOneOfficerToActDataModel model)
        {
            var result = await _mediator.Send(new UpdateOneToOneOfficerToActCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteOneToOneOfficerToActCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(); // OData usage
        }
    }
}
