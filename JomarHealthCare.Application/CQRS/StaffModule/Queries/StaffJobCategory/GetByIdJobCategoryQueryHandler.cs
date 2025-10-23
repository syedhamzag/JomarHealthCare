using MediatR;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
using JomarHealthCare.Application.DataModels.StaffModule.StaffJobCategory;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.StaffJobCategory;

internal class GetByIdJobCategoryQueryHandler : IRequestHandler<GetJobCategoryByIdQuery, JobCategoryDataModel>
{
    private readonly IJobCategoryRepository _repository;

    public GetByIdJobCategoryQueryHandler(IJobCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<JobCategoryDataModel> Handle(GetJobCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new JobCategoryDataModel
        {
            Id = entity.Id,
            Name = entity.CategoryName,
            CompanyId = entity.CompanyId,
        };
    }
}