using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
using JomarHealthCare.Application.DataModels.StaffModule.StaffJobCategory;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.StaffJobCategory;



internal class GetAllJobCategoryQueryHandler : IRequestHandler<GetAllJobCategoryQuery, List<JobCategoryDataModel>>
{
    private readonly IJobCategoryRepository _repository;

    public GetAllJobCategoryQueryHandler(IJobCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<JobCategoryDataModel>> Handle(GetAllJobCategoryQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().ToListAsync(); // This method should return all records.

        return entities.Select(entity => new JobCategoryDataModel
        {
            Id = entity.Id,
            Name = entity.CategoryName,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}