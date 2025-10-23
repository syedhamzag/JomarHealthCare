using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffInfectionControlController : ODataController
    {
        private readonly IMediator mediator;

        public StaffInfectionControlController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffInfectionControl")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffInfectionControlQuery());
            return Ok(result);
        }

        [HttpGet("StaffInfectionControl/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffInfectionControlQuery(){Id=key});
            return Ok(result);
        }
    }



}
