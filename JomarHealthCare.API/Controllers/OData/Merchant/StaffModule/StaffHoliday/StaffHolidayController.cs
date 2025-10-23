using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffHolidayController : ODataController
    {
        private readonly IMediator mediator;

        public StaffHolidayController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffHoliday")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffHolidayQuery());
            return Ok(result);
        }

        [HttpGet("StaffHoliday/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffHolidayQuery(){Id=key});
            return Ok(result);
        }
    }



}
