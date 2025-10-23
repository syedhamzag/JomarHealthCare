namespace JomarHealthCare.Domain.Entities
{
  public  class BowelMovementPhysician
    {
        public int BowelMovementPhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BowelMovementId { get; set; }

        public virtual ClientBowelMovement BowelMovement { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
