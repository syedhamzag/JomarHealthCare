using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffHealthController : ODataController
    {
        private readonly IMediator mediator;

        public StaffHealthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffHealth")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffHealthQuery());
            return Ok(result);
        }

        [HttpGet("StaffHealth/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffHealthQuery(){Id=key});
            return Ok(result);
        }
    }



}
