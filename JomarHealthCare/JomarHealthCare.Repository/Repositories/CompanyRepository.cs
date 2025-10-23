using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application;
using JomarHealthCare.Application.DataModels.Company;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class CompanyRepository : GenericRepository<Domain.Entities.Company>, ICompanyRepository
    {
        private readonly MyCareDbContext _context;


        public CompanyRepository(IUnitOfWork dbContext, MyCareDbContext context) : base(dbContext)
        {
            _context = context;
        }

        public async Task<string> GenerateUniqueCompanyCodeAsync()
        {
            string code;
            Random random = new Random();

            var existingCodes = await _context.Set<Company>()
                                              .Select(c => c.CompanyCode)
                                              .ToHashSetAsync();

            do
            {
                int number = random.Next(0, 10000); // 0000 to 9999
                code = "Care" + number.ToString("D4");
            }
            while (existingCodes.Contains(code));

            return code;

        }

        public async Task<List<CompanyDataModel>> GetAll()
        {
            var data = await _context.Set<Company>().Include(x => x.Users).Select(x => new CompanyDataModel
            {
                CompanyId = x.CompanyId,
                CompanyName = x.CompanyName,
                EmailAddress = x.Users.Select(u => u.Email).FirstOrDefault(),
                CompanyCode = x.CompanyCode,
                Telephone = x.Telephone,
            }).ToListAsync();

            return data;

        }

        public async Task<Company> GetCompanyByCode(string companyCode)
        {
            return await _context.Set<Company>().FirstOrDefaultAsync(x => x.CompanyCode == companyCode);
        }

    }
}
