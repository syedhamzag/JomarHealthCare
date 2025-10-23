using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JomarHealthCare.Domain.Common
{

    public class AuditableEntity
    {
        [JsonIgnore]
        [MaxLength(450)]
        public string? CreatedBy { get; set; }
        [JsonIgnore]
        public DateTime CreatedOn { get; set; }
        [JsonIgnore]
        [MaxLength(450)]
        public string? LastModifiedBy { get; set; }
        [JsonIgnore]
        public DateTime? LastModifiedOn { get; set; }
        [JsonIgnore]
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        [MaxLength(450)]
        public string? DeletedBy { get; set; }
        [JsonIgnore]
        public bool Deleted { get; set; }
        [JsonIgnore]
        public DateTime? DeletedOn { get; set; }
    }
}
