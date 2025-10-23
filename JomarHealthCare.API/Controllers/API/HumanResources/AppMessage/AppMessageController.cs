using JomarHealthCare.Application.DataModels.HumanResourcesModule.AppMessage;
using JomarHealthCare.Application.Validators.HumanResourcesModule;

namespace JomarHealthCare.API.Controllers.API.HumanResources.ComplainRegistor
{
    [Route("api/HumanResources/[controller]")]
    [ApiController]
    public class AppMessageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppMessageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<AppMessageDataModel>> Create([FromBody] AppMessageDataModel model)
        {
            var result = await _mediator.Send(new CreateAppMessageCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AppMessageDataModel model)
        {
            var result = await _mediator.Send(new UpdateAppMessageCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteAppMessageCommand(id));
            return result ? Ok() : NotFound();
        }
    }
}
