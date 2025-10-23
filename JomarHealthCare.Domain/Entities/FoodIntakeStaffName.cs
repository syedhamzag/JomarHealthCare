namespace JomarHealthCare.Domain.Entities
{
  public  class FoodIntakeStaffName
    {
        public int FoodIntakeStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int FoodIntakeId { get; set; }

        public virtual ClientFoodIntake FoodIntake { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
