using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Policy;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Policy.Queries;

internal class GetAllPolicyQueryHander : IRequestHandler<GetAllPolicyQuery, List<PolicyDataModel>>
{
    private readonly IPolicyRepository _repository;

    public GetAllPolicyQueryHander(IPolicyRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<PolicyDataModel>> Handle(GetAllPolicyQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => !x.IsDeleted).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new PolicyDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            Ref = entity.Ref,
            Description = entity.Description,
            StartTime = entity.StartTime,
            LastReview = entity.LastReview,
            EndDate = entity.EndDate,
            PolicyOwner = entity.PolicyOwner,
            PolicyType = entity.PolicyType,
            Link = entity.Link
        }).ToList();
    }
}