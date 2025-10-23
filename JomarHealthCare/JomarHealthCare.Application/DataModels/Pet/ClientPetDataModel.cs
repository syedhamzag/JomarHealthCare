namespace JomarHealthCare.Application.DataModels.Pet;

public class ClientPetDataModel
{
    public int PetsId { get; set; }
    public string Name { get; set; }
    public int? Type { get; set; }
    public int? Age { get; set; }
    public int? Gender { get; set; }
    public string PetActivities { get; set; }
    public int? MealStorage { get; set; }
    public int? VetVisit { get; set; }
    public int? PetInsurance { get; set; }
    public string PetCare { get; set; }
    public string MealPattern { get; set; }

    public Guid? ClientId { get; set; }
}
