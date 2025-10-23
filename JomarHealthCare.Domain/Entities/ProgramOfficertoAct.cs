namespace JomarHealthCare.Domain.Entities
{
    public class ProgramOfficerToAct
    {
        public int ProgramOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int ProgramId { get; set; }
        public virtual ClientProgram Program { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
