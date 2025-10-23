namespace JomarHealthCare.Domain.Entities
{
   public class StaffRating : AuditableEntity, ICompanyEntity
    {
        public int StaffRatingId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
       
        public string Comment { get; set; }
        public DateTime? CommentDate { get; set; }
        public int Rating { get; set; }
        /// <summary>
        /// ApplicationUserId
        /// </summary>
        public int SubmittedBy { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
