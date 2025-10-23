using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class OneToOneOfficerToActController : ODataController
    {
        private readonly IMediator mediator;

        public OneToOneOfficerToActController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("OneToOneOfficerToAct")]
        [EnableQuery]
        public async Task<ActionResult> GetAllAsync()
        {
            var result = await mediator.Send(new OneToOneOfficerToActQuery());
            return Ok(result);
        }

        [HttpGet("OneToOneOfficerToAct/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(string key)
        {
            var result = await mediator.Send(new OneToOneOfficerToActQuery(){Id=key});
            return Ok(result);
        }
    }



}
