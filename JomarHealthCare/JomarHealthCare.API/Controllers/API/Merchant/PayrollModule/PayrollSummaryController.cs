using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;

namespace JomarHealthCare.API.Controllers.API.Merchant.PayrollModule
{
    [Route("api/merchant/[controller]")]
    [ApiController]
    public class PayrollSummaryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PayrollSummaryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize(Policy = My360AuthorizationPolicy.Company)]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddPayrollSummaryCommand command)
        {
            var medication = await _mediator.Send(command);
            return Ok(medication);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdatePayrollSummaryCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? NoContent() : NotFound();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeletePayrollSummaryCommand { Id = id });
            return result ? NoContent() : NotFound();
        }

    }
}
