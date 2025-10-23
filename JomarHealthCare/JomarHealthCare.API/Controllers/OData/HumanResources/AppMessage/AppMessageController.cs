using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries;

namespace JomarHealthCare.API.Controllers.OData.HumanResources
{
    [Route("odata/HumanResources")]

    public class AppMessageController : ODataController
    {
        private readonly IMediator mediator;

        public AppMessageController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("AppMessage")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new AppMessageQuery());
            return Ok(result);
        }

        [HttpGet("AppMessage/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new AppMessageQuery() { Id = key });
            return Ok(result);
        }
    }

}