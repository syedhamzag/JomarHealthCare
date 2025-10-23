using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffPersonalityTestController : ODataController
    {
        private readonly IMediator mediator;

        public StaffPersonalityTestController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffPersonalityTest")]
        [EnableQuery]
        public async Task<ActionResult<List<StaffPersonalityTestDataModel>>> GetAllAsync()
        {
            var result = await mediator.Send(new StaffPersonalityTestQuery());
            return Ok(result);
        }

        [HttpGet("StaffPersonalityTest/{key}")]
        [EnableQuery]
        public async Task<ActionResult<StaffPersonalityTestDataModel>> GetByIdAsync(Guid key)
        {
            var result = await mediator.Send(new StaffPersonalityTestQuery(key));
            return Ok(result);
        }
    }
}
