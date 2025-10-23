using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffShadowingController : ODataController
    {
        private readonly IMediator mediator;

        public StaffShadowingController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffShadowing")]
        [EnableQuery]
        public async Task<ActionResult<List<StaffShadowingDataModel>>> GetAllAsync()
        {
            var result = await mediator.Send(new StaffShadowingQuery());
            return Ok(result);
        }

        [HttpGet("StaffShadowing/{key}")]
        [EnableQuery]
        public async Task<ActionResult<StaffShadowingDataModel>> GetByIdAsync(Guid key)
        {
            var result = await mediator.Send(new StaffShadowingQuery(key));
            return Ok(result);
        }
    }
}
