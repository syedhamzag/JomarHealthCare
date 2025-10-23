using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class ClassOfStaffController : ODataController
    {
        private readonly IMediator mediator;

        public ClassOfStaffController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("ClassOfStaff")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new ClassOfStaffQuery());
            return Ok(result);
        }

        [HttpGet("ClassOfStaff/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new ClassOfStaffQuery(){Id=key});
            return Ok(result);
        }
    }


    [Route("odata/hr")]
    
    public class ComplainRegistorController : ODataController
    {
        private readonly IMediator mediator;

        public ComplainRegistorController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[HttpGet("ComplainRegistor")]
        //[EnableQuery]
        //public async Task<ActionResult> GetAllAsync()
        //{
        //    var result = await mediator.Send(new ComplainRegistorQuery());
        //    return Ok(result);
        //}

        //[HttpGet("ComplainRegistor/{key}")]
        //[EnableQuery]
        //public async Task<ActionResult> GetByIdAsync(string key)
        //{
        //    var result = await mediator.Send(new ComplainRegistorQuery(){Id=key});
        //    return Ok(result);
        //}
    }



}
