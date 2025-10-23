using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.ServiceType;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ServiceTypes.Queries;

internal class GetAllByCompanyServiceTypeQueryHandler : IRequestHandler<GetAllServiceTypeCompanyIdQuery, List<ServiceTypeDataModel>>
{
    private readonly IServiceTypeRepository _repository;

    public GetAllByCompanyServiceTypeQueryHandler(IServiceTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ServiceTypeDataModel>> Handle(GetAllServiceTypeCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ServiceTypeDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}