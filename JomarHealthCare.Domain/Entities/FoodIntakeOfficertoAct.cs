namespace JomarHealthCare.Domain.Entities
{
  public  class FoodIntakeOfficerToAct
    {
        public int FoodIntakeOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int FoodIntakeId { get; set; }

        public virtual ClientFoodIntake FoodIntake { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
