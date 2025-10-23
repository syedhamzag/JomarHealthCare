using MediatR;
using JomarHealthCare.Application.DataModels.Client;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Queries;

public record GetAllClientQuery() : IRequest<List<ClientDataModel>>;

public record GetAllClientCompanyIdQuery(Guid companyId) : IRequest<List<ClientDataModel>>;


public record GetClientDetailByIdQuery(Guid clientId) : IRequest<ClientDetailDataModel>;


public record GetClientForUpdateByIdQuery(Guid clientId) : IRequest<JomarHealthCare.Domain.Entities.Client>;
