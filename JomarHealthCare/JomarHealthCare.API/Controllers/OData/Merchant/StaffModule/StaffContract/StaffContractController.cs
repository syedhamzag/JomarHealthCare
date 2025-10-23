using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffContractController : ODataController
    {
        private readonly IMediator mediator;

        public StaffContractController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffContract")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffContractQuery());
            return Ok(result);
        }

        [HttpGet("StaffContract/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffContractQuery(){Id=key});
            return Ok(result);
        }
    }
}
