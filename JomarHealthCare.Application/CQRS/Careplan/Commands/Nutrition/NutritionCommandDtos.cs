using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Nutrition;

public record CreateNutritionCommand(CarePlanNutritionDataModel DataModel) : IRequest<CarePlanNutritionDataModel>;
public record UpdateNutritionCommand(CarePlanNutritionDataModel DataModel) : IRequest<bool>;