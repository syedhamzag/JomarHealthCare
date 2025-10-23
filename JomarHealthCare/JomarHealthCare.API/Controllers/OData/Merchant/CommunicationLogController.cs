using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.CommunicationLogs.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class CommunicationLogController : ODataController
    {
        private readonly IMediator mediator;

        public CommunicationLogController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("CommunicationLog/{id}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var result = await mediator.Send(new GetCommunicationLogByIdQuery(id));
            return Ok(result);
        }

        [HttpGet("CommunicationLog/GetByCompanyId/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByCompanyIdAsync(Guid key)
        {
            var result = await mediator.Send(new GetAllCommunicationLogByIdQuery(key));
            return Ok(result);
        }
        [HttpGet("CommunicationLog/GetByAttendeeId/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByAttendeeIdAsync(Guid key)
        {
            var result = await mediator.Send(new GetAllCommunicationLogByAttendeeIdQuery(key));
            return Ok(result);
        }
    }
}
