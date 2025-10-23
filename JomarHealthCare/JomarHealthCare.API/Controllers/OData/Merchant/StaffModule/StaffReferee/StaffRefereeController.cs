using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffRefereeController : ODataController
    {
        private readonly IMediator mediator;

        public StaffRefereeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffReferee")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffRefereeQuery());
            return Ok(result);
        }

        [HttpGet("StaffReferee/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffRefereeQuery(){Id=key});
            return Ok(result);
        }
    }



}
