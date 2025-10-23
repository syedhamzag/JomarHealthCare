using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using JomarHealthCare.Application.CQRS.CompanyBanks.Queries;
using JomarHealthCare.Application.CQRS.PettyCashHeadings.Queries;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    [ApiController]
    public class PettyCashHeadingController : ControllerBase
    {
        private readonly IMediator mediator;

        public PettyCashHeadingController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllPettyCashHeadinf")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new GetAllPettyCashHeading());
            return Ok(result);
        }

        [HttpGet("GetPettyCashHeadingById/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int key)
        {
            var result = await mediator.Send(new GetPettyHeadingCashById(key) { Id = key });
            return Ok(result);
        }
    }
}
