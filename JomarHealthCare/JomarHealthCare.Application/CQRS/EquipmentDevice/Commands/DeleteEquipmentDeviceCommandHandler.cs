using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.EquipmentDevice.Commands;

public class DeleteEquipmentDeviceCommandHandler : IRequestHandler<DeleteEquipmentDeviceDataCommand, bool>
{
    private readonly IEquipmentAssessmentDataRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteEquipmentDeviceCommandHandler(IEquipmentAssessmentDataRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteEquipmentDeviceDataCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
