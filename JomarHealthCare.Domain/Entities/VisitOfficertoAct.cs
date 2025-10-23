namespace JomarHealthCare.Domain.Entities
{
  public  class VisitOfficerToAct
    {
        public int VisitOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int VisitId { get; set; }

        public virtual ClientMgtVisit Visit { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
