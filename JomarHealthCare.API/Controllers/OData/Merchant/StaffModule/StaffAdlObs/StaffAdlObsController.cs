using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffAdlObsController : ODataController
    {
        private readonly IMediator mediator;

        public StaffAdlObsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffAdlObs")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffAdlObsQuery());
            return Ok(result);
        }

        [HttpGet("StaffAdlObs/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffAdlObsQuery(){Id=key});
            return Ok(result);
        }
    }
}
