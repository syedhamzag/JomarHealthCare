using MediatR;
using JomarHealthCare.Application.DataModels.ServiceType;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ServiceTypes.Queries;


internal class GetByIdServiceTypeQueryHandler : IRequestHandler<GetServiceTypeByIdQuery, ServiceTypeDataModel>
{
    private readonly IServiceTypeRepository _repository;

    public GetByIdServiceTypeQueryHandler(IServiceTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<ServiceTypeDataModel> Handle(GetServiceTypeByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ServiceTypeDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId,
        };
    }
}