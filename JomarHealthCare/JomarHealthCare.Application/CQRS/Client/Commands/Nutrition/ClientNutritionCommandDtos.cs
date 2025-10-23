using MediatR;
using JomarHealthCare.Application.DataModels.Client.Nutrition;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Nutrition;

public record CreateClientNutritionCommand(ClientNutritionDataModel DataModel) : IRequest<ClientNutritionDataModel>;
public record UpdateClientNutritionCommand(ClientNutritionDataModel DataModel) : IRequest<bool>;