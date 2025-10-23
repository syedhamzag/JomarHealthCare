using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.DataModels.Company;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories
{
    public interface ICompanyRepository:IGenericRepository<Company>
    {
        Task<Company> GetCompanyByCode(string companyCode);

        Task<List<CompanyDataModel>> GetAll();

        Task<string> GenerateUniqueCompanyCodeAsync();
    }
}
