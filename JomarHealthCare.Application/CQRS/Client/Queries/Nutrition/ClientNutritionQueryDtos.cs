using MediatR;
using JomarHealthCare.Application.DataModels.Client.Nutrition;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Nutrition;

public record GetByClientIdNutritionQuery(Guid clientId) : IRequest<ClientNutritionDataModel>;

