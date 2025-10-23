using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Hobby;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Hobby.Queries;

internal class GetAllHobbyQueryHandler : IRequestHandler<GetAllHobbyQuery, List<HobbyDataModel>>
{
    private readonly IHobbyRepository _repository;

    public GetAllHobbyQueryHandler(IHobbyRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<HobbyDataModel>> Handle(GetAllHobbyQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().ToListAsync(); // This method should return all records.

        return entities.Select(entity => new HobbyDataModel
        {
            HId = entity.HId,
            Name = entity.Name,
            Description = entity.Description,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}
