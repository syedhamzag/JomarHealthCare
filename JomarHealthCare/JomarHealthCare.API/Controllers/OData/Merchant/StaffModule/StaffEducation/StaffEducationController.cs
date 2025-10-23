using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffEducationController : ODataController
    {
        private readonly IMediator mediator;

        public StaffEducationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffEducation")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffEducationQuery());
            return Ok(result);
        }

        [HttpGet("StaffEducation/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffEducationQuery(){Id=key});
            return Ok(result);
        }
    }



}
