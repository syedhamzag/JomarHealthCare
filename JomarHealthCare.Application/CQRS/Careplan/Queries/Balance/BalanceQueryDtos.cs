using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Balance;
public record GetByClientBalanceQuery(Guid clientId) : IRequest<List<BalanceDataModel>>;
public record GetByIdBalanceQuery(int id) : IRequest<BalanceDataModel>;