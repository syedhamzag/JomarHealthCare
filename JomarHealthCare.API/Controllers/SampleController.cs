using JomarHealthCare.Application.Abstractions;

namespace JomarHealthCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IEmailService emailService;

        public SampleController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpPost("send-email")]
        public async Task<ActionResult> SendEmail(string recipient)
        {
            await emailService.SendEmailAsync(recipient, "Test Subject", "Test Body");
            return Ok();
        }
    }
}
