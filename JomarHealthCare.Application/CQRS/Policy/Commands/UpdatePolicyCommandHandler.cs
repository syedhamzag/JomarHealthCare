using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Policy.Commands;

public class UpdatePolicyCommandHandler : IRequestHandler<UpdatePolicyCommand, bool>
{
    private readonly IPolicyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdatePolicyCommandHandler(IPolicyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(UpdatePolicyCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.Name = request.Name;
        data.Ref = request.Ref;
        data.Ref = request.Ref;
        data.PolicyOwner = request.PolicyOwner;
        data.StartTime = request.StartTime;
        data.LastReview = request.LastReview;
        data.EndDate = request.EndDate;
        data.Description = request.Description;
        data.PolicyType = request.PolicyType;
        data.Link = request.Link;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}