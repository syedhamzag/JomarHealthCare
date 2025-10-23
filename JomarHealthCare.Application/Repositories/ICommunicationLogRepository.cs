using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories;

public interface ICommunicationLogRepository : IGenericRepository<CommunicationLog>
{
}
public interface ICommunicationLogAttendeesRepository : IGenericRepository<CommunicationLogAttendees>
{
}
public interface ICommunicationLogApologiesRepository : IGenericRepository<CommunicationLogApologies>
{
}