using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Nutrition;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Nutrition;

public class AddClientNutritionCommandHandler : IRequestHandler<CreateClientNutritionCommand, ClientNutritionDataModel>
{
    private readonly IClientNutritionRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientNutritionCommandHandler(IClientNutritionRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientNutritionDataModel> Handle(CreateClientNutritionCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ClientNutrition>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientNutritionDataModel>(created);
    }
}