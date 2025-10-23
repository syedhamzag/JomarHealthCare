using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries;

namespace JomarHealthCare.API.Controllers.OData.HumanResources
{
    [Route("odata/HumanResources")]
    
    public class CompanyMessageController : ODataController
    {
        private readonly IMediator mediator;

        public CompanyMessageController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("CompanyMessage")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new CompanyMessageQuery());
            return Ok(result);
        }

        [HttpGet("CompanyMessage/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new CompanyMessageQuery(){Id=key});
            return Ok(result);
        }
    }

}