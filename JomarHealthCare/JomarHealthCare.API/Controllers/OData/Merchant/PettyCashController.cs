using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    [ApiController]
    public class PettyCashController : ODataController
    {
        private readonly IMediator mediator;

        public PettyCashController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllPettyCash")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new GetAllPettyCash());
            return Ok(result);
        }

        [HttpGet("GetPettyCashById/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int key)
        {
            var result = await mediator.Send(new GetPettyCashById(key) { Id = key });
            return Ok(result);
        }
    }
}
