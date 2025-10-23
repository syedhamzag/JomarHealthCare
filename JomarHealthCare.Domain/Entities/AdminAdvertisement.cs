namespace JomarHealthCare.Domain.Entities
{
    public class AdminAdvertisement
    {
        public AdminAdvertisement()
        {
            //CompanyModels = new HashSet<CompanyModel>();
        }
        public int Id { get; set; }
        public string Image { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsForAll { get; set; }
    }
}
