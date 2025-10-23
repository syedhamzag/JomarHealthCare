using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    public class CandidateInterviewController : ODataController
    {
        private readonly IMediator mediator;

        public CandidateInterviewController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("CandidateInterview")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new CandidateInterviewQuery());
            return Ok(result);
        }

        [HttpGet("CandidateInterview/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new CandidateInterviewQuery() { Id = key });
            return Ok(result);
        }
    }
}
