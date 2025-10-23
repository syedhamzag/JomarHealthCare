using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JomarHealthCare.Application.CQRS.ExpenseLogs.Commands;
using JomarHealthCare.Application.CQRS.PettyCashHeadings.Commands;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/merchant/[controller]")]
    [ApiController]
    public class PettyCashHeadingController : ControllerBase
    {


        private readonly IMediator _mediator;
        public PettyCashHeadingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize(Policy = My360AuthorizationPolicy.Company)]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddPettyCashHeadingCommand command)
        {
            var medication = await _mediator.Send(command);
            return Ok(medication);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdatePettyCashHeadingCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? NoContent() : NotFound();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeletePettyCashHeadingCommand { Id = id });
            return result ? NoContent() : NotFound();
        }

    }
}
