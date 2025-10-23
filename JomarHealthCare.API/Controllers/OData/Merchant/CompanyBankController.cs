using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using JomarHealthCare.Application.CQRS.CompanyBanks.Queries;
using JomarHealthCare.Application.CQRS.ExpenseLogs.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{

    [Route("odata/merchant")]
    [ApiController]
    public class CompanyBankController : ControllerBase
    {
        private readonly IMediator mediator;

        public CompanyBankController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllCompanyBank")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new GetAllCompanyBank());
            return Ok(result);
        }

        [HttpGet("GetCompanyBankById/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int key)
        {
            var result = await mediator.Send(new GetCompanyBankById(key) { Id = key });
            return Ok(result);
        }
    }
}
