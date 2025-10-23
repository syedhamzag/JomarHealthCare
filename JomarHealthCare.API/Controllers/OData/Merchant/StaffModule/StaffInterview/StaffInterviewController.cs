using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffInterviewController : ODataController
    {
        private readonly IMediator mediator;

        public StaffInterviewController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffInterview")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffInterviewQuery());
            return Ok(result);
        }

        [HttpGet("StaffInterviewByStaffId/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffInterviewQuery(){Id=key});
            return Ok(result);
        }
    }



}
