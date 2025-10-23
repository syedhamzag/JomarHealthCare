using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffEmergencyContactController : ODataController
    {
        private readonly IMediator mediator;

        public StaffEmergencyContactController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffEmergencyContact")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffEmergencyContactQuery());
            return Ok(result);
        }

        [HttpGet("StaffEmergencyContact/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffEmergencyContactQuery(){Id=key});
            return Ok(result);
        }
    }



}
