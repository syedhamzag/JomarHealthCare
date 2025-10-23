using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffKeyWorkerVoiceController : ODataController
    {
        private readonly IMediator mediator;

        public StaffKeyWorkerVoiceController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffKeyWorkerVoice")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new StaffKeyWorkerVoiceQuery());
            return Ok(result);
        }

        [HttpGet("StaffKeyWorkerVoice/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new StaffKeyWorkerVoiceQuery(){Id=key});
            return Ok(result);
        }
    }



}
