using JomarHealthCare.Application.RequestModels.ZohoEmail;

namespace JomarHealthCare.Application.Abstractions
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);

        Task SendEmailAsync(string content, string subject, List<To> destinations);
        Task SendTemplatedEmailAsync(string templateKey, Dictionary<string, string> templateContent, List<To> destinations);
    }
}
