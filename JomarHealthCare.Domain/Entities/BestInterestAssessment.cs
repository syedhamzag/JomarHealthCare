using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class BestInterestAssessment
    {
        public int BestId { get; set; }
        public Guid? ClientId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Signature { get; set; }
        public string Date { get; set; }  // consider DateTime if it's an actual date
        public int? RefuseTreatment { get; set; }

        [MaxLength(2048)]
        public string RefuseTreatmentRemarks { get; set; }
        public int? PowerofAttorney { get; set; }

        [MaxLength(2048)]
        public string PowerofAttorneyRemarks { get; set; }
        public int? BenefitOfTreatment { get; set; }

        [MaxLength(2048)]
        public string BenefitOfTreatmentRemarks { get; set; }
        public int Statutory { get; set; }

        [MaxLength(2048)]
        public string StatutoryRemarks { get; set; }
        public int? WelfareAspect { get; set; }
        
        [MaxLength(2048)]
        public string WelfareAspectRemarks { get; set; }
        public int? EthicalAspect { get; set; }

        [MaxLength(2048)]
        public string EthicalAspectRemarks { get; set; }
        public int? EmotionalAspect { get; set; }

        [MaxLength(2048)]
        public string EmotionalAspectRemarks { get; set; }
        public int? Summary { get; set; }

        [MaxLength(2048)]
        public string SummaryRemarks { get; set; }
        public bool IsNutrition { get; set; }
        public bool IsMedication { get; set; }
        public bool IsHygiene { get; set; }
        public bool IsStoma { get; set; }
        public bool IsFinance { get; set; }
        public bool IsRequired { get; set; }
    }
}
