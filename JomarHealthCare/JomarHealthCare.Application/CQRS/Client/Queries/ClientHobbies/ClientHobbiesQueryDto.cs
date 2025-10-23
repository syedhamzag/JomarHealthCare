using MediatR;
using JomarHealthCare.Application.DataModels.Client.ClientHobbies;

namespace JomarHealthCare.Application.CQRS.Client.Queries.ClientHobbies;


public record GetClientHobbiesByClientIdQuery(Guid clientId) : IRequest<List<ClientHobbiesDataModel>>;
