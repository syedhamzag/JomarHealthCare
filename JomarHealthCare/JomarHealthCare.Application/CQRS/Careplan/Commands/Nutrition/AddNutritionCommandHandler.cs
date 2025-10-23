using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Nutrition;

public class AddNutritionCommandHandler : IRequestHandler<CreateNutritionCommand, CarePlanNutritionDataModel>
{
    private readonly IClientCarePlanNutritionRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddNutritionCommandHandler(IClientCarePlanNutritionRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<CarePlanNutritionDataModel> Handle(CreateNutritionCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<CarePlanNutrition>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<CarePlanNutritionDataModel>(created);
    }
}