using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JomarHealthCare.Application.CQRS.ReportedConcerns.Commands;
using JomarHealthCare.Application.CQRS.ReportedConcerns.Queries;
using JomarHealthCare.Application.DataModels.ReportedConcerns;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportedConcernController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReportedConcernController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ReportedConcernDataModel>> Create([FromBody] ReportedConcernDataModel model)
        {
            var result = await _mediator.Send(new AddReportedConcernCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] ReportedConcernDataModel model)
        {
            var result = await _mediator.Send(new UpdateReportedConcernCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpGet("GetAllByCompanyId/{id:Guid}")]
        public async Task<IActionResult> GetAllByCompanyId(Guid id)
        {
            var result = await _mediator.Send(new GetAllReportedConcernByIdQuery(id));
            return Ok(result);
        }

        [HttpGet("GetById/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetReportedConcernByIdQuery(id));
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteReportedConcernCommand(id));
            return result ? NoContent() : NotFound();
        }
    }
}
