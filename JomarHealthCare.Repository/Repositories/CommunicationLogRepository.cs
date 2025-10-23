using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class CommunicationLogRepository : GenericRepository<CommunicationLog>, ICommunicationLogRepository
{
    public CommunicationLogRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
public class CommunicationLogAttendeesRepository : GenericRepository<CommunicationLogAttendees>, ICommunicationLogAttendeesRepository
{
    public CommunicationLogAttendeesRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
public class CommunicationLogApologiesRepository : GenericRepository<CommunicationLogApologies>, ICommunicationLogApologiesRepository
{
    public CommunicationLogApologiesRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}