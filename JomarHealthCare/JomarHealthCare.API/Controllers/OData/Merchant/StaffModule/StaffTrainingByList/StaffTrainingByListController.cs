using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.Staff.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class StaffTrainingByListController : ODataController
    {
        private readonly IMediator mediator;

        public StaffTrainingByListController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("StaffTrainingByList/{id}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var result = await mediator.Send(new GetStaffTrainingByListByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpGet("StaffTrainingByList/ByStaffId/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByStaffIdAsync(Guid key)
        {
            var result = await mediator.Send(new GetAllStaffTrainingByListByIdQuery(){StaffPersonalInfoId=key});
            return Ok(result);
        }
    }



}
