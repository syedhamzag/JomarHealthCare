using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
using JomarHealthCare.Application.DataModels.StaffModule.StaffJobCategory;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.StaffJobCategory;

internal class GetAllByCompanyJobCategoryQueryHandler : IRequestHandler<GetAllJobCategoryCompanyIdQuery, List<JobCategoryDataModel>>
{
    private readonly IJobCategoryRepository _repository;

    public GetAllByCompanyJobCategoryQueryHandler(IJobCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<JobCategoryDataModel>> Handle(GetAllJobCategoryCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new JobCategoryDataModel
        {
            Id = entity.Id,
            Name = entity.CategoryName,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}