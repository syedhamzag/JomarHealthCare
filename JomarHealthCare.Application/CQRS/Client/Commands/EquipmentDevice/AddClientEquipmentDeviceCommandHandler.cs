using MediatR;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.EquipmentDevice;
public class AddClientEquipmentDeviceCommandHandler : IRequestHandler<AddClientEquipmentDeviceCommand, EquipmentAssessment>
{
    private readonly IClientEquipmentAssessmentRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddClientEquipmentDeviceCommandHandler(IClientEquipmentAssessmentRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<EquipmentAssessment> Handle(AddClientEquipmentDeviceCommand request, CancellationToken cancellationToken)
    {
        var data = new EquipmentAssessment
        {
            EquipmentName = request.EquipmentName,
            EquipmentLocation = request.EquipmentLocation,
            EquipmentStatus = request.EquipmentStatus,
            Url = request.Url,
            ExpiryDate = request.ExpiryDate,
            Training = request.Training,
            HowToUse = request.HowToUse,
            RiskOfClient = request.RiskOfClient,
            RiskOfStaff = request.RiskOfStaff,
            Environment = request.Environment,
            RiskControl = request.RiskControl,
            Escalation = request.Escalation,
            Attachment = request.Attachment,
            ClientId = request.ClientId
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}