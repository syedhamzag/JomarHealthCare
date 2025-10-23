using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffPersonalInfoController : ODataController
    {
        private readonly IMediator mediator;

        public StaffPersonalInfoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffPersonalInfo")]
        [EnableQuery]
        public async Task<ActionResult<List<StaffPersonalInfoDataModel>>> GetAllAsync()
        {
            var result = await mediator.Send(new StaffPersonalInfoQuery());
            return Ok(result);
        }

        [HttpGet("StaffPersonalInfo/{key}")]
        [EnableQuery]
        public async Task<ActionResult<StaffPersonalInfoDataModel>> GetByIdAsync(Guid key)
        {
            var result = await mediator.Send(new StaffPersonalInfoQuery(key));
            return Ok(result);
        }
    }
}
