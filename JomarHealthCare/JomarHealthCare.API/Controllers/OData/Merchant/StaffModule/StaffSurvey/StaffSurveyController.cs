using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffSurveyController : ODataController
    {
        private readonly IMediator mediator;

        public StaffSurveyController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffSurvey")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffSurveyQuery());
            return Ok(result);
        }

        [HttpGet("StaffSurvey/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffSurveyQuery(){Id=key});
            return Ok(result);
        }
    }



}
