using JomarHealthCare.Application.DataModels.Client;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories.Clients;

public interface IClientRepository: IGenericRepository<Client>
{
    Task<List<ClientDataModel>> GetAll();

    Task<List<ClientDataModel>> GetAllByCompanyId(Guid companyId);

    Task<ClientDetailDataModel> GetClientDetailById(Guid clientId);
}

