using Microsoft.AspNetCore.OData.Query;
using JomarHealthCare.Application.CQRS.Staff.Commands.User;
using JomarHealthCare.Application.ResponseModels;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
using JomarHealthCare.Application.CQRS.Territories.Queries;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Application.CQRS.StaffModule.Commands.Create;

namespace JomarHealthCare.API.Controllers.API.Merchant
{

    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class StaffController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<StaffController> _logger;

        public StaffController(IMediator mediator, ILogger<StaffController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        [NonAction]
        [Obsolete]
        public async Task<IActionResult> Create([FromBody] CreateApplicationUserCommand command)
        {
            var user = await _mediator.Send(command);
            DefaultResponse<ApplicationUser> response = new DefaultResponse<ApplicationUser>();
            response.Status = true;
            response.ResponseCode = "00";
            response.ResponseMessage = "STAFF CREATED SUCCESSFULLY";
            response.Data = user;
            return Ok(response);
        }

        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<ApplicationUserDto>> Get()
        {
            var user = await _mediator.Send(new StaffQuery());
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] UpdateApplicationUserCommand command)
        {
            if (id != command.Id)
                return BadRequest("Mismatched user ID.");

            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _mediator.Send(new DeleteApplicationUserCommand { Id = id });
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> OnboardAsync([FromBody] OnboardStaffAccountDataModel model)
        {
            var response = await _mediator.Send(new OnboardStaffCommand(model));
            if (response != "Staff Register Successfully")
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpPost]
        public async Task<ActionResult> OnboardByCompany([FromBody] OnboardByCompanyStaffAccountDataModel model)
        {
            var response = await _mediator.Send(new OnboardStaffByCompanyCommand(model));

            if (!response)
            {
                return BadRequest("ACTION FAILED");
            }

            return Ok("ACTION SUCCESSFUL");
        }


        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetByCompanyId(Guid id)
        {
            var result = await _mediator.Send(new GetAllStaffByCompanyIdQuery(id));
            return Ok(result);
        }
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetAllUserByCompanyId(Guid id)
        {
            var result = await _mediator.Send(new GetAllUserByCompanyIdQuery(id));
            return Ok(result);
        }
    }
}
