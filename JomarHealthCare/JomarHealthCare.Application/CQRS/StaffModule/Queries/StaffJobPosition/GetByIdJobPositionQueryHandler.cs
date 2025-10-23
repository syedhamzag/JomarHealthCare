using MediatR;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
using JomarHealthCare.Application.DataModels.StaffModule.StaffJobPosition;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.StaffJobPosition;

internal class GetByIdJobPositionQueryHandler : IRequestHandler<GetJobPositionByIdQuery, JobPositionDataModel>
{
    private readonly IJobPositionRepository _repository;

    public GetByIdJobPositionQueryHandler(IJobPositionRepository repository)
    {
        _repository = repository;
    }

    public async Task<JobPositionDataModel> Handle(GetJobPositionByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new JobPositionDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId,
        };
    }
}