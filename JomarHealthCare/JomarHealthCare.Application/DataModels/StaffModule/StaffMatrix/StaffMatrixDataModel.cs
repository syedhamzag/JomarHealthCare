
namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffMatrixDataModel
    {
        public Guid StaffPersonalInfoId { get; set; }
        public string RegistrationId { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ProfilePix { get; set; }
        public StaffMatrixDetailDataModel DBS { get; set; } 
        public StaffMatrixDetailDataModel NMC { get; set; }
        public StaffMatrixDetailDataModel DriverLicense { get; set; } 
        public StaffMatrixDetailDataModel Performance { get; set; } 
        public StaffMatrixDetailDataModel NextOfKin { get; set; } 
        public StaffMatrixDetailDataModel DateOfEmployment { get; set; } 
        public StaffMatrixDetailDataModel Appraisal { get; set; }
        public StaffMatrixDetailDataModel Trainings { get; set; }
        public StaffMatrixDetailDataModel SpotChecks { get; set; }
        public StaffMatrixDetailDataModel AdlObs { get; set; } 
        public StaffMatrixDetailDataModel MedCompObs { get; set; } 
        public StaffMatrixDetailDataModel KeyWorkerVoice { get; set; } 
        public StaffMatrixDetailDataModel Supervision { get; set; }
        public StaffMatrixDetailDataModel CompetenceTest { get; set; }
        public StaffMatrixDetailDataModel Survey { get; set; } 
        public StaffMatrixDetailDataModel References { get; set; } 
        public StaffMatrixDetailDataModel Shadowing { get; set; }
        public StaffMatrixDetailDataModel Interview { get; set; }
        public StaffMatrixDetailDataModel Health { get; set; }

    }
    public class StaffMatrixDetailDataModel
    {
        public string Date { get; set; } = string.Empty;
        public string Expiry { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
