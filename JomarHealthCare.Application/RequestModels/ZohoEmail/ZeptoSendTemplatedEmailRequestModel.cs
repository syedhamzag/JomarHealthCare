using System.Text.Json.Serialization;

namespace JomarHealthCare.Application.RequestModels.ZohoEmail
{
    public class ZeptoSendTemplatedEmailRequestModel
    {
        [JsonPropertyName("template_key")]
        public string? TemplateKey { get; set; }

        [JsonPropertyName("bounce_address")]
        public string? BounceAddress { get; set; }

        [JsonPropertyName("from")]
        public From? From { get; set; }

        [JsonPropertyName("to")]
        public List<To>? To { get; set; }

        [JsonPropertyName("cc")]
        public List<Cc>? Cc { get; set; }

        [JsonPropertyName("bcc")]
        public List<Bcc>? Bcc { get; set; }

        [JsonPropertyName("merge_info")]
        public Dictionary<string, string>? MergeInfo { get; set; }

        [JsonPropertyName("reply_to")]
        public List<ReplyTo>? ReplyTo { get; set; }

        [JsonPropertyName("client_reference")]
        public string? ClientReference { get; set; }

        [JsonPropertyName("mime_headers")]
        public Dictionary<string, string>? MimeHeaders { get; set; }
    }

    public class Bcc
    {
        [JsonPropertyName("email_address")]
        public EmailAddress? EmailAddress { get; set; }
    }

    public class Cc
    {
        [JsonPropertyName("email_address")]
        public EmailAddress? EmailAddress { get; set; }
    }

    public class ReplyTo
    {
        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
