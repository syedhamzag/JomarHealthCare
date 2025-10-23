using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class ClassOfStaff
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
