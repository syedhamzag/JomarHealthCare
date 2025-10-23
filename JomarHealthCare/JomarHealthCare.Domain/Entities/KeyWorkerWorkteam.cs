using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
  public  class KeyWorkerWorkteam
    {
        public int KeyWorkerWorkteamId { get; set; }
        [ForeignKey("StaffPersonalInfo")]
        public Guid StaffPersonalInfoId { get; set; }
        public int KeyWorkerId { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
