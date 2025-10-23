using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JomarHealthCare.Application.CQRS.Medications.Commands;
using JomarHealthCare.Application.CQRS.Medications.Queries;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/merchant/[controller]")]
    [ApiController]
    public class PettyCashController : ControllerBase
    {

        private readonly IMediator _mediator;
        public PettyCashController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize(Policy = My360AuthorizationPolicy.Company)]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddPettyCashCommand command)
        {
            var medication = await _mediator.Send(command);
            return Ok(medication);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdatePettyCashCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? NoContent() : NotFound();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeletePettyCashCommand { Id = id });
            return result ? NoContent() : NotFound();
        }


      
    }
}
