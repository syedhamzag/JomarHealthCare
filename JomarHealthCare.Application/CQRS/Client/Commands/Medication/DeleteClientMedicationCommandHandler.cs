using MediatR;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Medication;

public class DeleteClientMedicationCommandHandler : IRequestHandler<DeleteClientMedicationCommand, bool>
{
    private readonly IClientMedicationRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteClientMedicationCommandHandler(IClientMedicationRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteClientMedicationCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.IsDeleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}