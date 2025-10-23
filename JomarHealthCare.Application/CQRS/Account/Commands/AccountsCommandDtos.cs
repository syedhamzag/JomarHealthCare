using MediatR;
using JomarHealthCare.Application.DataModels.Account;

namespace JomarHealthCare.Application.CQRS.Account.Commands;


public record AddSuperAdminCommand(AddSuperAdminDataModel DataModel) : IRequest<string>;
