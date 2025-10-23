using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffMedCompController : ODataController
    {
        private readonly IMediator mediator;

        public StaffMedCompController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffMedComp")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffMedCompQuery());
            return Ok(result);
        }

        [HttpGet("StaffMedComp/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffMedCompQuery(){Id=key});
            return Ok(result);
        }
    }



}
