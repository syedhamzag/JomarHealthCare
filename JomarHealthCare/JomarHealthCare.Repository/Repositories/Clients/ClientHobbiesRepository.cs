using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application;
using JomarHealthCare.Application.DataModels.Client.ClientHobbies;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientHobbiesRepository : GenericRepository<ClientHobbies>, IClientHobbiesRepository
{
    private readonly MyCareDbContext _context;


    public ClientHobbiesRepository(IUnitOfWork dbContext, MyCareDbContext context) : base(dbContext)
    {
        _context = context;
    }

    public async Task<bool> AddOrUpdate(List<ClientHobbies> model)
    {
        var existing = await _context.Set<ClientHobbies>().Where(x => x.ClientId == model[0].ClientId).ToListAsync();
        if (existing.Count() > 0)
        {
            _context.Set<ClientHobbies>().RemoveRange(existing);
        }

        var clientHobbies = model.Select(p => new ClientHobbies
        {
            HId = p.HId,
            ClientId = p.ClientId
        }).ToList();

        _context.Set<ClientHobbies>().AddRange(clientHobbies);

        return true;
    }

    public async Task<List<ClientHobbiesDataModel>> GetAllByClientId(Guid clientId)
    {
        var existing = await _context.Set<ClientHobbies>().Include(x => x.Hobbies).Where(x => x.ClientId == clientId && !x.IsDeleted).Select(x => new ClientHobbiesDataModel
        {
            CHId = x.CHId,
            ClientId = x.ClientId,
            HId = x.HId,
            Name = x.Hobbies.Name,
        }).ToListAsync();

        return existing;
    }
}
