using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffSupervisionAppraisalController : ODataController
    {
        private readonly IMediator mediator;

        public StaffSupervisionAppraisalController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffSupervisionAppraisal")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffSupervisionAppraisalQuery());
            return Ok(result);
        }

        [HttpGet("StaffSupervisionAppraisal/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffSupervisionAppraisalQuery(){Id=key});
            return Ok(result);
        }
    }
}
