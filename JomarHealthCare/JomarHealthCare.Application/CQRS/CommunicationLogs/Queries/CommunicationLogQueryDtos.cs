using MediatR;
using JomarHealthCare.Application.DataModels.CommunicationLogs;

namespace JomarHealthCare.Application.CQRS.CommunicationLogs.Queries;


public record GetCommunicationLogByIdQuery(int id) : IRequest<CommunicationLogDataModel>;

public record GetAllCommunicationLogByIdQuery(Guid id) : IRequest<List<CommunicationLogDataModel>>;
public record GetAllCommunicationLogByAttendeeIdQuery(Guid attendeeId) : IRequest<List<CommunicationLogDataModel>>;