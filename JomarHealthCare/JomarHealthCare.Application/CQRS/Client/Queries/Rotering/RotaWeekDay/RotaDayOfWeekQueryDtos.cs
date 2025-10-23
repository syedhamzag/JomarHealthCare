using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaWeekDay;


public record GetAllRotaDayOfWeeKQuery() : IRequest<List<RotaDayofWeekDataModel>>;