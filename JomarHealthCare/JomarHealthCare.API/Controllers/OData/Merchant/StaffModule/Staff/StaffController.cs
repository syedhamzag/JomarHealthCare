using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffController : ODataController
    {
        private readonly IMediator mediator;

        public StaffController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("Staff")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffQuery());
            return Ok(result);
        }

        [HttpGet("Staff/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffQuery(){Id=key});
            return Ok(result);
        }
        [HttpGet("StaffByKey/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetStaffByKeyAsync(Guid key)
        {
            var result = await mediator.Send(new StaffMatrixQuery() { key = key });
            return Ok(result);
        }
    }



}
