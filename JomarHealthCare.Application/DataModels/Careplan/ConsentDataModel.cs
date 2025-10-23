using System.ComponentModel.DataAnnotations;

namespace JomarHealthCare.Application.DataModels.Careplan;

public class ConsentDataModel
{
    public int DataId { get; set; }
    public Guid? ClientId { get; set; }
    public string Signature { get; set; }
    public DateTime? Date { get; set; }

    [MaxLength(256)]
    public string InvolvingPerson { get; set; }
    public string CareSignature { get; set; }
    public DateTime? CareDate { get; set; }

    [MaxLength(256)]
    public string CareInvolvingPerson { get; set; }

    public string LandSignature { get; set; }
    public DateTime? LandDate { get; set; }

    [MaxLength(256)]
    public string LandInvolvingPerson { get; set; }

    [MaxLength(512)]
    public string LandMethodOfLogs { get; set; }
    public string OwnMedication { get; set; }
    public string FamilyResponsibity { get; set; }
    public string AdministratorProcess { get; set; }
}
