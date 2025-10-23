using MediatR;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.Rotas;

public class DeleteRotaCommandHandler : IRequestHandler<DeleteRotaCommand, bool>
{
    private readonly IRotaRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteRotaCommandHandler(IRotaRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteRotaCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.Deleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
