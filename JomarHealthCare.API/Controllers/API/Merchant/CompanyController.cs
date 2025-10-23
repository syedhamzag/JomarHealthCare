using JomarHealthCare.Application.CQRS.Company.Commands;
using JomarHealthCare.Application.CQRS.Company.Queries;
using JomarHealthCare.Application.DataModels.Company;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/merchant/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator mediator;

        public CompanyController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("Onboard")]
        public async Task<ActionResult> OnboardAsync([FromBody] OnboardDataModel model)
        {
            await mediator.Send(new OnboardCommand(model));
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await mediator.Send(new GetAllCompanyQuery());
            return Ok(result);
        }

        [HttpGet("GetByCompanyId/{id:Guid}")]
        public async Task<IActionResult> GetByCompanyId(Guid id)
        {
            var result = await mediator.Send(new GetCompanyForProfileSettingQuery(id));
            return Ok(result);
        }


        [HttpPut("UpdateCompanyProfile")]
        public async Task<ActionResult> UpdateCompanyProfile([FromBody] CompanyPorfileSettingDataModel model)
        {
            await mediator.Send(new UpdateCompanyProfileCommand(model));
            return Ok();
        }
    }
}
