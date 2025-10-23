using MediatR;
using JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaTasks;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaType;

public class DeleteRotaTypeCommandHandler : IRequestHandler<DeleteRotaTypeCommand, bool>
{
    private readonly IClientRotaTypeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteRotaTypeCommandHandler(IClientRotaTypeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteRotaTypeCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.Deleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}