using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Policy.Commands;
public class CreatePolicyCommandHandler : IRequestHandler<CreatePolicyCommand, Policies>
{
    private readonly IPolicyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public CreatePolicyCommandHandler(IPolicyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Policies> Handle(CreatePolicyCommand request, CancellationToken cancellationToken)
    {
        var data = new Policies
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Ref = request.Ref,
            PolicyOwner = request.PolicyOwner,
            StartTime = request.StartTime,
            LastReview = request.LastReview,
            EndDate = request.EndDate,
            Description = request.Description,
            PolicyType = request.PolicyType,
            Link = request.Link
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}