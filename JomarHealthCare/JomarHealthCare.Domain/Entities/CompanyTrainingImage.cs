namespace JomarHealthCare.Domain.Entities
{
    public class CompanyTrainingImage
    {
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public string BannerImg { get; set; }
        public string InductionImg { get; set; }
        public string AllCoursesImg { get; set; }
        public string MyCoursesImg { get; set; }
        public string CertificationImg { get; set; }
        public string LibarayImg { get; set; }
        public string SupportImg { get; set; }
    }
}
