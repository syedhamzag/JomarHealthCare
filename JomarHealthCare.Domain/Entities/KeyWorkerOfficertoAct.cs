using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
  public  class KeyWorkerOfficerToAct
    {
        public int KeyWorkerOfficerToActId { get; set; }
        public int KeyWorkerId { get; set; }
        [ForeignKey("StaffPersonalInfo")]
        public Guid StaffPersonalInfoId { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
