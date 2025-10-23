using MediatR;
using JomarHealthCare.Application.DataModels.Account;

namespace JomarHealthCare.Application.CQRS.Account.Commands;


public record UpdateSuperAdminCommand(UpdateSuperAdminDataModel DataModel) : IRequest<string>;
