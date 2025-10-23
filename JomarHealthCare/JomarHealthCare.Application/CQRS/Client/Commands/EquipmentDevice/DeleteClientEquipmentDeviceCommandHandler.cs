using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.EquipmentDevice;

public class DeleteClientEquipmentDeviceCommandHandler : IRequestHandler<DeleteClientEquipmentDeviceCommand, bool>
{
    private readonly IClientEquipmentAssessmentRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteClientEquipmentDeviceCommandHandler(IClientEquipmentAssessmentRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteClientEquipmentDeviceCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.IsDeleted = true; // Assuming you want to soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}