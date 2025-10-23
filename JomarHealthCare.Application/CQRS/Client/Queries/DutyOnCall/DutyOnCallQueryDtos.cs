using MediatR;
using JomarHealthCare.Application.DataModels.Client.DutyOnCall;

namespace JomarHealthCare.Application.CQRS.Client.Queries.DutyOnCall;


public record GetClientDutyOnCallByIdQuery(int id) : IRequest<DutyOnCallDataModel>;

public record GetAllDutyOnCallByClientQuery(Guid clientId) : IRequest<List<DutyOnCallDataModel>>;