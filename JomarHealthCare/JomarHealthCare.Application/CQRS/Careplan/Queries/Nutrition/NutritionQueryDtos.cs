using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Nutrition;

public record GetByClientCarePlanNutritionQuery(Guid clientId) : IRequest<CarePlanNutritionDataModel>;
