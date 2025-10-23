namespace JomarHealthCare.Domain.Entities
{
    public class Hobbies
    {
        public int HId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual ICollection<ClientHobbies> ClientHobbies { get; set; }
    }
}
