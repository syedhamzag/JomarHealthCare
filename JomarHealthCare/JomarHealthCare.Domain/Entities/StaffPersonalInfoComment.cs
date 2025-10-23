namespace JomarHealthCare.Domain.Entities
{
    public class StaffPersonalInfoComment
    {
        public int StaffPersonalInfoCommentId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int? CommentBy_UserId { get; set; }
        public string Comment { get; set; }
        public DateTime CommentOn { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
