namespace JomarHealthCare.Domain.Entities
{
  public  class ClientTaskBoardAssignedTo
    {
        public int TaskBoardAssignedToId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int TaskBoardId { get; set; }


        public virtual ClientTaskBoard ClientTaskBoard { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
