using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffOneToOneController : ODataController
    {
        private readonly IMediator mediator;

        public StaffOneToOneController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffOneToOne")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffOneToOneQuery());
            return Ok(result);
        }

        [HttpGet("StaffOneToOne/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffOneToOneQuery(){Id=key});
            return Ok(result);
        }
    }



}
