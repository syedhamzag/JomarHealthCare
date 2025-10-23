using JomarHealthCare.Application.DataModels.Client.ClientHobbies;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories.Clients;

public interface IClientHobbiesRepository : IGenericRepository<ClientHobbies>
{
    Task<bool> AddOrUpdate(List<ClientHobbies> model);

    Task<List<ClientHobbiesDataModel>> GetAllByClientId(Guid clientId);
}
