using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetRoleByEmail/{email}")]
        public async Task<IActionResult> GetRoleByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return BadRequest("Email is required");

            var role = await _mediator.Send(new GetRoleByEmailQuery(email));
            return Ok(role); // "SuperAdmin" or "Staff"
        }
    }
}
