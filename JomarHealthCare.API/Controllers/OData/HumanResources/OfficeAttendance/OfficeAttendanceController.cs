using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries;

namespace JomarHealthCare.API.Controllers.OData.HumanResources
{
    [Route("odata/HumanResources")]
    
    public class OfficeAttendanceController : ODataController
    {
        private readonly IMediator mediator;

        public OfficeAttendanceController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("OfficeAttendance")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new OfficeAttendanceQuery());
            return Ok(result);
        }

        [HttpGet("OfficeAttendance/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new OfficeAttendanceQuery(){Id=key});
            return Ok(result);
        }
    }

}