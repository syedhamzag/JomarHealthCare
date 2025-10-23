using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
  public class SurveyOfficerToAct
  {
    [Key]
    public int SurveyOfficerToActId { get; set; }

    [ForeignKey("StaffPersonalInfo")]
    public Guid StaffPersonalInfoId { get; set; }
    public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
  }
}
