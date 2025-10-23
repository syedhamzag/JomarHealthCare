using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Nutrition;

internal class GetByClientNutritionQueryHandler : IRequestHandler<GetByClientCarePlanNutritionQuery, CarePlanNutritionDataModel>
{
    private readonly IClientCarePlanNutritionRepository _repository;

    public GetByClientNutritionQueryHandler(IClientCarePlanNutritionRepository repository)
    {
        _repository = repository;
    }

    public async Task<CarePlanNutritionDataModel> Handle(GetByClientCarePlanNutritionQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new CarePlanNutritionDataModel();
        }
        return new CarePlanNutritionDataModel
        {
            NutritionId = entity.NutritionId,
            FoodStorage = entity.FoodStorage,
            ServingMeal = entity.ServingMeal,
            WhenRestock = entity.WhenRestock,
            WhoRestock = entity.WhoRestock,
            SpecialDiet = entity.SpecialDiet,
            DrinkType = entity.DrinkType,
            AvoidFood = entity.AvoidFood,
            ThingsILike = entity.ThingsILike,
            FoodIntake = entity.FoodIntake,
            MealPreparation = entity.MealPreparation,
            EatingDifficulty = entity.EatingDifficulty,
            RiskMitigations = entity.RiskMitigations,
            ClientId = entity.ClientId,
            FoodIntakeDetail = entity.FoodIntakeDetail,
            EatingDifficultyDetail = entity.EatingDifficultyDetail
        };
    }
}

