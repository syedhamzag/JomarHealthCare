using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    public class InterviewQuestionController : ODataController
    {
        private readonly IMediator mediator;

        public InterviewQuestionController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("InterviewQuestion")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new InterviewQuestionQuery());
            return Ok(result);
        }

        [HttpGet("InterviewQuestion/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new InterviewQuestionQuery() { Id = key });
            return Ok(result);
        }
    }
}
