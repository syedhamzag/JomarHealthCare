namespace JomarHealthCare.Application.DataModels.Careplan;

public class PersonalHygieneDataModel
{
    public int HygieneId { get; set; }
    public int Cleaning { get; set; }
    public int CleaningTools { get; set; }
    public int WhoClean { get; set; }
    public int DesiredCleaning { get; set; }
    public int CleaningFreq { get; set; }
    public int GeneralAppliance { get; set; }
    public int DirtyLaundry { get; set; }
    public int DryLaundry { get; set; }
    public int WashingMachine { get; set; }
    public int Ironing { get; set; }
    public string LaundryGuide { get; set; }
    public string LaundrySupport { get; set; }
    public Guid? ClientId { get; set; }
}
