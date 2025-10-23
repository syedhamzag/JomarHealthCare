using JomarHealthCare.Application.DataModels.HumanResourcesModule.CompanyMessage;
using JomarHealthCare.Application.Validators.HumanResourcesModule;

namespace JomarHealthCare.API.Controllers.API.HumanResources.ComplainRegistor
{
    [Route("api/HumanResources/[controller]")]
    [ApiController]
    public class CompanyMessageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyMessageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CompanyMessageDataModel>> Create([FromBody] CompanyMessageDataModel model)
        {
            var result = await _mediator.Send(new CreateCompanyMessageCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CompanyMessageDataModel model)
        {
            var result = await _mediator.Send(new UpdateCompanyMessageCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteCompanyMessageCommand(id));
            return result ? Ok() : NotFound();
        }
    }
}
