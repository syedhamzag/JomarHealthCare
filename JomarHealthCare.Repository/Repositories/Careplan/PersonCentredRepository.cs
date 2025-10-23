using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories.Careplan;

internal class PersonCentredRepository : GenericRepository<PersonCentred>, IPersonCentredRepository
{
    private readonly MyCareDbContext _context;
    public PersonCentredRepository(IUnitOfWork dbContext, MyCareDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task DeleteByClientIdAsync(Guid clientId, CancellationToken cancellationToken)
    {
        var toDelete = await _context.Set<PersonCentred>()
        .Where(p => p.ClientId == clientId)
        .ToListAsync(cancellationToken);

        _context.Set<PersonCentred>().RemoveRange(toDelete);
    }
}
