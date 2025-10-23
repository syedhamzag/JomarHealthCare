using MediatR;
using JomarHealthCare.Application.DataModels.Client.Program;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Program;


public record GetByClientProgramQuery(Guid clientId) : IRequest<List<ClientProgramDataModel>>;
public record GetByIdClientProgramQuery(int id) : IRequest<ClientProgramDataModel>;