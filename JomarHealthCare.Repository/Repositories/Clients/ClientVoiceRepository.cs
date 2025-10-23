using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientVoiceRepository : GenericRepository<ClientVoice>, IClientVoiceRepository
{
    public ClientVoiceRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
