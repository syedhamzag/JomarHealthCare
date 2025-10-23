using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Hobby;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Hobby.Queries;

internal class GetAllHobbyByCompanyQueryHandler : IRequestHandler<GetAllHobbyByCompanyIdQuery, List<HobbyDataModel>>
{
    private readonly IHobbyRepository _repository;

    public GetAllHobbyByCompanyQueryHandler(IHobbyRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<HobbyDataModel>> Handle(GetAllHobbyByCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new HobbyDataModel
        {
            HId = entity.HId,
            Name = entity.Name,
            Description = entity.Description,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}