using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Configs;
using JomarHealthCare.Application.HttpServices;
using JomarHealthCare.Application.RequestModels.ZohoEmail;

namespace JomarHealthCare.Infrastructure.Implementations
{
    public class EmailService : IEmailService
    {
        private readonly ZeptoEmailSetting zeptoEmailSetting;
        private readonly ILogger<EmailService> logger;
        private readonly IZeptoEmailHttpService zeptoEmailHttpService;

        public EmailService(ILogger<EmailService> logger,
            IOptionsSnapshot<ZeptoEmailSetting> zeptoEmailSetting,
            IZeptoEmailHttpService zeptoEmailHttpService)
        {
            this.zeptoEmailSetting = zeptoEmailSetting.Value;
            this.logger = logger;
            this.zeptoEmailHttpService = zeptoEmailHttpService;
        }
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            // Implement your email sending logic here
            // This is just a placeholder implementation
            await SendAsync(body, subject, new List<To> { new To { EmailAddress = new EmailAddress { Address = to } } });
        }

        public async Task SendEmailAsync(string content, string subject, List<To> destinations)
        {
            // Implement your email sending logic here
            // This is just a placeholder implementation
            await SendAsync(content, subject, destinations);
        }
        async Task SendAsync(string content, string subject, List<To> destinations)
        {
            try
            {
                var sendEmailModel = new ZeptoSendEmailRequestModel
                {
                    BounceAddress = "",
                    From = new From
                    {
                        Address = zeptoEmailSetting.SenderAddress,
                        Name = zeptoEmailSetting.SenderName
                    },
                    To = destinations,
                    Htmlbody = content,
                    Subject = subject
                };

                logger.LogInformation("sending email using zepto with payload {@sendEmailModel}", sendEmailModel);

                var response = await zeptoEmailHttpService.SendEmailAsync(sendEmailModel);
                await response.EnsureSuccessStatusCodeAsync();

                logger.LogInformation("sending email using zepto with response {response}", response?.Content?.ToString());
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "sending email with zepto failed");

            }
        }

        public async Task SendTemplatedEmailAsync(string templateKey, Dictionary<string, string> templateContent, List<To> destinations)
        {
            try
            {
                var templateEmailModel = new ZeptoSendTemplatedEmailRequestModel
                {
                    From = new From
                    {
                        Address = zeptoEmailSetting.SenderAddress,
                        Name = zeptoEmailSetting.SenderName
                    },
                    MergeInfo = templateContent,
                    TemplateKey = templateKey,
                    To = destinations
                };

                logger.LogInformation("sending templated email using zepto with payload {@templateEmailModel}", templateEmailModel);

                var response = await zeptoEmailHttpService.SendTemplatedEmailAsync(templateEmailModel);
                await response.EnsureSuccessStatusCodeAsync();

                logger.LogInformation("sending templated email using zepto with response {response}", response?.Content?.ToString());
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "send templated email with zepto failed");
            }
        }

    }
}
