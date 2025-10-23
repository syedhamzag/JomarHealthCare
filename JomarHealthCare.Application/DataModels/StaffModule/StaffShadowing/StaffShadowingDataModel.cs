using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffShadowingDataModel
    {
        public int StaffShadowingId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Heading { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
        public Guid? CompanyId { get; set; }
    }
}