using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.HealthCondition;

public class UpdateClientHealthConditionCommandHandler : IRequestHandler<UpdateClientHealthConditionCommand, bool>
{
    private readonly IClientHealthConditionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateClientHealthConditionCommandHandler(IClientHealthConditionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateClientHealthConditionCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.CHCId, cancellationToken);
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
        data.LastModifiedOn = DateTime.Now;

        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}