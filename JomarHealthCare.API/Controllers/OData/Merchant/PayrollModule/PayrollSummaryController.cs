using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using JomarHealthCare.Application.CQRS.Payroll.Queries;
using JomarHealthCare.Application.CQRS.PettyCashHeadings.Queries;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant.PayrollModule
{
    [Route("odata/merchant")]
    [ApiController]
    public class PayrollSummaryController : ControllerBase
    {
        private readonly IMediator mediator;

        public PayrollSummaryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllPayrollSummary")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new GetAllPayrollSummary());
            return Ok(result);
        }

        [HttpGet("GetPayrollSummaryById/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int key)
        {
            var result = await mediator.Send(new GetPayrollSummaryById(key) { Id = key });
            return Ok(result);
        }
    }
}

