namespace JomarHealthCare.Domain.Entities
{
    public class HospitalExitOfficerToTakeAction
 
    {
        public int HospitalExitOfficerToTakeActionId { get; set; }
        public int HospitalExitId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }

        public virtual HospitalExit HospitalExit { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
