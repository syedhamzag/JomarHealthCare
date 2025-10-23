using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.AreaCode;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.AreaCodes.Queries;

internal class GetAllByCompanyAreaCodeQueryHandler : IRequestHandler<GetAllAreaCodeByCompanyIdQuery, List<AreaCodeDataModel>>
{
    private readonly IAreaCodeRepository _repository;

    public GetAllByCompanyAreaCodeQueryHandler(IAreaCodeRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<AreaCodeDataModel>> Handle(GetAllAreaCodeByCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new AreaCodeDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}