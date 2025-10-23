using System.Text.Json;
using System.Text.Json.Serialization;

namespace JomarHealthCare.Application.RequestModels.ZohoEmail
{
    public class ZeptoSendEmailRequestModel
    {
        [JsonPropertyName("bounce_address")]
        public string? BounceAddress { get; set; }

        [JsonPropertyName("from")]
        public From? From { get; set; }

        [JsonPropertyName("to")]
        public List<To>? To { get; set; }

        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        [JsonPropertyName("htmlbody")]
        public string? Htmlbody { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public class EmailAddress
    {
        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class From
    {
        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class To
    {
        [JsonPropertyName("email_address")]
        public EmailAddress? EmailAddress { get; set; }
    }
}
