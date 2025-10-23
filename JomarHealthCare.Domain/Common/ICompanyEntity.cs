using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Domain.Common
{
    public interface ICompanyEntity
    {
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
