using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffSpotCheckController : ODataController
    {
        private readonly IMediator mediator;

        public StaffSpotCheckController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffSpotCheck")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffSpotCheckQuery());
            return Ok(result);
        }

        [HttpGet("StaffSpotCheck/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffSpotCheckQuery(){Id=key});
            return Ok(result);
        }
    }
}
