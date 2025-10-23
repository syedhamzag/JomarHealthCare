using MediatR;
using JomarHealthCare.Application.DataModels.Policy;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Policy.Queries;


internal class GetPolicyByIdQueryHandler : IRequestHandler<GetPolicyByIdQuery, PolicyDataModel>
{
    private readonly IPolicyRepository _repository;

    public GetPolicyByIdQueryHandler(IPolicyRepository repository)
    {
        _repository = repository;
    }

    public async Task<PolicyDataModel> Handle(GetPolicyByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.PolicyId, cancellationToken);
        return new PolicyDataModel
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
        };
    }
}