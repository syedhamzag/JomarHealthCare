namespace JomarHealthCare.Domain.Entities
{
    public class CareObjPersonToAct
    {
        public int Id { get; set; }
        public int CareObjId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }

        public virtual ClientCareObj ClientCareObj { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
