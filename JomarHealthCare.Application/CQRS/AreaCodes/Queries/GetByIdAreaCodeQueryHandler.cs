using MediatR;
using JomarHealthCare.Application.DataModels.AreaCode;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.AreaCodes.Queries;

internal class GetByIdAreaCodeQueryHandler : IRequestHandler<GetAreaCodeByIdQuery, AreaCodeDataModel>
{
    private readonly IAreaCodeRepository _repository;

    public GetByIdAreaCodeQueryHandler(IAreaCodeRepository repository)
    {
        _repository = repository;
    }

    public async Task<AreaCodeDataModel> Handle(GetAreaCodeByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new AreaCodeDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId,
        };
    }
}