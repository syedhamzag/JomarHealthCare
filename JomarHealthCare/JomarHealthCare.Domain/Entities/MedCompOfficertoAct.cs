using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
  public class MedCompOfficerToAct
  {
    public int MedCompOfficerToActId { get; set; }
    [ForeignKey("StaffPersonalInfo")]
    public Guid StaffPersonalInfoId { get; set; }
    public int MedCompId { get; set; }
    public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
  }
}
