using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
  public  class SupervisionOfficerToAct
    {
      [Key]
        public int SupervisionOfficerToActId { get; set; }
        public int StaffSupervisionAppraisalId { get; set; }
        public virtual StaffSupervisionAppraisal Supervision { get; set; }
        [ForeignKey("StaffPersonalInfo")]
        public Guid StaffPersonalInfoId { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
