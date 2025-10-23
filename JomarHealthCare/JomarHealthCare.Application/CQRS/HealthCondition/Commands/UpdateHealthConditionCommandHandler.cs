using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HealthCondition.Commands;


public class UpdateHealthConditionCommandHandler : IRequestHandler<UpdateHealthConditionCommand, bool>
{
    private readonly IHealthConditionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateHealthConditionCommandHandler(IHealthConditionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateHealthConditionCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.HCId, cancellationToken);
        if (data == null) return false;

        data.Name = request.Name;
        data.Description = request.Description;
        data.Condition = request.Condition;
        data.CausesAndTrigger = request.CausesAndTrigger;
        data.Symptoms = request.Symptoms;
        data.ClientManagingWithCondition = request.ClientManagingWithCondition;
        data.RiskToClient = request.RiskToClient;
        data.RiskToStaff = request.RiskToStaff;
        data.ActionRequiredToStaff = request.ActionRequiredToStaff;
        data.EscalationsApproach = request.EscalationsApproach;
        data.Image = request.Image;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}