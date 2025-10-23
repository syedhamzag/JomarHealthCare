using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffCompetenceTestController : ODataController
    {
        private readonly IMediator mediator;

        public StaffCompetenceTestController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffCompetenceTest")]
        [EnableQuery]
        public async Task<ActionResult<List<StaffCompetenceTestDataModel>>> GetAllAsync()
        {
            var result = await mediator.Send(new StaffCompetenceTestQuery());
            return Ok(result);
        }

        [HttpGet("StaffCompetenceTest/{key}")]
        [EnableQuery]
        public async Task<ActionResult<StaffCompetenceTestDataModel>> GetByIdAsync(Guid key)
        {
            var result = await mediator.Send(new StaffCompetenceTestQuery(key));
            return Ok(result);
        }
    }
}
