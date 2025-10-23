using MediatR;
using JomarHealthCare.Application.DataModels.Client.Program;
using JomarHealthCare.Application.DataModels.Management;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Management;

public record GetByClientMgtVisitQuery(Guid clientId) : IRequest<List<ClientMgtVisitDataModel>>;
public record GetByIdClientMgtVisitQuery(int id) : IRequest<ClientMgtVisitDataModel>;