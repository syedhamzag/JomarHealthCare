using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JomarHealthCare.Application.CQRS.IncidentTypes.Commands;
using JomarHealthCare.Application.CQRS.IncidentTypes.Queries;
using JomarHealthCare.Application.DataModels.IncidentType;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public IncidentTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<IncidentTypeDataModel>> Create([FromBody] IncidentTypeDataModel model)
        {
            var result = await _mediator.Send(new CreateIncidentTypeCommand(model));
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] IncidentTypeDataModel model)
        {
            var result = await _mediator.Send(new UpdateIncidentTypeCommand(model));
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllIncidentTypeQuery());
            return Ok(result);
        }


        [HttpGet("GetAllByCompanyId/{id:Guid}")]
        public async Task<IActionResult> GetAllByCompanyId(Guid id)
        {
            var result = await _mediator.Send(new GetAllByCompanyIdIncidentTypeQuery(id));
            return Ok(result);
        }

        [HttpGet("GetById/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetByIdIncidentTypeQuery(id));
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteIncidentTypeCommand { Id = id });
            return result ? NoContent() : NotFound();
        }
    }
}
