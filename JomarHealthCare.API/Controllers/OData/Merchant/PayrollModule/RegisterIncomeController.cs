using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using JomarHealthCare.Application.CQRS.Payroll.Queries.RegisterIncomeQueries;
using JomarHealthCare.Application.CQRS.PettyCashHeadings.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant.PayrollModule
{
    [Route("odata/merchant")]
    [ApiController]
    public class RegisterIncomeController : ControllerBase
    {
        private readonly IMediator mediator;

        public RegisterIncomeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllRegisterIncome")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new GetAllRegisterIncome());
            return Ok(result);
        }

        [HttpGet("GetRegisterIncomeById/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int key)
        {
            var result = await mediator.Send(new GetRegisterIncomeById(key) { Id = key });
            return Ok(result);
        }
    }
}
