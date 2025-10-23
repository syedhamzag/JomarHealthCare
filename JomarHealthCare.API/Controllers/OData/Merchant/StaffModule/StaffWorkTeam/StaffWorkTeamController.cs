using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffWorkTeamController : ODataController
    {
        private readonly IMediator mediator;

        public StaffWorkTeamController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffWorkTeam")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffWorkTeamQuery());
            return Ok(result);
        }

        [HttpGet("StaffWorkTeam/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffWorkTeamQuery(){Id=key});
            return Ok(result);
        }
    }



}
