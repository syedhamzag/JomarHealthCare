namespace JomarHealthCare.Domain.Entities
{
  public  class PainChartOfficerToAct
    {
        public int PainChartOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int PainChartId { get; set; }

        public virtual ClientPainChart PainChart { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
