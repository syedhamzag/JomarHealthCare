using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.ClientRota;

public record GetByIdClientRotaQuery(Guid clientId) : IRequest<List<ClientRotaDataModel>>;
