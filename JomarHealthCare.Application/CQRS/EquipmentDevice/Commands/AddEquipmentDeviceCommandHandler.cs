using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.EquipmentDevice.Commands;

public class AddEquipmentDeviceCommandHandler : IRequestHandler<AddEquipmentDeviceDataCommand, EquipmentAssessmentData>
{
    private readonly IEquipmentAssessmentDataRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddEquipmentDeviceCommandHandler(IEquipmentAssessmentDataRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<EquipmentAssessmentData> Handle(AddEquipmentDeviceDataCommand request, CancellationToken cancellationToken)
    {
        var data = new EquipmentAssessmentData
        {
            EquipmentAssessmentId = request.EquipmentAssessmentId,
            URL = request.URL,
            HowToUse = request.HowToUse,
            ClientRisk = request.ClientRisk,
            StaffRisk = request.StaffRisk,
            Image = request.Image,
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}