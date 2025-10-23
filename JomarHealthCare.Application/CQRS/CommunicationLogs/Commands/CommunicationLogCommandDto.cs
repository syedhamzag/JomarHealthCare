using MediatR;
using JomarHealthCare.Application.DataModels.CommunicationLogs;

namespace JomarHealthCare.Application.CQRS.CommunicationLogs.Commands
{
    public record CreateCommunicationLogCommand(CommunicationLogDataModel DataModel) : IRequest<CommunicationLogDataModel>;
    public record DeleteCommunicationLogCommand(int CommunicationLogId) : IRequest<bool>;
    public record UpdateCommunicationLogCommand(CommunicationLogDataModel DataModel) : IRequest<bool>;
}