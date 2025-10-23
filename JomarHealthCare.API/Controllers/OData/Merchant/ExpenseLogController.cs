using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using JomarHealthCare.Application.CQRS.ExpenseLogs.Queries;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    [ApiController]
    public class ExpenseLogController : ControllerBase
    {
        private readonly IMediator mediator;

        public ExpenseLogController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllExpenseLog")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new GetAllExpenseLog());
            return Ok(result);
        }

        [HttpGet("GetExpenseLogById/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int key)
        {
            var result = await mediator.Send(new GetExpenseLogById(key) { Id = key });
            return Ok(result);
        }
    }
}
