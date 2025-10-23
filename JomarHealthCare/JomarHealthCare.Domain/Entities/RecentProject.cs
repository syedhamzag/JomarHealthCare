namespace JomarHealthCare.Domain.Entities
{
    public class RecentProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int Progress { get; set; }


    }
}
