using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using JomarHealthCare.Application.CQRS.Payroll.Queries.RegisterIncomeQueries;
using JomarHealthCare.Application.CQRS.Payroll.Queries.RegisterReductionQueries;

namespace JomarHealthCare.API.Controllers.OData.Merchant.PayrollModule
{
    [Route("odata/merchant")]
    [ApiController]
    public class RegisterDeductionController : ControllerBase
    {
        private readonly IMediator mediator;

        public RegisterDeductionController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllRegisterDeduction")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new GetAllRegisterDeduction());
            return Ok(result);
        }

        [HttpGet("GetRegisterDeductionById/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int key)
        {
            var result = await mediator.Send(new GetRegisterDeductionById(key) { Id = key });
            return Ok(result);
        }
    }
}
