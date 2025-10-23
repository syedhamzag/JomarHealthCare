using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JomarHealthCare.Application.CQRS.CompanyBanks.Commands;
using JomarHealthCare.Application.CQRS.ExpenseLogs.Commands;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/merchant/[controller]")]
    [ApiController]
    public class ExpenseLogController : ControllerBase
    {


        private readonly IMediator _mediator;
        public ExpenseLogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize(Policy = My360AuthorizationPolicy.Company)]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddExpenseLogCommand command)
        {
            var medication = await _mediator.Send(command);
            return Ok(medication);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateExpenseLogCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? NoContent() : NotFound();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteExpenseLogCommand { Id = id });
            return result ? NoContent() : NotFound();
        }


    }
}
