using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.TaskBoards.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class ClientTaskBoardController : ODataController
    {
        private readonly IMediator mediator;

        public ClientTaskBoardController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("ClientTaskBoard")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new TaskBoardQuery());
            return Ok(result);
        }

        [HttpGet("ClientTaskBoard/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new TaskBoardQuery(){Id=key});
            return Ok(result);
        }
        [HttpGet("ClientTaskBoard/GetByCompanyId/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByCompanyIdAsync(Guid key)
        {
            var result = await mediator.Send(new GetTaskBoardByCompanyIdQuery(key));
            return Ok(result);
        }
        [HttpGet("ClientTaskBoard/GetByAssignedTo/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByAssignedToAsync(Guid key)
        {
            var result = await mediator.Send(new GetTaskBoardAssignedToQuery(key));
            return Ok(result);
        }
    }
}
