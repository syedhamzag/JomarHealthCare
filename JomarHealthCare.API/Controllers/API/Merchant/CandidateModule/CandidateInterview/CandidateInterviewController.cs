namespace JomarHealthCare.API.Controllers.API.Merchant
{

    [Route("api/candidate/[controller]")]
    [ApiController]
    public class CandidateInterviewController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CandidateInterviewController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CandidateInterviewDataModel>> Create([FromBody] CandidateInterviewDataModel model)
        {
            var result = await _mediator.Send(new CreateCandidateInterviewCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CandidateInterviewDataModel model)
        {
            var result = await _mediator.Send(new UpdateCandidateInterviewCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteCandidateInterviewCommand(id));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(); // OData handles dynamic filtering
        }
    }
}
