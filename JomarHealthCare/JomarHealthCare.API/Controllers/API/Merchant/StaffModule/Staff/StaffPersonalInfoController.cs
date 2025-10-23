using JomarHealthCare.Application.ResponseModels;
using Newtonsoft.Json;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/merchant/[controller]")]
    [ApiController]

    public class StaffPersonalInfoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffPersonalInfoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<ActionResult> OnboardAsync([FromBody] OnboardStaffDataModel model)
        {
            var responseData = await _mediator.Send(new StaffPersonalInfoCommand(model));

            return Ok(new
            {
                Status = true,
                ResponseMessage = "ACTION SUCCESS",
                Data = responseData
            });
        }

        [HttpPatch]
        public async Task<ActionResult> ChangeStaffStatus([FromBody] ChangeStaffStatusDataModel request)
        {
            var responseData = await _mediator.Send(new ChangeStaffPersonalInfoCommand(request));
            return Ok(new
            {
                Status = true,
                ResponseMessage = "ACTION SUCCESS",
                Data = responseData
            });
        }


        [HttpPut]
        public async Task<ActionResult> Update(OnboardUpdateStaffDataModel data)
        {
            var model = JsonConvert.DeserializeObject<OnboardStaffDataModel>(data.data);

            var responseData = await _mediator.Send(new UpdateStaffPersonalInfoCommand(model, model.StaffPersonalInfoId));

            return Ok(new
            {
                Status = true,
                ResponseMessage = "ACTION SUCCESS",
                Data = responseData
            });
        }
    }
}
