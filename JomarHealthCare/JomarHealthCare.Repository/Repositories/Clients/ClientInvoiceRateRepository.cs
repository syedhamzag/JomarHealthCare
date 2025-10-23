using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

internal class ClientInvoiceRateRepository : GenericRepository<ClientInvoiceRate>, IClientInvoiceRateRepository
{
    public ClientInvoiceRateRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
