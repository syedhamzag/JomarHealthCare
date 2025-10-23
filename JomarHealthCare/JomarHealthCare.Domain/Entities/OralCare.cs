
namespace JomarHealthCare.Domain.Entities;

public class OralCare
{
    public int Id { get; set; }

    public bool BurushTeeth { get; set; }
    public bool RequireOralSupport { get; set; }
    public string ManyTimeClean { get; set; }
    public bool AssistedDentalAppointment { get; set; }
    public bool AssistedWithOralCare { get; set; }
    public bool AssistedWithDailyActivities { get; set; }
    public bool AssistedWithCleaning { get; set; }
    public bool AnyOralRelatedProblem { get; set; }
    public string AnyOralRelatedProblemDetail { get; set; }
    public bool ConfirmDentist { get; set; }
    public bool ConfirmInvolingParties { get; set; }
    public bool TrainingInAssessing { get; set; }
    public string LookIntoMouth { get; set; }
    public bool AnyBarriers { get; set; }
    public string AnyBarriersFinding { get; set; }
    public bool Uncomfortable { get; set; }
    public string UncomfortableDetail { get; set; }
    public bool RecordOfMouthProduct { get; set; }
    public bool SmallHeadedToothBrush { get; set; }
    public bool ToothPaste { get; set; }
    public bool Nonfoaming { get; set; }
    public bool DryMouth { get; set; }
    public bool DenturePot { get; set; }
    public bool FoamEnded { get; set; }
    public bool StoreProduct { get; set; }
    public string OtherMouthCareItems { get; set; }
    public bool WearDentures { get; set; }
    public bool UpperDenture { get; set; }
    public bool LowerDenture { get; set; }
    public bool TypeDenturePot { get; set; }
    public bool NoTeeth { get; set; }
    public string OtherTypes { get; set; }
    public string DentureCleanAny { get; set; }
    public string DenturePotLocated { get; set; }
    public string Summary { get; set; }
    public Guid? ClientId { get; set; }
}
