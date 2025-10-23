namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/candidate/[controller]")]
    [ApiController]
    public class InterviewQuestionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InterviewQuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<InterviewQuestionDataModel>> Create([FromBody] InterviewQuestionDataModel model)
        {
            var result = await _mediator.Send(new CreateInterviewQuestionCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] InterviewQuestionDataModel model)
        {
            var result = await _mediator.Send(new UpdateInterviewQuestionCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteInterviewQuestionCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(); // OData support
        }
    }
}
