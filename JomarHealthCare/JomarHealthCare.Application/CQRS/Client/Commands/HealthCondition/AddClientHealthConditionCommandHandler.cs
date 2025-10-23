using MediatR;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.HealthCondition;
public class AddClientHealthConditionCommandHandler : IRequestHandler<AddClientHealthConditionCommand, ClientHealthCondition>
{
    private readonly IClientHealthConditionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddClientHealthConditionCommandHandler(IClientHealthConditionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<ClientHealthCondition> Handle(AddClientHealthConditionCommand request, CancellationToken cancellationToken)
    {
        var data = new ClientHealthCondition
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
            ClientId = request.ClientId,
            CreatedOn = DateTime.Now
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}