using System.Text.Json;
using System.Text.Json.Serialization;

namespace JomarHealthCare.Application.ResponseModels.ZohoEmail
{
    public class ZeptoSendEmailResponseModel
    {
        [JsonPropertyName("data")]
        public List<Datum>? Data { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        [JsonPropertyName("object")]
        public string? Object { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public class Datum
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("additional_info")]
        public List<object>? AdditionalInfo { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
