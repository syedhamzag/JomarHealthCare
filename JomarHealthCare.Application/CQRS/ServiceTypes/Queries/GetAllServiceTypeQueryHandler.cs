using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.ServiceType;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ServiceTypes.Queries;

internal class GetAllServiceTypeQueryHandler : IRequestHandler<GetAllServiceTypeQuery, List<ServiceTypeDataModel>>
{
    private readonly IServiceTypeRepository _repository;

    public GetAllServiceTypeQueryHandler(IServiceTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ServiceTypeDataModel>> Handle(GetAllServiceTypeQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ServiceTypeDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}
