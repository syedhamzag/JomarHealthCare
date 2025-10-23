using JomarHealthCare.Application.CQRS.Account.Commands;
using JomarHealthCare.Application.DataModels.Account;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/merchant/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator mediator;

        public AccountController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDataModel model)
        {
            var loginResponse = await mediator.Send(new LoginCommand(model));
            return Ok(loginResponse);
        }

        [HttpPost("CreateSuperAdmin")]
        public async Task<IActionResult> CreateSuperAdmin([FromBody] AddSuperAdminDataModel model)
        {
            var loginResponse = await mediator.Send(new AddSuperAdminCommand(model));
            return Ok(loginResponse);
        }
        [HttpPost("ChangeExistingRole")]
        public async Task<IActionResult> ChangeExistingRole([FromBody] UpdateSuperAdminDataModel model)
        {
            var loginResponse = await mediator.Send(new UpdateSuperAdminCommand(model));
            return Ok(loginResponse);
        }
    }
}
