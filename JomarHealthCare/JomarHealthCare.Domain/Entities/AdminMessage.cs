namespace JomarHealthCare.Domain.Entities
{
    public class AdminMessage
    {
        public AdminMessage()
        {
            //CompanyModels = new HashSet<CompanyModel>();
        }
        public int Id { get; set; }
        public string AdminsMessage { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsForAll { get; set; }


    }
}
