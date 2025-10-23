using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.DutyOnCall;


public class DeleteDutyOnCallCommandHandler : IRequestHandler<DeleteDutyOnCallCommand, bool>
{
    private readonly IClientDutyOnCallRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteDutyOnCallCommandHandler(IClientDutyOnCallRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteDutyOnCallCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.IsDeleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
