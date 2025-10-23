using MediatR;
using JomarHealthCare.Application.DataModels.ExternalUser;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Commands;


public record AddExternalUserCommand(ExternalUserDataModel DataModel) : IRequest<string>;
public record DeleteExternalUserCommand(int id) : IRequest<bool>;
public record UpdateExternalUserCommand(ExternalUserDataModel DataModel) : IRequest<bool>;
