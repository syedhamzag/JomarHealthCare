using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Nutrition;

public class UpdateClientNutritionCommandHandler : IRequestHandler<UpdateClientNutritionCommand, bool>
{
    private readonly IClientNutritionRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateClientNutritionCommandHandler(IClientNutritionRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateClientNutritionCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.NutritionId, cancellationToken);

        if (existing == null)
            throw new Exception("Nutrition record not found");

        // Update scalar fields
        _mapper.Map(request.DataModel, existing);

        // Update ClientShopping
        existing.ClientShopping.Clear();
        if (request.DataModel.ClientShopping != null && request.DataModel.ClientShopping.Any())
        {
            foreach (var shopping in request.DataModel.ClientShopping)
            {
                existing.ClientShopping.Add(_mapper.Map<ClientShopping>(shopping));
            }
        }

        // Update ClientCleaning
        existing.ClientCleaning.Clear();
        if (request.DataModel.ClientCleaning != null && request.DataModel.ClientCleaning.Any())
        {
            foreach (var cleaning in request.DataModel.ClientCleaning)
            {
                existing.ClientCleaning.Add(_mapper.Map<ClientCleaning>(cleaning));
            }
        }

        // Update ClientMealDays
        existing.ClientMealDays.Clear();
        if (request.DataModel.ClientMealDays != null && request.DataModel.ClientMealDays.Any())
        {
            foreach (var meal in request.DataModel.ClientMealDays)
            {
                existing.ClientMealDays.Add(_mapper.Map<ClientMealDays>(meal));
            }
        }

        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);

        return true;
    }
}
