using System.ComponentModel.DataAnnotations;

namespace JomarHealthCare.Domain.Entities
{
    public class InfectionControl
    {
        public int InfectionId { get; set; }

        public int? Type { get; set; }

        [MaxLength(2048)]
        public string Detail { get; set; }
        public string Guideline { get; set; }
        public DateTime? TestDate { get; set; }
        public int? VaccStatus { get; set; }
        public string Remarks { get; set; }
        public int? Status { get; set; }
        public Guid? ClientId { get; set; }
    }
}
