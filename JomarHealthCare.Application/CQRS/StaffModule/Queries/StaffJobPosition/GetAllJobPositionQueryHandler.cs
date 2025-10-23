using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.CQRS.StaffModule.Queries.QueryDtos;
using JomarHealthCare.Application.DataModels.StaffModule.StaffJobPosition;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Queries.StaffJobPosition;


internal class GetAllJobPositionQueryHandler : IRequestHandler<GetAllJobPositionQuery, List<JobPositionDataModel>>
{
    private readonly IJobPositionRepository _repository;

    public GetAllJobPositionQueryHandler(IJobPositionRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<JobPositionDataModel>> Handle(GetAllJobPositionQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().ToListAsync(); // This method should return all records.

        return entities.Select(entity => new JobPositionDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}
