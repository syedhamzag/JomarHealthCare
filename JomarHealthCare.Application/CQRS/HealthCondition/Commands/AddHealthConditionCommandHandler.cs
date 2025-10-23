using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HealthCondition.Commands;


public class AddHealthConditionCommandHandler : IRequestHandler<AddHealthConditionCommand, JomarHealthCare.Domain.Entities.HealthCondition>
{
    private readonly IHealthConditionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddHealthConditionCommandHandler(IHealthConditionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<JomarHealthCare.Domain.Entities.HealthCondition> Handle(AddHealthConditionCommand request, CancellationToken cancellationToken)
    {
        var data = new JomarHealthCare.Domain.Entities.HealthCondition
        {
            Name = request.Name,
            Description = request.Description,
            Condition = request.Condition,
            CausesAndTrigger = request.CausesAndTrigger,
            Symptoms = request.Symptoms,
            ClientManagingWithCondition = request.ClientManagingWithCondition,
            RiskToClient = request.RiskToClient,
            RiskToStaff = request.RiskToStaff,
            ActionRequiredToStaff = request.ActionRequiredToStaff,
            EscalationsApproach = request.EscalationsApproach,
            Image = request.Image,
            CreatedBy = Convert.ToString(request.CompanyId),
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}