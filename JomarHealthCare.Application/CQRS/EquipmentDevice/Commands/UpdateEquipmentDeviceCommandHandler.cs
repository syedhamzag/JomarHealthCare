using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.EquipmentDevice.Commands;


public class UpdateEquipmentDeviceCommandHandler : IRequestHandler<UpdateEquipmentDeviceDataCommand, bool>
{
    private readonly IEquipmentAssessmentDataRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateEquipmentDeviceCommandHandler(IEquipmentAssessmentDataRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateEquipmentDeviceDataCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.EquipmentAssessmentId = request.EquipmentAssessmentId;
        data.URL = request.URL;
        data.HowToUse = request.HowToUse;
        data.ClientRisk = request.ClientRisk;
        data.StaffRisk = request.StaffRisk;
        data.Image = request.Image;

        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}