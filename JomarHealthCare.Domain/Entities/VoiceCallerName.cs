namespace JomarHealthCare.Domain.Entities
{
  public  class VoiceCallerName
    {
        public int VoiceCallerNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int VoiceId { get; set; }

        public virtual ClientVoice Voice { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
