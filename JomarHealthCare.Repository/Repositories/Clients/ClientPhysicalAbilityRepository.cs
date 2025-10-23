using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientPhysicalAbilityRepository : GenericRepository<PhysicalAbility>, IClientPhysicalAbilityRepository
{
    private readonly MyCareDbContext _context;
    public ClientPhysicalAbilityRepository(IUnitOfWork dbContext, MyCareDbContext context) : base(dbContext)
    {
        _context = context;
    }

    public async Task DeleteByClientIdAsync(Guid clientId, CancellationToken cancellationToken)
    {
        var toDelete = await _context.Set<PhysicalAbility>()
        .Where(p => p.ClientId == clientId)
        .ToListAsync(cancellationToken);

        _context.Set<PhysicalAbility>().RemoveRange(toDelete);
    }
}