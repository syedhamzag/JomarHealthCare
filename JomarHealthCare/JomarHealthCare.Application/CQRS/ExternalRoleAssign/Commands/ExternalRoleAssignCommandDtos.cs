using MediatR;
using JomarHealthCare.Application.DataModels.AppointmentBookings;
using JomarHealthCare.Application.DataModels.ExternalUser;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Commands;


public record AddExternalRoleAccessCommand(ExternalRoleAccessDataModel DataModel) : IRequest<ExternalRoleAccessDataModel>;
public record DeleteExternalRoleAccessCommand(int id) : IRequest<bool>;
public record UpdateExternalRoleAccessCommand(ExternalRoleAccessDataModel DataModel) : IRequest<bool>;
