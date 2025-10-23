namespace JomarHealthCare.Domain.Entities
{
  public  class FoodIntakePhysician
    {
        public int FoodIntakePhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int FoodIntakeId { get; set; }

        public virtual ClientFoodIntake FoodIntake { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
