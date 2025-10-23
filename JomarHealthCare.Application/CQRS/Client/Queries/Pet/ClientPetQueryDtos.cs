using MediatR;
using JomarHealthCare.Application.DataModels.Pet;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Pet;


public record GetByClientPetQuery(Guid clientId) : IRequest<ClientPetDataModel>;
