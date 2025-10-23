using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Nutrition;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Nutrition;

internal class GetByClientIdNutritionQueryHandler : IRequestHandler<GetByClientIdNutritionQuery, ClientNutritionDataModel>
{
    private readonly IClientNutritionRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientIdNutritionQueryHandler(IClientNutritionRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ClientNutritionDataModel> Handle(GetByClientIdNutritionQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Include(x => x.ClientMealDays).Include(x => x.ClientCleaning).Include(x => x.ClientShopping).Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new ClientNutritionDataModel();
        }

        return _mapper.Map<ClientNutritionDataModel>(entity);
    }
}
