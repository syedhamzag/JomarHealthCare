using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffTrainingController : ODataController
    {
        private readonly IMediator mediator;

        public StaffTrainingController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffTraining")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffTrainingQuery());
            return Ok(result);
        }

        [HttpGet("StaffTrainingByStaffId/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffTrainingQuery(){Id=key});
            return Ok(result);
        }
    }



}
