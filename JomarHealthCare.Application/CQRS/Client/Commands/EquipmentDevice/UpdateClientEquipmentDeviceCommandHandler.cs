using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.EquipmentDevice;


public class UpdateClientEquipmentDeviceCommandHandler : IRequestHandler<UpdateClientEquipmentDeviceCommand, bool>
{
    private readonly IClientEquipmentAssessmentRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateClientEquipmentDeviceCommandHandler(IClientEquipmentAssessmentRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateClientEquipmentDeviceCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.EquipmentName = request.EquipmentName;
        data.EquipmentLocation = request.EquipmentLocation;
        data.EquipmentStatus = request.EquipmentStatus;
        data.Url = request.Url;
        data.ExpiryDate = request.ExpiryDate;
        data.Training = request.Training;
        data.HowToUse = request.HowToUse;
        data.RiskOfClient = request.RiskOfClient;
        data.RiskOfStaff = request.RiskOfStaff;
        data.Environment = request.Environment;
        data.RiskControl = request.RiskControl;
        data.Escalation = request.Escalation;
        data.Attachment = request.Attachment;

        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}