using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.HospitalEntry;

public class DeleteHospitalEntryCommandHandler : IRequestHandler<DeleteHospitalEnteryCommand, bool>
{
    private readonly IClientHospitalEnteryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteHospitalEntryCommandHandler(IClientHospitalEnteryRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteHospitalEnteryCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.IsDeleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}

